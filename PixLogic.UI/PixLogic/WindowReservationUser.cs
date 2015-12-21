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
    public partial class WindowReservationUser : Form
    {
        public WindowReservationUser()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(buttonOk, "Valider.");
        }
    }
}
