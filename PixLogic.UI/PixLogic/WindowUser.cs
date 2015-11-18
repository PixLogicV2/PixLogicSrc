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
            add = true;
        }
        public WindowUser(panUsers pa, Image image, string name, string nickname, string mail, string classe,string phone)
        {
            InitializeComponent();
            this.Text = "Modifier Utilisateur";
            pan = pa;
            img = image;
            Helper.putImageInBox(pictureBoxItem, img);
            valName.Text = name;
            valNickName.Text =nickname;
            valClass.Text= classe;
            valMail.Text = mail;
            valTel.Text = phone;
            add = false;
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
            string classe = valClass.Text;
            string option = add ? Helper.ADD : Helper.SET;

            if (!Helper.fieldsAreEmpty(true, name, nickname, mail,tel,classe)
                && Helper.confirmation(option))
            {
                if (add)
                {
                    database.AddUser(name, nickname, mail, classe, tel,img);
                }
                else if (!add )
                {
                    database.UpdateUser(Convert.ToInt32(pan.valUserId.Text), name, nickname, mail,tel,classe,img);
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

