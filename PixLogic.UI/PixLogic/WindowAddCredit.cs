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
    public partial class WindowAddCredit : Form
    {
        private User user;
        private Database database = Helper.database;

        public WindowAddCredit(int id)
        {
            InitializeComponent();
            user = database.GetUserById(id);
            valNomPrenom.Text = user.name + " " + user.nickname;
            valCredit.Text = Convert.ToString(user.credits);

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {

        }
    }
}
