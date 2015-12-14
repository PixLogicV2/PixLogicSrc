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
        private bool quickAdd;
        private int idCategorie;
        private panItemPack panIP;

        public WindowCategorie()
        {
            InitializeComponent();
            add = true;
            quickAdd = true;
        }

        public WindowCategorie(WindowSettings w, panItemPack pan)
        {
            InitializeComponent();
            settings = w;
            panIP = pan;
            add = true;
            quickAdd = false;
        }
        public WindowCategorie(WindowSettings w, panItemPack pan, int idCategorie)
        {
            InitializeComponent();
            settings = w;
            add = false;
            quickAdd = false;
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
            if(!Helper.fieldsAreEmpty(true, valLibelle.Text)
                && Helper.AreNumbers(true, valLevel.Text)
                && Helper.confirmation(op))
            {
                if (add && !Helper.categorieExist(true, valLibelle.Text))
                    database.AddCategorie(valLibelle.Text, (int)double.Parse(valLevel.Text), valDescription.Text);
                else if(!add && !Helper.categorieExistModif(true, valLibelle.Text, settings.valLibelleCat.Text))
                    database.UpdateCategorie(idCategorie, valLibelle.Text, (int)double.Parse(valLevel.Text), valDescription.Text);

                if (!quickAdd)
                {
                    settings.setTableCategories(database.GetAllCategorie());
                    panIP.setTableItem(database.GetAllItems());
                    panIP.setComboBoxCategorie();
                }
                else
                {
                }
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
