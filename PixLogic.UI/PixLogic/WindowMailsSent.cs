using PixLogic.DAL;
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
    public partial class WindowMailsSent : Form
    {
        private Database database = Helper.database;

        public WindowMailsSent()
        {
            InitializeComponent();
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //setTableUsers(database.GetAllUsersByString(textBoxSearch.Text));
        }
    }
}
