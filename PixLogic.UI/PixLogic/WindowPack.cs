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
    public partial class WindowPack : Form
    {
        private Database database = new Database();
        private panItemPack panItemPack;
        private WindowPackManager winpackm;
        private bool add;

        public WindowPack(panItemPack p, WindowPackManager w)
        {
            InitializeComponent();
            this.Text = "Nouveau Pack";
            panItemPack = p;
            winpackm = w;
            add = true;
        }

        public WindowPack(string name, string price, string description, panItemPack p, WindowPackManager w)
        {
            InitializeComponent();
            this.Text = "Modification Pack";
            valName.Text = name;
            valPrice.Text = price;
            valDescription.Text = description;
            panItemPack = p;
            winpackm = w;
            add = false;
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            string option = add ? Helper.ADD : Helper.SET;

            if (!Helper.fieldsAreEmpty(true, valName.Text, valPrice.Text)
                && Helper.AreNumbers(true, valPrice.Text)
                && Helper.confirmation(option))
            {
                float price;
                float.TryParse(valPrice.Text, out price);
                if (add)
                    database.AddPack(valName.Text, valDescription.Text, true, price);
                else
                    database.UpdatePack(winpackm.valNamePack.Text, valName.Text, valDescription.Text, true, price);

                winpackm.setTablePacks(database.GetAllPacks());
                panItemPack.setComboBoxPack();
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
