using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PixLogic.DAL;
using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing;
using System.Threading;

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
                refresh();
            }
        }

        public void refresh()
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
                    reser.beginDateReservation.Value.ToString("d"), reser.endDateReservation.Value.ToString("d"), reser.manager.name);
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

        private void setNewsReservations()
        {
            if (dataGridReservations.RowCount > 0)
            {
                Reservation reservation = database.GetReservationById(Convert.ToInt32(dataGridReservations.CurrentRow.Cells[0].Value));
                valDateFin.Text = ((DateTime)reservation.endDateReservation).ToString("D");
                valDateDebut.Text = ((DateTime)reservation.beginDateReservation).ToString("D");
                valNomUser.Text = reservation.user.name;

                string nomReservable = reservation.reservable.name; ;
                if (reservation.isPack)
                    valNomReservable.Text = nomReservable;
                else
                    valNomReservable.Text = nomReservable+ " (Ref: " + ((Item)reservation.reservable).reference+")";

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
            if (dataGridReservations.RowCount > 0)
            {
                int idReservation = int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString());
                if (Helper.confirmationEmprunt(idReservation) && Helper.dateReservationToday(idReservation))
                {
                    database.EmpruntReservation(idReservation);
                    setTableReservations(database.GetAllReservations());
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un élément dans la table.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
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
                list = database.GetAllReservationsByDateDebut(debut);
            }
            else if (radioOfPastSevenDays.Checked)
            {
                debut = DateTime.Today;
                fin = debut.AddDays(7);
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
            }
            else if(!checkBoxPack.Checked && !checkBoxItem.Checked)
                list = new List<Reservation>();

            setTableReservations(list);
        }

        private void buttonModif_Click(object sender, EventArgs e)
        {
            if (dataGridReservations.RowCount > 0)
            {
                int idReservation = int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString());
                Reservation reservation = database.GetReservationById(idReservation);
                int idReservable = reservation.reservable.ReservableId;

                WindowSetReservation set = new WindowSetReservation(idReservation, idReservable, this);
                set.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un élément dans la table.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void buttonCancelReserv_Click(object sender, EventArgs e)
        {
            if (dataGridReservations.RowCount > 0)
            {
                if (Helper.confirmationReservation(Helper.CANCEL))
                {
                    database.DeleteReservation(int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString()));
                    setTableReservations(database.GetAllReservations());
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un élément dans la table.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            setTableReservations(database.GetAllReservations());
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableReservations(database.GetAllReservationsByString(textBoxSearch.Text));
        }

      
        private void pictureExport_Click(object sender, EventArgs e)
        {
            string title = "Liste des réservations";
            WindowExport export = new WindowExport(dataGridReservations, title);
            export.ShowDialog();
        }

        public DataGridView getTable()
        {
            return dataGridReservations;
        }
        

        private void dataGridReservations_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridReservations[e.ColumnIndex, e.RowIndex];
                int id = int.Parse(dataGridReservations.Rows[e.RowIndex].Cells[0].Value.ToString());
                Reservation reservation = database.GetReservationById(id);
                string materiels = "Liste matériels du pack "+reservation.reservable.name+":\n";
                if (reservation.isPack)
                {
                    
                    foreach(Item i in database.GetItemsInPack(reservation.reservable.ReservableId))
                    {
                        materiels += ("\t- " + i.name + "\n");
                    }
                    cell.ToolTipText = materiels;
                }
                
            }
            
            
            
        }

        private void dataGridReservations_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridReservations.RowCount > 0)
            {
                int id = int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString());
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
            int idReservation = int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString());
            WindowMail wMail = new WindowMail(idReservation);
            wMail.ShowDialog();

        }
    }
}
