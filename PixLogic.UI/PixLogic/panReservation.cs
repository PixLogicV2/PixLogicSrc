using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixLogic.DAL;
using System.Globalization;

namespace PixLogic
{
    public partial class panReservation : UserControl
    {
        Database database;
        private readonly string PACK = "Pack";
        private readonly string ITEM = "Matériel";

        public panReservation()
        {
            InitializeComponent();
            if (MainWindow.START)
            {
                database = Helper.database;
                setTableReservations(database.GetAllReservations());
            }
        }
        public void setTableReservations(List<Reservation> l)
        {
            List<Reservation> list = l;
            dataGridReservations.Rows.Clear();
            foreach (Reservation reser in list)
            {
                dataGridReservations.Rows.Add(reser.ReservationId, reser.user.name, reser.reservable.name,
                    reser.beginDateReservation, reser.endDateReservation);
            }

            if (dataGridReservations.RowCount > 0)
            {
                dataGridReservations.FirstDisplayedScrollingRowIndex = 0;
                dataGridReservations.Refresh();
                dataGridReservations.CurrentCell = dataGridReservations.Rows[0].Cells[0];
                dataGridReservations.Rows[0].Selected = true;
            }

            setNewsReservations();
            //checkEnableButton();
        }
        
        private void setNewsReservations()
        {
            if (dataGridReservations.RowCount > 0)
            {
                Reservation reservation = database.GetReservationById(Convert.ToInt32(dataGridReservations.CurrentRow.Cells[0].Value));
                valDateFin.Text = ((DateTime)reservation.beginDateReservation).ToString("D");
                valDateDebut.Text = ((DateTime)reservation.endDateReservation).ToString("D");
                valNomUser.Text = reservation.user.name;
                valNomReservable.Text = reservation.reservable.name;
                valType.Text = reservation.isPack ? PACK : ITEM;
            }
            else
            {
                valDateFin.Text = "-";
                valDateDebut.Text = "-";
                valNomUser.Text = "-";
                valNomReservable.Text = "-";
                valType.Text = "-";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*
            emprunt
            */
        }

        private void dataGridReservations_Click(object sender, EventArgs e)
        {
            if (dataGridReservations.RowCount > 0)
                setNewsReservations();
        }

        private void dataGridReservations_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridReservations.RowCount > 0)
                setNewsReservations();
        }

        private void buttonFiltrer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Date debut: {0}\nDate fin: {1}", dateTimeBegin.Text, dateTimeEnd.Text);
            List<Reservation> list = database.GetAllReservationsByDate(DateTime.Parse(dateTimeBegin.Text), DateTime.Parse(dateTimeEnd.Text));
            setTableReservations(list);
        }
    }
}
