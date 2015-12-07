using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PixLogic
{
    public partial class WindowExport : Form
    {
        private DataGridView table;

        public WindowExport(DataGridView t)
        {
            InitializeComponent();
            buttonExporter.Enabled = false;
            table = t;
        }

        private void panPdf_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(panPdf, "Exporter la liste en PDF.");
            panPdf.Cursor = Cursors.Hand;
        }

        private void panCsv_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(panCsv, "Exporter la liste en CSV.");
            panCsv.Cursor = Cursors.Hand;
        }

        private void auClickPdf()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.Filter = "Pdf documents|*.pdf";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                buttonExporter.Enabled = true;
                valChemin.Text = saveFileDialog.FileName;
            }
        }
        private void auClickCsv()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".csv";
            saveFileDialog.Filter = "Csv documents|*.Csv";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                buttonExporter.Enabled = true;
                valChemin.Text = saveFileDialog.FileName;
            }
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            string chemin = valChemin.Text;
            if (chemin.EndsWith(".pdf") || chemin.EndsWith(".PDF"))
                Helper.exportPDF(table, valChemin.Text);
            else
                Helper.exportCSV(table, valChemin.Text);

            Process process = new Process();
            if (checkBoxOpen.Checked)
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + valChemin.Text;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.Dispose();
            }
            this.Close();
            process.Close();
        }

        private void panPdf_Click(object sender, EventArgs e)
        {
            auClickPdf();
        }
        private void labelExporterPDF_Click(object sender, EventArgs e)
        {
            auClickPdf();
        }

        private void pictureBoxPdf_Click(object sender, EventArgs e)
        {
            auClickPdf();
        }

        private void panCsv_Click(object sender, EventArgs e)
        {
            auClickCsv();
        }

        private void labelExportCsv_Click(object sender, EventArgs e)
        {
            auClickCsv();
        }

        private void pictureBoxCSV_Click(object sender, EventArgs e)
        {
            auClickCsv();
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
