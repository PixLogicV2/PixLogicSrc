using System;
using System.Windows.Forms;

namespace PixLogic
{
    public partial class MainWindow : Form
    {
        private MenuButton button = null;
        private string textUtilisateur = "         UTILISATEUR";
        private string textMateriel = "         MATERIEL";
        private string textReservation = "         RESERVATION";
        private string textScript = "         SCRIPT";
        public static bool START = false;
        public MainWindow()
        {
            InitializeComponent();
            addEventsOnButtonItem();
            setPanUserVisible();
        }

        private void setPanUserVisible()
        {
            panItemPack1.Visible = false;
            panUsers1.Visible = true;
            panReservation1.Visible = false;
            button = boutonUtilisateur;
            button.DesactiveEffectButton();
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
            MenuButton buttonHelper = button;

            if (sender.GetType() != typeof(System.Windows.Forms.Label))
                button = ((MenuButton)sender);
            else
                button = (MenuButton)((Control)sender).Parent;

            if (buttonHelper != null && buttonHelper != button)
            {
                buttonHelper.ActiveEffectButton();
                if (button.Text.ToString().Equals(textMateriel))
                {
                    panScript1.Visible = false;
                    panUsers1.Visible = false;
                    panItemPack1.Visible = true;
                    panReservation1.Visible = false;
                }
                else if (button.Text.ToString().Equals(textUtilisateur))
                {
                    panScript1.Visible = false;
                    panItemPack1.Visible = false;
                    panUsers1.Visible = true;
                    panReservation1.Visible = false;
                }
                else if (button.Text.ToString().Equals(textReservation))
                {
                    panScript1.Visible = false;
                    panItemPack1.Visible = false;
                    panUsers1.Visible = false;
                    panReservation1.Visible = true;
                }
                else if (button.Text.ToString().Equals(textScript))
                {
                    panScript1.Visible = true;
                    panItemPack1.Visible = false;
                    panUsers1.Visible = false;
                    panReservation1.Visible = false;
                }
            }

            button.DesactiveEffectButton();
        }

    }
}
