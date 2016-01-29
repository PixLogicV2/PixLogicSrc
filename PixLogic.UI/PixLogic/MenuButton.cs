using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixLogic
{
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
            addEventItemButton();
        }

        private void addEventItemButton()
        {
            this.MouseClick += ClickItemButton;
            labelName.MouseClick += ClickItemButton2;
            ActiveEffectButton();
        }

        public string NameButton
        {
            get { return this.Name; }
        }
        private void ClickItemButton(object sender, EventArgs e)
        {
            Console.WriteLine("Boutonnnnnnnnnnn");
            this.BackgroundImage = Properties.Resources.Bouton2;
        }
        private void ClickItemButton2(object sender, EventArgs e)
        {
            Console.WriteLine("Labellllllllllllll");
            ((Control)sender).Parent.BackgroundImage = Properties.Resources.Bouton2;
        }
        private void HoverItemButton(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Bouton2;
        }
        private void LeaveItemButton(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Bouton;
        }

        public void ActiveEffectButton()
        {
            this.MouseEnter += HoverItemButton;
            labelName.MouseEnter += HoverItemButton;
            this.MouseLeave += LeaveItemButton;
            labelName.MouseLeave += LeaveItemButton;
            this.BackgroundImage = Properties.Resources.Bouton;
        }
        public void DesactiveEffectButton()
        {
            this.MouseEnter -= HoverItemButton;
            labelName.MouseEnter -= HoverItemButton;
            this.MouseLeave -= LeaveItemButton;
            labelName.MouseLeave -= LeaveItemButton;
            this.BackgroundImage = Properties.Resources.Bouton2;
        }


        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public  Image Image
        {
            get { return labelName.Image; }
            set { labelName.Image = value; }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public ContentAlignment ImageAlign
        {
            get { return labelName.ImageAlign; }
            set { labelName.ImageAlign = value; }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public ContentAlignment TextAlign
        {
            get { return labelName.TextAlign; }
            set { labelName.TextAlign = value; }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public bool UseCompatibleTextRendering
        {
            get { return labelName.UseCompatibleTextRendering; }
            set { labelName.UseCompatibleTextRendering = value; }
        }

    }
}
