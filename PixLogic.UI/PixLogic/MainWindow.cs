using System;
using System.Windows.Forms;
using PixLogic.DAL;
namespace PixLogic
{

    public partial class MainWindow : Form
    {
        private MenuButton button = null;
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
            panScript1.Visible = false;
            panLog1.Visible = false;
            button = boutonUtilisateur;
            button.DesactiveEffectButton();
        }

        private void addEventsOnButtonItem()
        {
            foreach (Control ctrl in panMenu.Controls)
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
            switch (buttonName)
            {
                case "boutonUtilisateur": namePan = "panUsers1"; break;
                case "boutonMateriel": namePan = "panItemPack1"; break;
                case "boutonReservation": namePan = "panReservation1";panReservation1.setTableReservations(database.GetAllReservations()); break;
                case "boutonEmprunt": namePan = "panEmprunt1"; panEmprunt1.setTableEmprunts(database.GetAllEmprunts()); break;
                case "boutonHistorique": namePan = "panLog1"; break;
                case "boutonScript": namePan = "panScript1"; break;
            }
            Console.WriteLine("Nom Bouton : " + buttonName.ToUpper());
            Console.WriteLine("Nom Select : " + namePan.ToUpper());
            foreach (Control c in panelAllPan.Controls)
            {
                if (c.Name.Equals(namePan))
                    c.Visible = true;
                else
                    c.Visible = false;
                Console.WriteLine("Nom panneau : " + c.Name);
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
                selectPan(button.NameButton);
            }

            button.DesactiveEffectButton();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSettings settings = new WindowSettings(panItemPack1);
            settings.ShowDialog();
        }
    }
}