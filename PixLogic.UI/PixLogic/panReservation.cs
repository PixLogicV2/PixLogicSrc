﻿using System;
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

        public panReservation()
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
            setRadioButton();
            setTableReservations(database.GetAllReservations());
        }
        public void setTableReservations(List<Reservation> l)
        {
            List<Reservation> list = l;
            dataGridReservations.Rows.Clear();
            foreach (Reservation reser in list)
            {
                dataGridReservations.Rows.Add(reser.ReservationId, reser.user.name, reser.reservable.name,
                    reser.beginDateReservation.Value.ToString("d"), reser.endDateReservation.Value.ToString("d"));
            }

            if (dataGridReservations.RowCount > 0)
            {
                dataGridReservations.FirstDisplayedScrollingRowIndex = 0;
                dataGridReservations.Refresh();
                dataGridReservations.CurrentCell = dataGridReservations.Rows[0].Cells[0];
                dataGridReservations.Rows[0].Selected = true;
            }

            setNewsReservations();
            checkEnableButton();
        }
        
        private void checkEnableButton()
        {
            if(dataGridReservations.RowCount > 0)
            {
                buttonEmprunt.Enabled = true;
                buttonModif.Enabled = true;
                buttonCancelReserv.Enabled = true;
            }
            else
            {
                buttonEmprunt.Enabled = false;
                buttonModif.Enabled = false;
                buttonCancelReserv.Enabled = false;
            }
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
            checkBoxItem.Checked = true;
            checkBoxPack.Checked = true;
            disableDateTime();
        }

        private void filtrer()
        {
            DateTime debut = new DateTime();
            DateTime fin = new DateTime();
            List<Reservation> list = new List<Reservation>();

            if (radioAll.Checked)
            {
                list = database.GetAllReservations();
            }

            else if (radioToday.Checked)
            {
                debut = DateTime.Today;
                fin = debut;
                list = database.GetAllReservationsByDate(debut, fin);
            }
            else if (radioOfPastSevenDays.Checked)
            {
                fin = DateTime.Today;
                debut = fin.AddDays(-7);
                list = database.GetAllReservationsByDate(debut, fin);
            }
            else if (radioBetween.Checked)
            {
                debut = DateTime.Parse(dateTimeBegin.Text);
                fin = DateTime.Parse(dateTimeEnd.Text);
                list = database.GetAllReservationsByDate(debut, fin);

            }


            

            if ((checkBoxItem.Checked && !checkBoxPack.Checked) || (checkBoxPack.Checked && !checkBoxItem.Checked))
            {
                if (checkBoxPack.Checked)
                    list = database.GetAllPackReservations(list);
                else
                    list = database.GetAllItemReservations(list);
                Console.WriteLine("DANS LE OUI ou PAS");
            }
            else if(!checkBoxPack.Checked && !checkBoxItem.Checked)
                list = new List<Reservation>();

            setTableReservations(list);
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString());
            Reservation reservation = database.GetReservationById(id);
            
            WindowSetReservation set = new WindowSetReservation(reservation.reservable.ReservableId);
            set.ShowDialog(this);
        }

        private void buttonCancelReserv_Click(object sender, EventArgs e)
        {

        }

        private void pictureReinit_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureReinit, "Réinitialiser le filtre.");
            pictureReinit.Cursor = Cursors.Hand;
        }

        private void pictureReinit_Click(object sender, EventArgs e)
        {
            start();
        }
    }
}
