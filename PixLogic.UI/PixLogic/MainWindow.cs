using System;
using System.Windows.Forms;
using PixLogic.DAL;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace PixLogic
{

    public partial class MainWindow : Form
    {
        private MenuButton button = null;
        public static bool START = false;
        private Database database;

        public MainWindow()
        {
            InitializeComponent();
            if(START)
            {
                database = Helper.database;
                addEventsOnButtonItem();
                setPanUserVisible();
                WindowConnexion con = new WindowConnexion();
                con.ShowDialog();
            }
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
                case "boutonHistorique": namePan = "panLog1"; panLog1.setTableLogs(database.GetAllLogs()); break;
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

        private void toolButtonExport_Click(object sender, EventArgs e)
        {
            string title = "";
            DataGridView table = new DataGridView();
            switch (button.NameButton)
            {
                case "boutonUtilisateur":
                    title = "Liste des utilisateurs";
                    table = panUsers1.getTable();
                    break;
                case "boutonMateriel":
                    title = "Liste des matériels";
                    table = panItemPack1.getTable();
                    break;
                case "boutonReservation":
                    title = "Liste des réservations";
                    table = panReservation1.getTable();
                    break;
                case "boutonEmprunt":
                    title = "Liste des emprunts";
                    table = panEmprunt1.getTable();
                    break;
                case "boutonHistorique":
                    title = "Historique";
                    table = panLog1.getTable();
                    break;
                //case "boutonScript": namePan = "panScript1"; break;
            }
            
            WindowExport export = new WindowExport(table, title);
            export.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            switch (button.NameButton)
            {
                case "boutonUtilisateur":
                    List<Champs> list = new List<Champs>();
                    list.Add(new Champs { Nom = "Classe", Coche = true, Oblige = true });
                    list.Add(new Champs { Nom = "Nom", Coche = true, Oblige = true });
                    list.Add(new Champs { Nom = "Prénom", Coche = true, Oblige = true });
                    list.Add(new Champs { Nom = "E-mail", Coche = false, Oblige = false });
                    list.Add(new Champs { Nom = "Tel", Coche = false, Oblige = false });

                    WindowImport import = new WindowImport(panUsers1, list, true);
                    import.ShowDialog();
                    break;
                case "boutonMateriel":
                    break;
                default:
                    MessageBox.Show("Vous ne pouvez pas importer des informations dans ce panneau.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                    //case "boutonScript": namePan = "panScript1"; break;
            }
        }

        private void toolButtonRefresh_Click(object sender, EventArgs e)
        {
            switch (button.NameButton)
            {
                case "boutonUtilisateur":
                    panUsers1.refresh();
                    break;
                case "boutonMateriel":
                    panItemPack1.refresh();
                    break;
                case "boutonReservation":
                    panReservation1.refresh();
                    break;
                case "boutonEmprunt":
                    panEmprunt1.refresh();
                    break;
                case "boutonHistorique":
                    panLog1.refresh();
                    break;
                    //case "boutonScript": namePan = "panScript1"; break;
            }
        }

        private void toolButtonDeconnexion_Click(object sender, EventArgs e)
        {
            Helper.manager = null;
            WindowConnexion con = new WindowConnexion();
            con.ShowDialog();
        }
    }
}