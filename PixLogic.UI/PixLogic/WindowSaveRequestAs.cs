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
    public partial class WindowSaveRequestAs : Form
    {
        public string SelectedName { get; set; }

        public WindowSaveRequestAs()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            SelectedName = SelectedNamTextBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
