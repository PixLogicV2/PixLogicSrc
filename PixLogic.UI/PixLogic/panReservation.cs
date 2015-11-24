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

namespace PixLogic
{
    public partial class panReservation : UserControl
    {
        Database database;
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
            foreach (Reservation reser in list)
            {
                dataGridReservations.Rows.Add(reser.ReservationId, reser.user.name, reser.reservable.name);
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
                valDateFin.Text =Convert.ToString( reservation.beginDateReservation);
                valDateDebut.Text = Convert.ToString(reservation.endDateReservation);
                
            }
            else
            {
                valDateFin.Text = "-";
                valDateDebut.Text = "-";
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*
            emprunt
            */
        }
    }
}
