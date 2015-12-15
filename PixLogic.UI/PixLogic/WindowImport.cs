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

        private int nbColumns;
        private Database database = Helper.database;
        private panUsers pan;

        public WindowImport(panUsers p)
        {
            InitializeComponent();
            pan = p;
            init();
            setForUser();
        }
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
            nbColumns = 5;
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
            if (dataGridImport.Columns.Count < nbColumns)
            {
                foreach (User u in users)
                {
                    dataGridImport.Rows.Add(u.name, u.nickname, u.userClass.name, u.mail);
                }
            }
            else
            {
                foreach (User u in users)
                {
                    dataGridImport.Rows.Add(u.name, u.nickname, u.userClass.name, u.mail, u.phoneNumber);
                }
            }
            //dataGridImport.Rows[]
            

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

        private void buttonImporter_Click(object sender, EventArgs e)
        {
            if(dataGridImport.Columns.Count < nbColumns)
            {
                UserClass classe = new UserClass();
                for (int i = 0; i < dataGridImport.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridImport.Rows[i];
                    classe = database.GetUserClassByName(row.Cells[2].Value.ToString());
                    Image img = Properties.Resources.noprofil;
                    database.AddUser(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), "", img, classe);
                }
                /*foreach (DataGridViewRow row in dataGridImport.Rows)
                {
                    classe = database.GetUserClassByName(row.Cells[2].Value.ToString());
                    Image img = Properties.Resources.noprofil;
                    database.AddUser(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), "", img, classe);
                }*/
            }
            else if(dataGridImport.Columns.Count == nbColumns)
            {
                for(int i = 0; i < dataGridImport.Rows.Count-1; i++)
                {
                    DataGridViewRow row = dataGridImport.Rows[i];
                    UserClass userClass = database.GetUserClassByName(row.Cells[2].Value.ToString());

                    Image img = Properties.Resources.noprofil;
                    database.AddUser(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), img, userClass);

                }
                /*foreach (DataGridViewRow row in dataGridImport.Rows)
                {
                    UserClass userClass = database.GetUserClassByName(row.Cells[2].Value.ToString());

                    Image img = Properties.Resources.noprofil;
                    database.AddUser(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), img, userClass);

                }*/
            }

            MessageBox.Show("La liste a été bien importée.");
            try
            {
                pan.setTableUsers(database.GetAllUsers());
            }catch(Exception ex) { }
            this.Close();
        }
    }
}
