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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
                refresh();
            }
        }
        public void refresh()
        {
            setRadioButton();
            setTableLogs(database.GetAllLogs());
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
        public void setTableLogs(List<Log> l)
        {
            List<Log> list = l;
            dataGridLogs.Rows.Clear();
            foreach (Log reser in list)
            {
                string typ = reser.isPack ? Helper.PACK : Helper.ITEM;
                dataGridLogs.Rows.Add(reser.LogId, reser.userName, reser.reservableName,
                    typ, reser.beginDateEmprunt.Value.ToString("d"), reser.endDateEmprunt.Value.ToString("d"));
              
            }

            if (dataGridLogs.RowCount > 0)
            {
                dataGridLogs.FirstDisplayedScrollingRowIndex = 0;
                dataGridLogs.Refresh();
                dataGridLogs.CurrentCell = dataGridLogs.Rows[0].Cells[0];
                dataGridLogs.Rows[0].Selected = true;
            }

            setNewsLogs();
        }
        private void setNewsLogs()
        {
            if (dataGridLogs.RowCount > 0)
            {
                Log reservation = database.GetLogById(Convert.ToInt32(dataGridLogs.CurrentRow.Cells[0].Value));

                valDebutEmprunt.Text = ((DateTime)reservation.beginDateEmprunt).ToString("D");
                valFinEmprunt.Text = ((DateTime)reservation.endDateEmprunt).ToString("D");

                valManager.Text = reservation.managerName;
                valNomUser.Text = reservation.userName +" "+reservation.userNickname;
                valNomReservable.Text = reservation.reservableName;
                valType.Text = reservation.isPack ? Helper.PACK : Helper.ITEM;
            }
            else
            {
                valDebutEmprunt.Text = "-";
                valFinEmprunt.Text = "-";
                valNomUser.Text = "-";
                valNomReservable.Text = "-";
                valType.Text = "-";
                valManager.Text = "-";
            }

        }

        private void dataGridLogs_Click(object sender, EventArgs e)
        {
            if (dataGridLogs.RowCount > 0)
                setNewsLogs();
        }

        private void dataGridLogs_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridLogs_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridLogs.RowCount > 0)
                setNewsLogs();
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableLogs(database.GetAllLogsByString(textBoxSearch.Text));
        }
        
        private void filtrer()
        {
            DateTime debut = new DateTime();
            DateTime fin = new DateTime();
            List<Log> list = new List<Log>();

            if (radioAll.Checked)
            {
                list = database.GetAllLogs();
            }

            else if (radioToday.Checked)
            {
                debut = DateTime.Today;
                fin = debut;
                list = database.GetAllLogsByDate(debut, fin);
            }
            else if (radioOfPastSevenDays.Checked)
            {
                fin = DateTime.Today;
                debut = fin.AddDays(-7);
                list = database.GetAllLogsByDate(debut, fin);
            }
            else if (radioBetween.Checked)
            {
                debut = DateTime.Parse(dateTimeBegin.Text);
                fin = DateTime.Parse(dateTimeEnd.Text);
                list = database.GetAllLogsByDate(debut, fin);

            }
            if ((checkBoxItem.Checked && !checkBoxPack.Checked) || (checkBoxPack.Checked && !checkBoxItem.Checked))
            {
                if (checkBoxPack.Checked)
                    list = database.GetAllPackLogs(list);
                else
                    list = database.GetAllItemLogs(list);
                Console.WriteLine("DANS LE OUI ou PAS");
            }
            else if (!checkBoxPack.Checked && !checkBoxItem.Checked)
                list = new List<Log>();

            setTableLogs(list);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filtrer();
        }

        private void pictureExport_Click(object sender, EventArgs e)
        {
            string title = "Historique";
            WindowExport export = new WindowExport(dataGridLogs, title);
            export.ShowDialog();
        }

        public DataGridView getTable()
        {
            return dataGridLogs;
        }
        
    }
}
