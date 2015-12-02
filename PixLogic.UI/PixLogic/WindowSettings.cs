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
    public partial class WindowSettings : Form
    {
        public WindowSettings()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WindowCategorie categorie = new WindowCategorie(dataGridCategorie);
            categorie.Show(this);
        }
    }
}
