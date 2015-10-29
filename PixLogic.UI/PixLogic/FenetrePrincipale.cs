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
    public partial class FenetrePrincipale : Form
    {
        private BoutonMenu bouton = null;

        public FenetrePrincipale()
        {
            InitializeComponent();
            addEventsOnButtonItem();
        }

        private void addEventsOnButtonItem()
        {
           foreach(Control ctrl in panMenu.Controls)
            {
                ctrl.MouseClick += ClickItemButton;
                foreach(Control c in ctrl.Controls)
                {
                    c.MouseClick += ClickItemButton;
                }
            }
        }

        private void ClickItemButton(object sender, EventArgs e)
        {
            if (bouton != null)
                bouton.ActiveEffectButton();

            if (sender.GetType() != typeof(System.Windows.Forms.Label))
                bouton = ((BoutonMenu)sender);
            else
                bouton = (BoutonMenu)((Control)sender).Parent;

            bouton.DesactiveEffectButton();

        }

    }
}
