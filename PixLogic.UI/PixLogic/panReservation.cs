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
                setRadioButton();
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

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filtrer();
        }

        private void addEventRadioButton()
        {
            foreach(Control c in panFiltres.Controls)
            {
                if(c.GetType().Equals(radioAll.GetType()))
                {
                    c.MouseClick += ClickRadioButton;
                }
            }
        }
        private void ClickRadioButton(object sender, EventArgs e)
        {
            if(((RadioButton)sender).Name.ToString().Equals("radioBetween"))
                enableDateTime();
            else
                disableDateTime();
        }

        private void disableDateTime()
        {
            dateTimeBegin.Enabled = false;
            dateTimeEnd.Enabled = false;
        }
        private void enableDateTime()
        {
            dateTimeBegin.Enabled = true;
            dateTimeEnd.Enabled = true;
        }

        private void setRadioButton()
        {
            addEventRadioButton();
            radioAll.Checked = true;
            disableDateTime();
        }

        private void filtrer()
        {
            DateTime debut = new DateTime();
            DateTime fin = new DateTime();
            List<Reservation> list = new List<Reservation>();

            if (radioToday.Checked)
            {
                debut = DateTime.Now;
                fin = debut;
            }
            else if (radioOfPastSevenDays.Checked)
            {
                debut = DateTime.Now;
                //fin
            }
            else if (radioBetween.Checked)
            {
                debut = DateTime.Parse(dateTimeBegin.Text);
                debut = DateTime.Parse(dateTimeBegin.Text);
            }
            else if (radioAll.Checked)
                list = database.GetAllReservations();


            if (checkBoxItem.Checked && checkBoxPack.Checked)
                list = database.GetAllReservationsByDate(debut, fin);

            else if (checkBoxItem.Checked || checkBoxPack.Checked)
            {
                if (checkBoxPack.Checked)
                    list = database.GetAllPackReservations(list);
                else
                    list = database.GetAllItemReservations(list);
            }
            else
                list = new List<Reservation>();

            setTableReservations(list);
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelReserv_Click(object sender, EventArgs e)
        {

        }
    }
}
