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
        public WindowItem()
        {
            InitializeComponent();
            this.Text = "Nouveau matériel";
        }
        public WindowItem(string image, string name, double price, int quantity, string descrip)
        {
            InitializeComponent();
            this.Text = "Modifier matériel";
            valName.Text = name;
            valPrice.Text = Convert.ToString(price);
            valQuantity.Text = Convert.ToString(quantity);
            valDescription.Text = descrip;
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
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 1;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(f.FileName);
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
    }
}
