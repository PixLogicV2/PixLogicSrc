using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PixLogic.DAL;
using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Threading;

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
                refresh();
            }
        }

        public void refresh()
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
                    reser.beginDateEmprunt.Value.ToString("d"), reser.endDateEmprunt.Value.ToString("d"), reser.manager.name);

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
                buttonRendre.Enabled = true;
            }
            else
            {
                buttonRendre.Enabled = false;
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

                string nomReservable = reservation.reservable.name; ;
                if (reservation.isPack)
                    valNomReservable.Text = nomReservable;
                else
                    valNomReservable.Text = nomReservable + " (Ref: " + ((Item)reservation.reservable).reference + ")";

                valType.Text = reservation.isPack ? Helper.PACK : Helper.ITEM;
                valManager.Text = reservation.manager.pseudo;
            }
            else
            {
                valDateFin.Text = "-";
                valDateDebut.Text = "-";
                valNomUser.Text = "-";
                valNomReservable.Text = "-";
                valType.Text = "-";
                valManager.Text = "-";
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

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filtrer();
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
                fin = DateTime.Today.Date ;
                list = database.GetAllEmpruntsByDateFin(fin);
            }
            else if (radioOfNextSevenDays.Checked)
            {
                debut = DateTime.Today.Date;
                fin = debut.AddDays(7);
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

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            setTableEmprunts(database.GetAllEmprunts());
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

        private void buttonRendre_Click(object sender, EventArgs e)
        {
            if(dataGridEmprunts.RowCount > 0)
            {
                int idReservation = int.Parse(dataGridEmprunts.CurrentRow.Cells[0].Value.ToString());
                if (Helper.confirmationRemise(idReservation))
                {
                    database.RetourEmprunt(idReservation, DateTime.Today.Date);
                    setTableEmprunts(database.GetAllEmprunts());
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un élément dans la table.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void dataGridEmprunts_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridEmprunts.RowCount > 0)
            {
                int id = int.Parse(dataGridEmprunts.CurrentRow.Cells[0].Value.ToString());
                User u = database.GetUserById(id);
                if (u.mail.Equals(""))
                {
                    MessageBox.Show("Cet utilisateur n'a pas d'adresse e-mail.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Thread thread = new Thread(new ThreadStart(openWindowMail));
                thread.Start();
            }
        }
        private void openWindowMail()
        {
            int idReservation = int.Parse(dataGridEmprunts.CurrentRow.Cells[0].Value.ToString());
            WindowMail wMail = new WindowMail(idReservation);
            wMail.ShowDialog();

        }

        private void dataGridEmprunts_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (dataGridEmprunts.RowCount > 0)
                setNewsEmprunts();
        }

        private void pictureExport_Click(object sender, EventArgs e)
        {
            string title = "Liste des emprunts";
            WindowExport export = new WindowExport(dataGridEmprunts, title);
            export.ShowDialog();
        }

        public DataGridView getTable()
        {
            return dataGridEmprunts;
        }

        private void dataGridEmprunts_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridEmprunts[e.ColumnIndex, e.RowIndex];
                int id = int.Parse(dataGridEmprunts.Rows[e.RowIndex].Cells[0].Value.ToString());
                Reservation reservation = database.GetReservationById(id);
                string materiels = "Liste matériels du pack " + reservation.reservable.name + ":\n";
                if (reservation.isPack)
                {

                    foreach (Item i in database.GetItemsInPack(reservation.reservable.ReservableId))
                    {
                        materiels += ("\t- " + i.name + "\n");
                    }
                }
                cell.ToolTipText = materiels;
            }
        }
    }
}
