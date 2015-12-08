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
                start();
            }
        }
        private void start()
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
                valFinReservation.Text = ((DateTime)reservation.endDateEmprunt).ToString("D");
                valDebutReservation.Text = ((DateTime)reservation.beginDateEmprunt).ToString("D");
                valNomUser.Text = reservation.user.name;
                valNomReservable.Text = reservation.reservable.name;
                valType.Text = reservation.isPack ? Helper.PACK : Helper.ITEM;
            }
            else
            {
                valFinReservation.Text = "-";
                valDebutReservation.Text = "-";
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridLogs.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            foreach (DataGridViewColumn column in dataGridLogs.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dataGridLogs.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "ListeDesLogs" + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }

        private void dataGridLogs_Click(object sender, EventArgs e)
        {
            if (dataGridLogs.RowCount > 0)
                setNewsLogs();
        }

        private void dataGridLogs_DoubleClick(object sender, EventArgs e)
        {
            int idReservation = int.Parse(dataGridLogs.CurrentRow.Cells[0].Value.ToString());
            WindowMail wMail = new WindowMail(idReservation);
            wMail.ShowDialog();
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

        private void pictureReinit_Click(object sender, EventArgs e)
        {
            start();
        }
        private void filtrer()
        {
            DateTime debut = new DateTime();
            DateTime fin = new DateTime();
            List<Reservation> list = new List<Reservation>();

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
                    list = database.GetAllPacksEmprunts(list);
                else
                    list = database.GetAllItemsEmprunts(list);
                Console.WriteLine("DANS LE OUI ou PAS");
            }
            else if (!checkBoxPack.Checked && !checkBoxItem.Checked)
                list = new List<Reservation>();

            setTableLogs(list);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filtrer();
        }

        private void pictureExport_Click(object sender, EventArgs e)
        {
            WindowExport export = new WindowExport(dataGridLogs);
            export.ShowDialog();
        }

        private void pictureExport_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureExport, "Exporter la liste.");
            pictureExport.Cursor = Cursors.Hand;
        }
    }
}
