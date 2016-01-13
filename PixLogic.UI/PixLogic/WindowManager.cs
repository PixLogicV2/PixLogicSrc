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
using System.Security.Cryptography;

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
            Manager m = database.GetManagerById(idManager);
            valNom.Text = m.name;
            valPrenom.Text = m.nickname;
            valTel.Text = m.phone;
            valPseudo.Text = m.pseudo;
            valMdp.Text = m.mdp;
            valMdpConfirm.Text = m.mdp;
            this.Text = "Modification Manager";
        }


        private void buttonValid_Click(object sender, EventArgs e)
        {
            if (!Helper.fieldsAreEmpty(true, valNom.Text, valPseudo.Text, valMdp.Text, valMdpConfirm.Text))
            {
                if(valMdp.Text.Equals(valMdpConfirm.Text))
                {
                    string op = add ? Helper.ADD : Helper.SET;
                    if(Helper.confirmationManager(op))
                    {
                        if (add && !Helper.ManagerExist(true, valPseudo.Text))
                        {
                            database.AddManager(valNom.Text, valMdp.Text, valPrenom.Text, valTel.Text, valPseudo.Text);
                            settings.setTableManagers(database.GetAllManagers());
                            this.Close();
                        }
                        else if (!add && !Helper.ManagerExistModif(true, idManager, valPseudo.Text))
                        {
                            database.UpdateManager(idManager, valNom.Text, valMdp.Text, valTel.Text, valPseudo.Text, valPrenom.Text);
                            settings.setTableManagers(database.GetAllManagers());
                            this.Close();
                        }
                    }
                   
                }
                else
                {
                    MessageBox.Show("Les deux mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
