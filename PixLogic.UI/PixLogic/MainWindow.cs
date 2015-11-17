using System;
using System.Windows.Forms;

namespace PixLogic
{
    public partial class MainWindow : Form
    {
        private MenuButton button = null;
        public static bool START = false;
        public MainWindow()
        {
            InitializeComponent();
            addEventsOnButtonItem();
            panItemPack1.Visible = false;
            panUsers1.Visible = false ;
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
                buttonHelper.ActiveEffectButton();

            button.DesactiveEffectButton();
        }

        private void boutonUtilisateur_Load(object sender, EventArgs e)
        {
            panItemPack1.Visible=false;
            panUsers1.Visible=true;
        }

        private void boutonMenu1_Load(object sender, EventArgs e)
        {
            panItemPack1.Visible =true;
            panUsers1.Visible = false;
        }
    }
}
