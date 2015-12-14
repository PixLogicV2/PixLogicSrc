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
    public partial class WindowClasse : Form
    {
        Database database = Helper.database;
        private WindowSettings settings;
        private bool add;
        private bool quickAdd;
        private int idClasse;

        public WindowClasse()
        {
            InitializeComponent();
            add = true;
            quickAdd = true;
        }

        public WindowClasse(WindowSettings w)
        {
            InitializeComponent();
            settings = w;
            add = true;
            quickAdd = false;
        }
        public WindowClasse(WindowSettings w, int idClasse)
        {
            InitializeComponent();
            settings = w;
            add = false;
            quickAdd = false;
            this.idClasse = idClasse;

            UserClass c = database.GetUserClassById(idClasse);
            valLibelleClasse.Text = c.name;
            valCredit.Text = c.credits.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            string op = add ? Helper.ADD : Helper.SET;
            if (!Helper.fieldsAreEmpty(true, valLibelleClasse.Text)
                && Helper.AreNumbers(true, valCredit.Text)
                && Helper.confirmation(op))
            {
                if (add && !Helper.userClassExist(true, valLibelleClasse.Text))
                    database.AddUserClass(valLibelleClasse.Text, (int)double.Parse(valCredit.Text),(int)double.Parse(valLevel.Text));
                else if(!add && !Helper.userClassExistModif(true, valLibelleClasse.Text, settings.valLibelleClasse.Text))
                    database.UpdateUserClass(idClasse, valLibelleClasse.Text, (int)double.Parse(valCredit.Text), (int)double.Parse(valLevel.Text));

                if (!quickAdd)
                {
                    settings.setTableUserClass(database.GetAllUserClass());
                }
                else
                {
                    settings.setTableUserClass(database.GetAllUserClass());
                }
                this.Close();
            }
        }
    }
}
