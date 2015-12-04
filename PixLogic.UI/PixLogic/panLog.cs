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
    public partial class panLog : UserControl
    {
        Database database;
        public panLog()
        {
            InitializeComponent();
            if (MainWindow.START)
            {
                database = Helper.database;
                start();
            }
        }
        private void start()
        {
            //setRadioButton();
            setTableLogs(database.GetAllLogs());
        }
        public void setTableLogs(List<Reservation> l)
        {
            List<Reservation> list = l;
            dataGridLogs.Rows.Clear();
            foreach (Reservation reser in list)
            {
                dataGridLogs.Rows.Add(reser.ReservationId, reser.user.name, reser.reservable.name,
                    reser.beginDateEmprunt.Value.ToString("d"), reser.endDateEmprunt.Value.ToString("d"));

                if (reser.endDateEmprunt.Value.Date < DateTime.Today.Date)
                    dataGridLogs.Rows[dataGridLogs.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                else
                    dataGridLogs.Rows[dataGridLogs.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
            }

            if (dataGridLogs.RowCount > 0)
            {
                dataGridLogs.FirstDisplayedScrollingRowIndex = 0;
                dataGridLogs.Refresh();
                dataGridLogs.CurrentCell = dataGridLogs.Rows[0].Cells[0];
                dataGridLogs.Rows[0].Selected = true;
            }

            setNewsLogs();
            checkEnableButton();
        }
        private void setNewsLogs()
        {
            if (dataGridLogs.RowCount > 0)
            {
                Reservation reservation = database.GetReservationById(Convert.ToInt32(dataGridLogs.CurrentRow.Cells[0].Value));
                valDateFin.Text = ((DateTime)reservation.endDateEmprunt).ToString("D");
                valDateDebut.Text = ((DateTime)reservation.beginDateEmprunt).ToString("D");
                valNomUser.Text = reservation.user.name;
                valNomReservable.Text = reservation.reservable.name;
                valType.Text = reservation.isPack ? Helper.PACK : Helper.ITEM;
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
        private void checkEnableButton()
        {
            if (dataGridLogs.RowCount > 0)
            {
                int idReservation = int.Parse(dataGridLogs.CurrentRow.Cells[0].Value.ToString());
                Reservation reservation = database.GetReservationById(idReservation);

                /*if(reservation.dateRendu.Value.ToString().Equals(""))
                    buttonRendre.Enabled = true;
                else
                    buttonRendre.Enabled = false;*/
            }
        }
    }
}
