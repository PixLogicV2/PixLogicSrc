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
    public partial class WindowSetReservation : Form
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
            valDateFin.Text = ((DateTime)reserv.beginDateReservation).ToString("D");
            valDateDebut.Text = ((DateTime)reserv.endDateReservation).ToString("D");
            if(!reserv.isPack)
            {
                Helper.putImageInBox(pictureBoxItem, database.ByteArrayToImage(((Item)reserv.reservable).image));
            }
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
