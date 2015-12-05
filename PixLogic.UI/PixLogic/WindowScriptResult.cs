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

namespace PixLogic
{
    public partial class WindowScriptResult : Form
    {
        public DataTable Queryresult { get; set; }

        public WindowScriptResult()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowScriptResult_Load(object sender, EventArgs e)
        {
            ResultDGV.DataSource = Queryresult;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog exportDialog = new SaveFileDialog())
            {
                exportDialog.Filter = "Fichier CSV (*.csv)|*.csv" ;
                exportDialog.FilterIndex = 2 ;
                exportDialog.RestoreDirectory = true ;
                if(exportDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    IEnumerable<string> columnNames = Queryresult.Columns.Cast<DataColumn>().
                                                      Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataRow row in Queryresult.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        sb.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText(exportDialog.FileName, sb.ToString());
                }
            }
            
        }
    }
}
