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
        private Database database = Helper.database;
        private panItemPack pan;
        private Image img = null;
        private bool add;
        private string cat = "";

        public WindowItem(panItemPack p)
        {
            InitializeComponent();
            this.Text = "Nouveau matériel";
            pan = p;
            img = Properties.Resources.noitem;
            Helper.putImageInBox(pictureBoxItem, img);
            add = true;
            setComboBoxCategorie(cat);
        }
        public WindowItem(panItemPack pa, Item i)
        {
            InitializeComponent();
            this.Text = "Modifier matériel";
            pan = pa;
            img = database.ByteArrayToImage(i.image);
            Helper.putImageInBox(pictureBoxItem, img);
            valName.Text = i.name;
            valPrice.Text = Convert.ToString(i.price);
            valDescription.Text = i.description;
            valQuantity.Text = Convert.ToString(i.quantity);
            valReference.Text = i.reference;
            add = false;
            this.cat = i.categorie.name;
            setComboBoxCategorie(cat);
        }

        private void setComboBoxCategorie(string cat = "")
        {
            comboBoxCategorie.Items.Clear();
            List<Categorie> list= database.GetAllCategorie();

            comboBoxCategorie.Items.Add("");
            foreach (var pack in list)
            {
                comboBoxCategorie.Items.Add(pack.name);
            }
            if (comboBoxCategorie.Items.Count > 0)
            {
                if (add)
                    comboBoxCategorie.SelectedIndex = 0;
                else
                {
                    int index = 0;
                    foreach(var i in comboBoxCategorie.Items)
                    {
                        if (i.Equals(cat))
                            break;
                        index++;
                    }
                    comboBoxCategorie.SelectedIndex = index;
                }
            }
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
                    Helper.putImageInBox(pictureBoxItem, img);
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
            string reference = valReference.Text;
            string nameCategorie = comboBoxCategorie.SelectedItem.ToString();
            string option = add ? Helper.ADD : Helper.SET;
            

            if (!Helper.fieldsAreEmpty(true, name, price, quantity, nameCategorie,reference)
                && Helper.AreNumbers(true, price, quantity)
                && Helper.confirmation(option))
            {
                Categorie categorie = database.GetCategorieByName(nameCategorie);
                int nPrice;
                int nQuantity;
                int.TryParse(price, out nPrice);
                int.TryParse(quantity, out nQuantity);
                if (add && !Helper.itemExist(true, name) && !Helper.referenceExist(true, reference))
                {
                    database.AddItem(name, description, true, nPrice, img, reference, nQuantity,categorie);
                    pan.setTableItem(database.GetAllItems());
                    this.Close();
                }
                else if(!add && !Helper.itemExistModif(true, name, pan.valItemName.Text)
                    && !Helper.referenceExistModif(true, reference, pan.valItemRef.Text))
                {
                    database.UpdateItem(pan.valItemName.Text, name, description, true, nPrice, img, reference, nQuantity,categorie);
                    pan.setTableItem(database.GetAllItems());
                    this.Close();
                }
                //Helper.addSuccess();
                
            }
        }

        private void buttonAddCategorie_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(buttonAddCategorie, "Ajouter une catégorie.");
        }

        private void buttonAddCategorie_Click(object sender, EventArgs e)
        {
            WindowCategorie addCat = new WindowCategorie();
            addCat.ShowDialog();
        }

        private void comboBoxCategorie_Click(object sender, EventArgs e)
        {
            setComboBoxCategorie();
        }

        private void pictureBoxSelection_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureBoxSelection, "Sélectionner une image.");
            pictureBoxSelection.Cursor = Cursors.Hand;
        }
    }
}
