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
        private DAL.Database database;

        public panScript()
        {
            InitializeComponent();
            if(MainWindow.START)
            {
                database = Helper.database;
                refresh();
            }
        }

        public void refresh()
        {
            setTableRequete(database.GetAllRequete());
            QueryRTB.Text = "";
        }

        private void setTableRequete(List<Requete> r)
        {
            List<Requete> requetes = r;
            dataGridRequetes.Rows.Clear();

            foreach(Requete req in requetes)
            {
                dataGridRequetes.Rows.Add(req.RequeteId, req.name);
            }

            if (dataGridRequetes.RowCount > 0)
            {
                dataGridRequetes.FirstDisplayedScrollingRowIndex = 0;
                dataGridRequetes.Refresh();
                dataGridRequetes.CurrentCell = dataGridRequetes.Rows[0].Cells[1];
                dataGridRequetes.Rows[0].Selected = true;
            }
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string content = QueryRTB.Text;

            if(!QueryRTB.Text.Equals(""))
            {
                using (WindowSaveRequestAs save = new WindowSaveRequestAs())
                {
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        database.AddRequete(save.SelectedName, content);
                        MessageBox.Show("Votre requête a bien été sauvegardée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setTableRequete(database.GetAllRequete());
                    }
                }
            }
            else
            {
                MessageBox.Show("le champs de requête est vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (dataGridRequetes.RowCount > 0)
            {
                bool result = false;
                DialogResult resultBox = MessageBox.Show("Voulez-vous charger cette requête ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                result = (resultBox == DialogResult.Yes) ? true : false;

                if(result)
                {
                    int queryID = Convert.ToInt32(dataGridRequetes.CurrentRow.Cells[0].Value.ToString());
                    Requete selectedQuery = database.GetRequeteById(queryID);
                    QueryRTB.Text = selectedQuery.text;
                }
                
            }
            else
            {
                MessageBox.Show("Sélectionnez une requête.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSupp_Click(object sender, EventArgs e)
        {
            if (dataGridRequetes.RowCount > 0)
            {
                bool result = false;
                DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment supprimer cette requête ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                result = (resultBox == DialogResult.Yes) ? true : false;

                if (result)
                {
                    int queryID = Convert.ToInt32(dataGridRequetes.CurrentRow.Cells[0].Value.ToString());
                    database.DeleteRequete(queryID);
                    setTableRequete(database.GetAllRequete());
                }

            }
            else
            {
                MessageBox.Show("Sélectionnez une requête.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
