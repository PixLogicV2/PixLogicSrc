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
           
            queryDGV.DataSource = allRequest;
            queryDGV.Columns[1].Visible = false;
            queryDGV.Columns[2].Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string content = QueryRTB.Text;

            using (WindowSaveRequestAs save = new WindowSaveRequestAs())
            {
                
                if(save.ShowDialog() == DialogResult.OK)
                {
                    database.AddRequete(save.SelectedName, content);
                    MessageBox.Show("Votre requete à été sauvegardée.");
                    queryDGV.DataSource = database.GetAllRequete();
                }
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rw = queryDGV.SelectedRows[0];

                Requete query = rw.DataBoundItem as Requete;

                QueryRTB.Text = query.text;
            }

            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selectionez une requete.");
            }
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rw = queryDGV.SelectedRows[0];

                Requete query = rw.DataBoundItem as Requete;

                database.DeleteRequete(query.RequeteId);

                queryDGV.DataSource = database.GetAllRequete();

                MessageBox.Show("La requete " + query.name + " a été supprimmée.");
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selectionez une requete.");
            }
        }
    }
}
