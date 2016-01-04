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
    public partial class WindowManager : Form
    {
        private Database database;
        private WindowSettings settings;
        private bool add;
        private int idManager;

        public WindowManager(WindowSettings s)
        {
            InitializeComponent();
            database = Helper.database;
            settings = s;
            add = true;
            this.Text = "Nouveau Manager";
        }
        public WindowManager(WindowSettings s, int idM)
        {
            InitializeComponent();
            database = Helper.database;
            settings = s;
            add = false;
            idManager = idM;
            this.Text = "Modification Manager";
        }


        private void buttonValid_Click(object sender, EventArgs e)
        {
            if (!Helper.fieldsAreEmpty(true, valNom.Text, valPseudo.Text, valMdp.Text, valMdpConfirm.Text))
            {
                if(add && !Helper.ManagerExist(true, valPseudo.Text))
                {
                    database.AddManager(valNom.Text, valMdp.Text, valPrenom.Text, valTel.Text, valPseudo.Text);
                    
                    this.Close();
                }
                else if(!add && !Helper.ManagerExistModif(true, idManager, valPseudo.Text))
                {
                    database.UpdateManager(idManager, valNom.Text, valMdp.Text, valTel.Text, valPseudo.Text, valPrenom.Text);
                    this.Close();
                }
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
