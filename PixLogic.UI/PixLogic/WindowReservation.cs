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
        private panItemPack panItem;
        private bool isPack;
        private WindowPackManager panPack;

        public WindowReservation(panItemPack p)
        {
            InitializeComponent();
            this.Text = "Nouvelle reservation";
            panItem = p;
        }
        public WindowReservation(panItemPack pa, int itemId,bool Pack)
        {
            InitializeComponent();
            Text = "Nouvelle reservation";
            panItem = pa;
            valItemId.Text = itemId.ToString();
            isPack = Pack;
            setTableUsers(database.GetAllUsers());
        }
        public WindowReservation(WindowPackManager pa, int packId, bool Pack)
        {
            InitializeComponent();
            Text = "Nouvelle reservation";
            panPack = pa;
            valItemId.Text = packId.ToString();
            isPack = Pack;
            setTableUsers(database.GetAllUsers());
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setTableUsers(List<User> l)
        {
            List<User> list = l;
            dataGridUsersReservation.Rows.Clear();
            foreach (var user in list)
            {
                dataGridUsersReservation.Rows.Add(user.UserId,user.name, user.nickname);
            }

            if (dataGridUsersReservation.RowCount > 0)
            {
                dataGridUsersReservation.FirstDisplayedScrollingRowIndex = 0;
                dataGridUsersReservation.Refresh();
                dataGridUsersReservation.CurrentCell = dataGridUsersReservation.Rows[0].Cells[0];
                dataGridUsersReservation.Rows[0].Selected = true;
            }
            
        }
        private void buttonValid_Click(object sender, EventArgs e)
        {
            DateTime? begin =Convert.ToDateTime(valBegin.Text);
            DateTime? end = Convert.ToDateTime(valEnd.Text);
            DateTime? debutEmprunt = null;
            DateTime? endEmprunt= null;
            Manager manag = null;
            Reservable elem;
            if (isPack == false)
            {
                elem = database.GetItemById(int.Parse(valItemId.Text.ToString()));
            }
            else
            {
                elem = database.GetPackById(int.Parse(valItemId.Text.ToString()));
            }
            if (!Helper.fieldsAreEmpty(true, valItemId.Text,valBegin.Text,valEnd.Text))
            {
                User user = database.GetUserById(int.Parse(dataGridUsersReservation.CurrentRow.Cells[0].Value.ToString()));

                database.AddReservation(isPack, begin, end, debutEmprunt, endEmprunt, user, elem,manag);

                //Helper.addSuccess();
                //setTableUsers(database.GetAllUsers());
                this.Close();
            }
        }   
    }
}
