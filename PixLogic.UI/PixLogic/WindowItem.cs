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
    public partial class WindowItem : Form
    {
        private Database database = new Database();
        private panItemPack pan;
        private Image img = null;
        private bool add;

        public WindowItem(panItemPack p)
        {
            InitializeComponent();
            this.Text = "Nouveau matériel";
            pan = p;
            add = true;
        }
        public WindowItem(string image, string name, double price, int quantity, string descrip)
        {
            InitializeComponent();
            this.Text = "Modifier matériel";
            valName.Text = name;
            valPrice.Text = Convert.ToString(price);
            valQuantity.Text = Convert.ToString(quantity);
            valDescription.Text = descrip;
            add = false;
        }

        private void pictureBoxSelection_Click(object sender, EventArgs e)
        {
            chooseImage();
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
                    pictureBoxItem.Image = img;
                    if (img.Size.Height < pictureBoxItem.Size.Height
                        && img.Size.Width < pictureBoxItem.Size.Width)
                        pictureBoxItem.SizeMode = PictureBoxSizeMode.CenterImage;
                    else
                        pictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }catch(Exception e) { MessageBox.Show("Error :" + e); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            string name = valName.Text;
            string price = valPrice.Text;
            string quantity = valQuantity.Text;
            string description = valDescription.Text;
            string reference = "";
            string option = add ? Helper.ADD : Helper.SET;

            if (!Helper.fieldsAreEmpty(true, name, price, quantity)
                && Helper.AreNumbers(true, price, quantity)
                && Helper.confirmation(option))
            {
                float nPrice;
                int nQuantity;
                float.TryParse(price, out nPrice);
                int.TryParse(quantity, out nQuantity);
                if (add)
<<<<<<< HEAD
                    database.addItem(name, description, true, nPrice, img, reference, nQuantity);
=======
                    database.AddItem(name, description, true, nPrice, img, reference, nQuantity);
>>>>>>> origin/Dev
                else
                    database.UpdateItem(pan.valItemName.Text, description, true, nPrice, img, reference, nQuantity);
                //Helper.addSuccess();
                pan.setTableItem();

                this.Close();
            }
        }
    }
}
