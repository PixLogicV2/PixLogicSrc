using PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixLogic
{
    public partial class WindowUser : Form
    {
        private Database database = Helper.database;
        private panUsers pan;
        private Image img = null;
        private bool add;

        public WindowUser(panUsers p)
        {
            InitializeComponent();
            this.Text = "Nouvel Utilisateur";
            pan = p;
            img = Properties.Resources.noprofil;
            Helper.putImageInBox(pictureBoxItem, img);
            setComboBoxClasse();
            add = true;
        }
        public WindowUser(panUsers pa, Image image, string name, string nickname, string mail, string classe,string phone)
        {
            InitializeComponent();
            this.Text = "Modifier Utilisateur";
            pan = pa;
            img = image;
            Helper.putImageInBox(pictureBoxItem, img);
            setComboBoxClasse(classe);
            valName.Text = name;
            valNickName.Text =nickname;
            valMail.Text = mail;
            valTel.Text = phone;
            add = false;
        }

        private void setComboBoxClasse(string nom = "")
        {
            comboBoxClasse.Items.Clear();
            List<UserClass> list = database.GetAllUserClass();

            comboBoxClasse.Items.Add("");
            foreach (var classe in list)
            {
                comboBoxClasse.Items.Add(classe.name);
            }
            if (comboBoxClasse.Items.Count > 0)
            {
                if (add)
                    comboBoxClasse.SelectedIndex = 0;
                else
                {
                    int index = 0;
                    foreach (var i in comboBoxClasse.Items)
                    {
                        if (i.Equals(nom))
                            break;
                        index++;
                    }
                    comboBoxClasse.SelectedIndex = index;
                }
            }
        }

        private void chooseImage()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "Images/";
                f.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    img = Image.FromFile(f.FileName);
                    Helper.putImageInBox(pictureBoxItem, img);
                }
            }
            catch (Exception e) { MessageBox.Show("Error :" + e); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            string name = valName.Text;
            string nickname = valNickName.Text;
            string mail = valMail.Text;
            string tel = valTel.Text;
            string classe = comboBoxClasse.SelectedItem.ToString();
            string option = add ? Helper.ADD : Helper.SET;

            if (!Helper.fieldsAreEmpty(true, name, nickname, mail, classe)
                && Helper.confirmation(option))
            {
                if (add)
                {
                    database.AddUser(name, nickname, mail, classe, tel,img);
                }
                else if (!add )
                {
                    database.UpdateUser(Convert.ToInt32(pan.valUserId.Text), name, nickname, mail,classe, tel,img);
                }
                //Helper.addSuccess();
                pan.setTableUsers(database.GetAllUsers());
                this.Close();
            }
        }

        private void pictureBoxSelection_Click_1(object sender, EventArgs e)
        {
            chooseImage();
        }

    }
}

