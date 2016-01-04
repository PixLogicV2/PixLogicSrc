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
    public partial class Password : Form
    {
        private int idManager;
        private Database database;
        private WindowSettings settings;
        public Password(int idM, WindowSettings s)
        {
            InitializeComponent();
            idManager = idM;
            settings = s;
            database = Helper.database;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                check();
            }
        }

        private void check()
        {
            Manager m = database.GetManagerById(idManager);
            if (valPassword.Text.Equals(m.mdp))
            {
                this.Close();
                WindowManager window = new WindowManager(settings, idManager);
                window.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Mot de passe erroné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valPassword.Text = string.Empty;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            check();
        }
    }
}
