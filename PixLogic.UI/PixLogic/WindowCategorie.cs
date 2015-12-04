using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixLogic.DAL;

namespace PixLogic
{
    public partial class WindowCategorie : Form
    {
        Database database = Helper.database;
        private WindowSettings settings;
        private bool add;
        private int idCategorie;
        private panItemPack panIP;

        public WindowCategorie(WindowSettings w, panItemPack pan)
        {
            InitializeComponent();
            settings = w;
            panIP = pan;
            add = true;
        }
        public WindowCategorie(WindowSettings w, panItemPack pan, int idCategorie)
        {
            InitializeComponent();
            settings = w;
            add = false;
            panIP = pan;
            this.idCategorie = idCategorie;

            Categorie c = database.GetCategorieById(idCategorie);

            valLibelle.Text = c.name;
            valLevel.Text = c.level.ToString();
            valDescription.Text = c.description;
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            string op = add ? Helper.ADD : Helper.SET;

            if(!Helper.fieldsAreEmpty(false, valLibelle.Text)
                && Helper.AreNumbers(true, valLevel.Text)
                && Helper.categorieExist(true, valLibelle.Text)
                && Helper.confirmation(op))
            {
                if (add)
                    database.AddCategorie(valLibelle.Text, (int)double.Parse(valLevel.Text), valDescription.Text);
                else
                    database.UpdateCategorie(idCategorie, valLibelle.Text, (int)double.Parse(valLevel.Text), valDescription.Text);

                settings.setTableCategories(database.GetAllCategorie());
                panIP.setTableItem(database.GetAllItems());
                panIP.setComboBoxCategorie();
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
