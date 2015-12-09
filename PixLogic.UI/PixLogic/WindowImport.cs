﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace PixLogic
{
    public partial class WindowImport : Form
    {
        public WindowImport()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            radioPointVirgule.Checked = true;
            radioNo.Checked = true;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".csv";
            openFileDialog.Filter = "Csv documents|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //buttonExporter.Enabled = true;
                valChemin.Text = openFileDialog.FileName;
                Helper.importCSV(valChemin.Text, radioVirgule.Checked, radioYes.Checked);
            }
        }
    }
}
