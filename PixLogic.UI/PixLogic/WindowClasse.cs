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
            valLibelle.Text = c.name;
            valCredit.Text = c.credits.ToString();
        }
        private void buttonValid_Click(object sender, EventArgs e)
        {
            string op = add ? Helper.ADD : Helper.SET;
            if (!Helper.fieldsAreEmpty(true, valLibelle.Text)
                && Helper.AreNumbers(true, valCredit.Text)
                && !Helper.userClassExist(true, valLibelle.Text)
                && Helper.confirmation(op))
            {
                if (add)
                    database.AddUserClass(valLibelle.Text, (int)double.Parse(valCredit.Text));
                else
                    database.UpdateUserClass(idClasse, valLibelle.Text, (int)double.Parse(valCredit.Text));

                if (!quickAdd)
                {
                    settings.setTableUserClass(database.GetAllUserClass());
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
