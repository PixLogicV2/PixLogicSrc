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
        private Database database = Helper.database;
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

        public WindowPack(string name,  string description, panItemPack p, WindowPackManager w)
        {
            InitializeComponent();
            this.Text = "Modification Pack";
            valName.Text = name;
            valDescription.Text = description;
            panItemPack = p;
            winpackm = w;
            add = false;
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            string option = add ? Helper.ADD : Helper.SET;

            if (!Helper.fieldsAreEmpty(true, valName.Text)
                && Helper.confirmation(option))
            {
                if (add)
                    database.AddPack(valName.Text, valDescription.Text, true, 0,false);
                else
                    database.UpdatePack(winpackm.valNamePack.Text, valName.Text, valDescription.Text, true);

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
