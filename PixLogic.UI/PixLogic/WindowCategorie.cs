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

        public WindowCategorie(WindowSettings w)
        {
            InitializeComponent();
            settings = w;
            add = true;
        }
        public WindowCategorie(WindowSettings w, int idCategorie)
        {
            InitializeComponent();
            settings = w;
            add = false;
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
                if(add)
                    database.AddCategorie(valLibelle.Text, (int)double.Parse(valLevel.Text));
                else
                    //database.UpdateCategorie()
                settings.setTableCategories(database.GetAllCategorie());
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
