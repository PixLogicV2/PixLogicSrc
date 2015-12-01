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

namespace PixLogic
{
    public partial class panEmprunt : UserControl
    {
        Database database;

        public panEmprunt()
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
            setTableEmprunts(database.GetAllEmprunts());
        }
        public void setTableEmprunts(List<Reservation> l)
        {
            List<Reservation> list = l;
            dataGridEmprunts.Rows.Clear();
            foreach (Reservation reser in list)
            {
                dataGridEmprunts.Rows.Add(reser.ReservationId, reser.user.name, reser.reservable.name,
                    reser.beginDateEmprunt.Value.ToString("d"), reser.endDateEmprunt.Value.ToString("d"));

                if (reser.endDateEmprunt.Value.Date < DateTime.Today.Date)
                    dataGridEmprunts.Rows[dataGridEmprunts.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                else
                    dataGridEmprunts.Rows[dataGridEmprunts.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
            }

            if (dataGridEmprunts.RowCount > 0)
            {
                dataGridEmprunts.FirstDisplayedScrollingRowIndex = 0;
                dataGridEmprunts.Refresh();
                dataGridEmprunts.CurrentCell = dataGridEmprunts.Rows[0].Cells[0];
                dataGridEmprunts.Rows[0].Selected = true;
            }

            setNewsEmprunts();
            checkEnableButton();
        }

        private void checkEnableButton()
        {
            if (dataGridEmprunts.RowCount > 0)
            {
                buttonPret.Enabled = true;
                buttonModif.Enabled = true;
                buttonCancelReserv.Enabled = true;
            }
            else
            {
                buttonPret.Enabled = false;
                buttonModif.Enabled = false;
                buttonCancelReserv.Enabled = false;
            }
        }

        private void setNewsEmprunts()
        {
            if (dataGridEmprunts.RowCount > 0)
            {
                Reservation reservation = database.GetReservationById(Convert.ToInt32(dataGridEmprunts.CurrentRow.Cells[0].Value));
                valDateFin.Text = ((DateTime)reservation.endDateEmprunt).ToString("D");
                valDateDebut.Text = ((DateTime)reservation.beginDateEmprunt).ToString("D");
                valNomUser.Text = reservation.user.name;
                valNomReservable.Text = reservation.reservable.name;
                valType.Text = reservation.isPack ? Helper.PACK : Helper.ITEM;
                dataGridEmprunts.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                MessageBox.Show("kdsdf");
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
            int idReservation = int.Parse(dataGridEmprunts.CurrentRow.Cells[0].Value.ToString());
            if (Helper.confirmationEmprunt(idReservation))
            {
                database.EmpruntReservation(idReservation);
                setTableEmprunts(database.GetAllReservations());
            }

        }

        private void dataGridReservations_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridEmprunts.RowCount > 0)
                setNewsEmprunts();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            //filtrer();
        }

        private void addEventRadioButton()
        {
            foreach (Control c in panFiltres.Controls)
            {
                if (c.GetType().Equals(radioAll.GetType()))
                {
                    c.MouseClick += ClickRadioButton;
                }
            }
        }
        private void ClickRadioButton(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Name.ToString().Equals("radioBetween"))
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
                list = database.GetAllEmprunts();
            }

            else if (radioToday.Checked)
            {
                debut = DateTime.Today;
                fin = debut;
                list = database.GetAllEmpruntsByDate(debut, fin);
            }
            else if (radioOfPastSevenDays.Checked)
            {
                fin = DateTime.Today;
                debut = fin.AddDays(-7);
                list = database.GetAllEmpruntsByDate(debut, fin);
            }
            else if (radioBetween.Checked)
            {
                debut = DateTime.Parse(dateTimeBegin.Text);
                fin = DateTime.Parse(dateTimeEnd.Text);
                list = database.GetAllEmpruntsByDate(debut, fin);

            }




            if ((checkBoxItem.Checked && !checkBoxPack.Checked) || (checkBoxPack.Checked && !checkBoxItem.Checked))
            {
                if (checkBoxPack.Checked)
                    list = database.GetAllPacksEmprunts(list);
                else
                    list = database.GetAllItemsEmprunts(list);
                Console.WriteLine("DANS LE OUI ou PAS");
            }
            else if (!checkBoxPack.Checked && !checkBoxItem.Checked)
                list = new List<Reservation>();

            setTableEmprunts(list);
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            int idReservation = int.Parse(dataGridEmprunts.CurrentRow.Cells[0].Value.ToString());
            Reservation reservation = database.GetReservationById(idReservation);
            int idReservable = reservation.reservable.ReservableId;
            
        }

        private void buttonCancelReserv_Click(object sender, EventArgs e)
        {
            if (Helper.confirmationReservation(Helper.CANCEL))
            {
                database.DeleteReservation(int.Parse(dataGridEmprunts.CurrentRow.Cells[0].Value.ToString()));
                setTableEmprunts(database.GetAllReservations());
            }
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

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            setTableEmprunts(database.GetAllReservations());
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableEmprunts(database.GetAllEmpruntsByString(textBoxSearch.Text));
        }

        private void dataGridEmprunts_Click(object sender, EventArgs e)
        {
            if (dataGridEmprunts.RowCount > 0)
                setNewsEmprunts();
        }
    }
}