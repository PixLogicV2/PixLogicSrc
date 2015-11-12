using PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PixLogic
{
    class Helper
    {
        private static Database database = new Database();

        public static readonly string ADD = "ajouter";
        public static readonly string DELETE = "supprimer";
        public static readonly string SET = "modifier";

        public static bool fieldsAreEmpty(bool withMessageBox, params string[] args)
        {
            bool result = false;

            foreach(string field in args)
            {
                if(field.Equals(""))
                {
                    result = true;
                    if(withMessageBox)
                        MessageBox.Show("Tous les champs obligatoires (*) n'ont pas été rempli!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return result;
        }

        public static bool AreNumbers(bool withMessageBox, params string[] args)
        {
            bool result = true;
            double nombre;

            foreach(string num in args)
            {
                if(!double.TryParse(num, out nombre))
                {
                    result = false;
                    if(withMessageBox)
                        MessageBox.Show("Vous avez renseigné un texte dans un champs de type nombre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return result;
        }

        public static bool confirmation(string op)
        {
            bool result = false;
            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment "+op+" cet élément ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }

        public static void addSuccess()
        {
            MessageBox.Show("L'élément a été bien ajouté !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool itemExist(bool withMessageBox, string name)
        {
            if(database.ContainItem(name))
            {
                if(withMessageBox)
                    MessageBox.Show("Le nom du matériel renseigné existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
                
        }

        public static void putImageInBox(PictureBox picBox, Image image)
        {
            picBox.Image = image;
            if (image != null)
            {
                if (image.Size.Height < picBox.Size.Height
                    && image.Size.Width < picBox.Size.Width)
                    picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                else
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
