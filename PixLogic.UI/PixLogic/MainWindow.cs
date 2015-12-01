using PixLogic.DAL;
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
        private string textEmprunt = "         EMPRUNT";

        public static bool START = false;
        private Database database = Helper.database;
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
            panEmprunt1.Visible = false;
            button = boutonUtilisateur;
            button.DesactiveEffectButton();
        }

        private void addEventsOnButtonItem()
        {
           foreach(Control ctrl in panMenu.Controls)
            {
                if (!ctrl.Name.Equals("buttonMenu"))
                {
                    ctrl.MouseClick += ClickItemButton;
                    foreach (Control c in ctrl.Controls)
                    {
                        c.MouseClick += ClickItemButton;
                    }
                }
            }
        }

        private void selectPan(string buttonName)
        {
            string namePan = "";
            switch(buttonName)
            {
                case "boutonUtilisateur": namePan = "panUtilisateur1"; break;
                case "boutonMateriel": namePan = "panMateriel1"; break;
                case "boutonReservation": namePan = "panReservation1"; break;
                case "boutonEmprunt": namePan = "panEmprunt1"; break;
                case "boutonHistorique": namePan = "panHistorique1"; break;
                case "boutonScript": namePan = "panScript1"; break;
            }

            foreach (Control c in panelAllPan.Controls)
            {
                if (c.Name.Equals(namePan))
                    c.Visible = true;
                else
                    c.Visible = false;
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
                selectPan(button.Text);
                /*if(button.Text.ToString().Equals(textMateriel))
                {
                    panUsers1.Visible = false;
                    panItemPack1.Visible = true;
                   panReservation1.Visible = false;
                    panEmprunt1.Visible = false;
                }
                else if (button.Text.ToString().Equals(textUtilisateur))
                {
                    panItemPack1.Visible = false;
                    panUsers1.Visible = true;
                    panReservation1.Visible = false;
                    panEmprunt1.Visible = false;
                }
                else if (button.Text.ToString().Equals(textReservation))
                {
                    panItemPack1.Visible = false;
                    panUsers1.Visible = false;
                    panReservation1.Visible = true;
                    panEmprunt1.Visible = false;
                    panReservation1.setTableReservations(database.GetAllReservations());
                }
                else if (button.Text.ToString().Equals(textEmprunt))
                {
                    panItemPack1.Visible = false;
                    panUsers1.Visible = false;
                    panReservation1.Visible = false;
                    panEmprunt1.Visible = true;
                }*/
            }

            button.DesactiveEffectButton();
        }

    }
}
