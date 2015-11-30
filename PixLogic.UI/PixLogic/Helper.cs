using PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PixLogic
{
    class Helper
    {
        public static Database database = new Database();

        public static readonly string ADD = "ajouter";
        public static readonly string DELETE = "supprimer";
        public static readonly string SET = "modifier";
        public static readonly string REMOVE = "enlever";
        public static readonly string CANCEL = "annuler";
        public static readonly string PACK = "Pack";
        public static readonly string ITEM = "Matériel";

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

        public static bool beginBeforeEndDate(bool withMessageBox, DateTime begin, DateTime end)
        {
            if (begin.CompareTo(end) <= 0)
                return true;
            else
            {
                if(withMessageBox)
                    MessageBox.Show("La date de debut est supérieure à celle de fin!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public static bool IsInListBox(string name, ListBox list)
        {
            foreach(string n in list.Items)
            {
                if (n.Equals(name))
                    return true;
            }

            return false;
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
        public static bool confirmationReservation(string op)
        {
            bool result = false;
            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment " + op + " cette réservation ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }

        public static bool confirmationEmprunt(int idReservation)
        {
            bool result = false;
            Reservation reservation = database.GetReservationById(idReservation);
            string nameReservable = reservation.reservable.name;
            string user = reservation.user.name +" "+ reservation.user.nickname;

            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment prêter l'élément " + nameReservable.ToUpper() + " à l'utilisateur "+user.ToUpper()+" ?",
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
        public static bool itemExistModif(bool withMessageBox, string name, string oldName)
        {
            if (database.ContainItem(name) && !name.Equals(oldName))
            {
                if (withMessageBox)
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

        public static void testApp()
        {
            foreach (var item in database.GetAllItems())
            {
                database.DeleteItem(item.name);
            }
           for (int i = 0; i < 2000; i++)
            {
                database.AddItem("NameItem " + i, "Description " + i, true, (i * 0.8f), Properties.Resources.camera_photo, "Reference " + 1, i + 1);
            }
        }

        public static bool reservationStartMinimumToday(bool withMessageBox, DateTime debut)
        {
            if (DateTime.Today <= debut.Date)
                return true;
            else
            {
                MessageBox.Show("La date de debut de reservation est inférieur à la date d'aujourdhui.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool getDispoReservableByDate(bool withMessageBox, int idReservable, DateTime dateDebut,DateTime dateFin)
        {
            List<Reservation> reservations = database.GetAllReservationsByReservableId(idReservable);

            foreach(Reservation reservation in reservations)
            {
                if((reservation.beginDateReservation.Value.Date <= dateDebut.Date
                    && reservation.endDateReservation.Value.Date >= dateDebut.Date)
                    ||
                    (reservation.beginDateReservation.Value.Date <= dateFin.Date
                    && reservation.endDateReservation.Value.Date >= dateFin.Date))
                {
                    if (withMessageBox)
                        MessageBox.Show("Les dates pour lesquelles vous désirez réserver ne sont plus disponibles.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            return true;
            
        }

        public static bool getDispoReservableByDateForModif(bool withMessageBox, int idReservable, int idReservation, DateTime dateDebut, DateTime dateFin)
        {
            List<Reservation> reservations = database.GetAllReservationsByReservableId(idReservable);

            foreach (Reservation reservation in reservations)
            {
                if(reservation.ReservationId != idReservation)
                {
                    if ((reservation.beginDateReservation.Value.Date <= dateDebut.Date
                    && reservation.endDateReservation.Value.Date >= dateDebut.Date)
                    ||
                    (reservation.beginDateReservation.Value.Date <= dateFin.Date
                    && reservation.endDateReservation.Value.Date >= dateFin.Date))
                    {
                        if (withMessageBox)
                            MessageBox.Show("Les dates pour lesquelles vous désirez réserver ne sont plus disponibles.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;

        }
    }
}
