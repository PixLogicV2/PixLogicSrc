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

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM/yyyy";

            monCalendar.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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

            setMonCalendar();
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
            SetMyCustomFormat();
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
            Manager manag = Helper.manager;
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



        private void buttonOk_Click(object sender, EventArgs e)
        {
            setMonCalendar();
        }

        private void setMonCalendar()
        {
            monCalendar.Rows.Clear();
            

            DateTime firstDayOfMonth = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, 1);
            int index = 0;
            if (firstDayOfMonth.DayOfWeek == DayOfWeek.Monday)
                index = 0;
            else if (firstDayOfMonth.DayOfWeek == DayOfWeek.Tuesday)
                index = 1;
            else if (firstDayOfMonth.DayOfWeek == DayOfWeek.Wednesday)
                index = 2;
            else if (firstDayOfMonth.DayOfWeek == DayOfWeek.Thursday)
                index = 3;
            else if (firstDayOfMonth.DayOfWeek == DayOfWeek.Friday)
                index = 4;
            else if (firstDayOfMonth.DayOfWeek == DayOfWeek.Saturday)
                index = 5;
            else if (firstDayOfMonth.DayOfWeek == DayOfWeek.Sunday)
                index = 6;

            int nbDays = DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month);
            int day = 1;
            int i = 0;
            while (day <= nbDays)
            {
                monCalendar.Rows.Add("", "", "", "", "", "", "");
                int iCell = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (day > nbDays)
                        return;
                    if (iCell >= index)
                    {
                        monCalendar.Rows[i].Cells[iCell].Value = day;
                        DateTime date = new DateTime(firstDayOfMonth.Year, firstDayOfMonth.Month, day);
                        if (date.Date == DateTime.Today.Date)
                            monCalendar.Rows[i].Cells[iCell].Style.Font = new Font(monCalendar.Font, FontStyle.Bold);

                        setUnavaibleDays(monCalendar,new DateTime(firstDayOfMonth.Year, firstDayOfMonth.Month, day), i, iCell);
                        day++;
                    }
                    else
                        monCalendar.Rows[i].Cells[iCell].Value = "";
                    iCell++;
                    
                }
                index = 0;
                i++;

            }
        }

        private void setUnavaibleDays(DataGridView calendar, DateTime day, int iRow, int iCell)
        {
            List<Reservation> reservations = database.GetAllReservationsByReservableId(idElement);
            List<Reservation> emprunts = database.GetAllEmpruntsByReservableId(idElement);

            foreach(Reservation r in reservations)
            {
                if(r.beginDateReservation.Value.Date <= day.Date
                    && r.endDateReservation.Value.Date >= day.Date)
                {
                    monCalendar.Rows[iRow].Cells[iCell].Style.BackColor = Color.Orange;
                }
            }
            foreach (Reservation r in emprunts)
            {
                if (r.beginDateEmprunt.Value.Date <= day.Date
                    && r.endDateEmprunt.Value.Date >= day.Date)
                {
                    monCalendar.Rows[iRow].Cells[iCell].Style.BackColor = Color.Red;
                }
            }
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(1);
            setMonCalendar();
        }

        private void pictureBoxNext_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureBoxNext, "Mois suivant.");
            pictureBoxNext.Cursor = Cursors.Hand;
        }

        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(-1);
            setMonCalendar();
        }

        private void pictureBoxPrevious_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureBoxPrevious, "Mois précédent.");
            pictureBoxPrevious.Cursor = Cursors.Hand;
        }
    }
}
