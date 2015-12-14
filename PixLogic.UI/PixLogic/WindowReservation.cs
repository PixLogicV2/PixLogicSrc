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
        private int idElement;

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
            idElement = itemId;
            isPack = Pack;
            setInfos();
            setTableUsers(database.GetAllUsers());
        }
        public WindowReservation(WindowPackManager pa, int packId, bool Pack)
        {
            InitializeComponent();
            Text = "Nouvelle reservation";
            panPack = pa;
            idElement = packId;
            isPack = Pack;
            setInfos();
            setTableUsers(database.GetAllUsers());
        }

        private void setInfos()
        {
            Reservable r;
            if (isPack)
                r = database.GetPackById(idElement);
            else
            {
                r = database.GetItemById(idElement);
                Helper.putImageInBox(pictureBoxItem, database.ByteArrayToImage(((Item)r).image));
            }

            valIdReservable.Text = idElement.ToString();
            valNomReservable.Text = r.name;
            valType.Text = isPack ? Helper.PACK : Helper.ITEM;

            setTableDateReservation(database.GetAllReservationsByReservableId(idElement));
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
            checkEnableButton();
        }

        private void setTableDateReservation(List<Reservation> l)
        {
            List<Reservation> list = l;
            dataGridReservAvenir.Rows.Clear();
            foreach (Reservation reser in list)
            {
                dataGridReservAvenir.Rows.Add(reser.beginDateReservation.Value.ToString("d"), reser.endDateReservation.Value.ToString("d"));
            }

            if (dataGridReservAvenir.RowCount > 0)
            {
                dataGridReservAvenir.FirstDisplayedScrollingRowIndex = 0;
                dataGridReservAvenir.Refresh();
                dataGridReservAvenir.CurrentCell = dataGridReservAvenir.Rows[0].Cells[0];
                dataGridReservAvenir.Rows[0].Selected = true;
            }
        }

        private void checkEnableButton()
        {
            if (dataGridUsersReservation.RowCount > 0)
                buttonValid.Enabled = true;
            else
                buttonValid.Enabled = false;
        }
        private void buttonValid_Click(object sender, EventArgs e)
        {
            DateTime debut = DateTime.Parse(dateTimeBegin.Value.ToString());
            DateTime fin = DateTime.Parse(dateTimeEnd.Value.ToString());
            DateTime? debutEmprunt = null;
            DateTime? endEmprunt= null;
            Manager manag = null;
            Reservable elem;
            if (isPack == false)
            {
                elem = database.GetItemById(int.Parse(valIdReservable.Text.ToString()));
            }
            else
            {
                elem = database.GetPackById(int.Parse(valIdReservable.Text.ToString()));
            }
            User user = database.GetUserById(int.Parse(dataGridUsersReservation.CurrentRow.Cells[0].Value.ToString()));
            if (Helper.reservationStartMinimumToday(true, debut)
                && Helper.beginBeforeEndDate(true, debut, fin)
                && Helper.getDispoReservableByDate(true, idElement, debut, fin)
                && Helper.confirmationReservation(Helper.ADD))
            {
                if (database.CreditSuffisant(user, elem)
                && database.LevelSuffisant(user, elem.price))
                database.AddReservation(isPack, debut, fin, debutEmprunt, endEmprunt, user, elem,manag);
                else MessageBox.Show("credits ou niveau d'accès insuffisant", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);


                this.Close();
            }
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableUsers(database.GetAllUsersByString(textBoxSearch.Text));
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            setTableUsers(database.GetAllUsers());
        }
    }
}
