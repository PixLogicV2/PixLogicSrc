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
        private DAL.Database database = Helper.database;

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

                    using (WindowScriptResult Res = new WindowScriptResult())
                    {
                        Res.Queryresult = table;
                        Res.ShowDialog();
                    }  
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panScript_Load(object sender, EventArgs e)
        {
            List<Requete> allRequest = database.GetAllRequete();

            QueryListBox.DataSource = database.GetAllRequete();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //string content = QueryRTB.Text;

            //using (SaveFileDialog querySaveDialog = new SaveFileDialog())
            //{
            //    querySaveDialog.Filter = "Fichier SQL (*.sql)|*.sql";
            //    querySaveDialog.FilterIndex = 2;
            //    querySaveDialog.RestoreDirectory = true;

            //    if(querySaveDialog.ShowDialog()==DialogResult.OK)
            //    {
            //        File.WriteAllText(querySaveDialog.FileName,  content);
            //    }
            //}
            string content = QueryRTB.Text;

            using (SaveFileDialog querySaveDialog = new SaveFileDialog())
            {
                querySaveDialog.Filter = "Fichier SQL (*.sql)|*.sql";
                querySaveDialog.FilterIndex = 2;
                querySaveDialog.RestoreDirectory = true;

                if (querySaveDialog.ShowDialog() == DialogResult.OK)
                {
                    database.AddRequete(Path.GetFileNameWithoutExtension(querySaveDialog.FileName), content);
                }
            }

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
