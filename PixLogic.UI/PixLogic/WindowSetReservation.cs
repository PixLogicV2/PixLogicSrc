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
    public partial class  WindowSetReservation : Form
    {
        private int idReservable;
        private int idReservation;
        panReservation pan;
        private Database database = Helper.database;

        public WindowSetReservation(int idR, int idr, panReservation p)
        {
            InitializeComponent();
            idReservable = idr;
            idReservation = idR;
            pan = p;
            setInfos();
            setTableDateReservation(database.GetAllReservationsByReservableId(idReservable));
        }

        private void setInfos()
        {
            Reservation reserv = database.GetReservationById(idReservation);

            valNomReservable.Text = reserv.reservable.name;
            valType.Text = reserv.isPack ? Helper.PACK : Helper.ITEM;
            valDateDebut.Text = ((DateTime)reserv.beginDateReservation).ToString("D");
            valDateFin.Text = ((DateTime)reserv.endDateReservation).ToString("D");
            
            if(!reserv.isPack)
            {
                Helper.putImageInBox(pictureBoxItem, database.ByteArrayToImage(((Item)reserv.reservable).image));
            }

            setMonCalendar();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM/yyyy";

            monCalendar.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void setTableDateReservation(List<Reservation> l)
        {
            List<Reservation> list = l;
            /*dataGridReservAvenir.Rows.Clear();
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
            }*/
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

                        setUnavaibleDays(monCalendar, new DateTime(firstDayOfMonth.Year, firstDayOfMonth.Month, day), i, iCell);
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
            List<Reservation> reservations = database.GetAllReservationsByReservableId(idReservable);
            List<Reservation> emprunts = database.GetAllEmpruntsByReservableId(idReservable);

            foreach (Reservation r in reservations)
            {
                if (r.beginDateReservation.Value.Date <= day.Date
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            DateTime debut = DateTime.Parse(dateTimeBegin.Value.ToString());
            DateTime fin = DateTime.Parse(dateTimeEnd.Value.ToString());

            if (Helper.reservationStartMinimumToday(true, debut)
                && Helper.beginBeforeEndDate(true, debut, fin)
                && Helper.getDispoReservableByDateForModif(true, idReservable, idReservation, debut, fin)
                && Helper.confirmationReservation(Helper.SET))
            {
                database.UpdateReservation(idReservation, debut, fin);
                pan.setTableReservations(database.GetAllReservations());
                this.Close();
            }
        }
    }
}
