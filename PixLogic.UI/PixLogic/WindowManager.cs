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
        public WindowManager()
        {
            InitializeComponent();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            if(!Helper.fieldsAreEmpty(true, valNom.Text, valPseudo.Text, valMdp.Text, valMdpConfirm.Text))
            {

            }
        }
    }
}
