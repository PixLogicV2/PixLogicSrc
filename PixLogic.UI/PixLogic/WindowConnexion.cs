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
    public partial class WindowConnexion : Form
    {
        private Database database;
        private bool closing;
        public WindowConnexion()
        {
            InitializeComponent();
            database = Helper.database;
            closing = false;
        }

        private void valPseudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                check();
            }
        }

        private void valMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                check();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            closing = true;
            Application.Exit();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            string pseudo = valPseudo.Text;
            string mdp = valMdp.Text;
            if (database.ContainPseudoManager(pseudo))
            {
                foreach (Manager m in database.GetAllManagers())
                {
                    if (m.pseudo.Equals(pseudo) && m.mdp.Equals(valMdp.Text))
                    {
                        Helper.manager = m;
                        this.Dispose();
                        return;
                    }
                }
            }
            MessageBox.Show("Pseudonyme ou mot de passe erroné.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void WindowConnexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closing)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
