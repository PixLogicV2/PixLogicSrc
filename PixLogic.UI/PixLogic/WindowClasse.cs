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
        private panItemPack panIP;

        public WindowClasse()
        {
            InitializeComponent();
            add = true;
            quickAdd = true;
        }

        public WindowClasse(WindowSettings w, panItemPack pan)
        {
            InitializeComponent();
            settings = w;
            panIP = pan;
            add = true;
            quickAdd = false;
        }
        public WindowClasse(WindowSettings w, panItemPack pan, int idClasse)
        {
            InitializeComponent();
            settings = w;
            add = false;
            quickAdd = false;
            panIP = pan;
            this.idClasse = idClasse;

            /*ClassUser c = database.GetCategorieById(idCategorie);

            valLibelle.Text = c.name;
            valLevel.Text = c.level.ToString();
            valDescription.Text = c.description;*/
        }
        private void buttonValid_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
