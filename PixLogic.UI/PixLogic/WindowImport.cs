using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using PixLogic.DAL;

namespace PixLogic
{
    public partial class WindowImport : Form
    {
        public WindowImport()
        {
            InitializeComponent();
            init();
            setForUser();
        }

        private void init()
        {
            radioPointVirgule.Checked = true;
            radioNo.Checked = true;
        }

        private void setForUser()
        {
            dataGrid.Rows.Clear();
            
            dataGrid.Rows.Add( "Nom", true);
            dataGrid.Rows.Add( "Prénom", true);
            dataGrid.Rows.Add( "Classe", true);
            dataGrid.Rows.Add("E-mail", true);
            dataGrid.Rows.Add( "Tel", false);
            dataGrid.Rows[dataGrid.Rows.Count-1].Cells[dataGrid.ColumnCount-1].ReadOnly = false;
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
                List<User> users = Helper.importCSV(valChemin.Text, radioVirgule.Checked, radioYes.Checked);
                setTableImport(users);
            }
        }

        private void setTableImport(List<User> us)
        {
            List<User> users = us;
            dataGridImport.Rows.Clear();

            foreach(User u in users)
            {
                dataGridImport.Rows.Add(u.name, u.nickname, u.mail, u.phoneNumber);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dataGridImport.Rows.Clear();
            dataGridImport.Columns.Clear();
            int i = 0;
            foreach(DataGridViewRow row in dataGrid.Rows)
            {
                if(Convert.ToBoolean(row.Cells[1].Value) == true)
                {
                    dataGridImport.Columns.Add("c"+i, row.Cells[0].Value.ToString());
                }
                i++;
            }
            dataGridImport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
