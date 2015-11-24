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
            //try
            //{
            //    using (var datacontext = new DataContext())
            //    {
            //        var result = datacontext.Database.SqlQuery<string>(QueryRTB.Text).ToList();
            //        ResultDGV.DataSource = result;
            //    }
            //}
            //catch(Exception exept)
            //{
            //    MessageBox.Show(exept.Message.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            var datacontext = new DataContext();

            string connectionString = datacontext.Database.Connection.ConnectionString;

            string query = QueryRTB.Text;

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    ResultDGV.DataSource = table;

                    ResultDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            datacontext.Dispose();
        }
    }
}
