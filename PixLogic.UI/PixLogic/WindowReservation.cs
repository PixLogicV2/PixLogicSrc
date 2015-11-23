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
    public partial class WindowReservation : Form
    {
        private Database database = Helper.database;
        private panItemPack pan;
        private bool isPack;

        public WindowReservation(panItemPack p)
        {
            InitializeComponent();
            this.Text = "Nouvelle reservation";
            pan = p;
        }
        public WindowReservation(panItemPack pa, int itemId,bool Pack)
        {
            InitializeComponent();
            Text = "Modifier Utilisateur";
            pan = pa;
            valItemId.Text = itemId.ToString();
            isPack = Pack;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setTableUsers(List<User> l)
        {
            List<User> list = l;
            dataGridUsers.Rows.Clear();
            foreach (var user in list)
            {
                dataGridUsers.Rows.Add(user.name, user.nickname, user.UserId);
            }

            if (dataGridUsers.RowCount > 0)
            {
                dataGridUsers.FirstDisplayedScrollingRowIndex = 0;
                dataGridUsers.Refresh();
                dataGridUsers.CurrentCell = dataGridUsers.Rows[0].Cells[0];
                dataGridUsers.Rows[0].Selected = true;
            }
            
        }
        private void buttonValid_Click(object sender, EventArgs e)
        {
            int idElem = Convert.ToInt32(valItemId.Text);
            DateTime? begin =Convert.ToDateTime(valBegin.Text);
            DateTime? end = Convert.ToDateTime(valEnd.Text);
            DateTime? debutEmprunt = null;
            DateTime? endEmprunt= null;
            int idManag = 0;

            if (!Helper.fieldsAreEmpty(true, valItemId.Text,valBegin.Text,valEnd.Text))
            {
                User user = database.GetUserById(Convert.ToInt32(dataGridUsers.CurrentRow.Cells[0].Value));
                int idUser = user.UserId;

                database.AddReservation(isPack, begin, end, debutEmprunt, endEmprunt, idUser, idElem,idManag);
               
                //Helper.addSuccess();
                setTableUsers(database.GetAllUsers());
                this.Close();
            }
        }
    }
}
