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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            WindowExport export = new WindowExport(ResultDGV, "Export du résutat de la requete");
            export.ShowDialog();
        }
    }
}
