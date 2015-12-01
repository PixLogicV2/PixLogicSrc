using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using PixLogic.DAL;
using System.IO;

namespace PixLogic
{
    public partial class panScript : UserControl
    {
        public panScript()
        {
            InitializeComponent();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {

            //this connectionString use a specific login to send select request ONLY
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=PixLogic.DAL.DataContext;User Id=SelectOnly;Password=a;";

            string query = QueryRTB.Text;

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    //feed of the datagridview
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ResultDGV.DataSource = table;

                    //resizing columns for clearer results
                    ResultDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
            }
            catch(Exception ex)
            {
                //catch all exceptions
                MessageBox.Show(ex.Message.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            //open a dialog for browsing through file
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                try
                {
                    //get the content of the file to feed the richTextBox, path access issue here, fixing pending
                    string fileQuery = File.ReadAllText(Path.GetDirectoryName(openFileDialog.FileName));
                    QueryRTB.Text = fileQuery;
                }
                catch(Exception ex)
                {
                    //catch all exceptions
                    MessageBox.Show(ex.Message.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
