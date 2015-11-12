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

        public WindowPack(panItemPack p, WindowPackManager w)
        {
            InitializeComponent();
            this.Text = "Nouveau Pack";
            panItemPack = p;
            winpackm = w;
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            if(!Helper.fieldsAreEmpty(true, valName.Text, valPrice.Text)
                && Helper.AreNumbers(true, valPrice.Text))
            {
                float price;
                float.TryParse(valPrice.Text, out price);
                database.AddPack(valName.Text, valDescription.Text, true, price);
                winpackm.setTablePacks(database.GetAllPacks());
                panItemPack.setComboBoxPack();
                this.Close();
            }
        }
    }
}
