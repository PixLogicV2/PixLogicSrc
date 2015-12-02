using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PixLogic.DAL;
using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
            int idReservation = int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString());
            if(Helper.confirmationEmprunt(idReservation))
            {
                database.EmpruntReservation(idReservation);
                setTableReservations(database.GetAllReservations());
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
            int idReservation = int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString());
            Reservation reservation = database.GetReservationById(idReservation);
            int idReservable = reservation.reservable.ReservableId;

            WindowSetReservation set = new WindowSetReservation(idReservation, idReservable, this);
            set.ShowDialog(this);
        }

        private void buttonCancelReserv_Click(object sender, EventArgs e)
        {
            if (Helper.confirmationReservation(Helper.CANCEL))
            {
                database.DeleteReservation(int.Parse(dataGridReservations.CurrentRow.Cells[0].Value.ToString()));
                setTableReservations(database.GetAllReservations());
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
            setTableReservations(database.GetAllReservations());
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableReservations(database.GetAllReservationsByString(textBoxSearch.Text));
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridReservations.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridReservations.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridReservations.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "ListeDesReservations"+DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString()+".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
        
        private void buttonExportCsv_Click(object sender, EventArgs e)
        {
            /*
            dataGridReservations.SelectAll();
            DataObject dataObj = dataGridReservations.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            */
        }
        
    }
}
