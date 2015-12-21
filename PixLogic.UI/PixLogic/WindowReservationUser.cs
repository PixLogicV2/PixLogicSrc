using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixLogic.DAL;

namespace PixLogic
{
    public partial class WindowReservationUser : Form
    {

        private Database database = Helper.database;

        public WindowReservationUser()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            List<Item> list = Helper.get
            setTableItem();
        }

        private void setTableItem(List<Item> l)
        {
            List<Item> list = l;

            dataGridItem.Rows.Clear();

            foreach(Item item in list)
            {
                dataGridItem.Rows.Add(item.name, item.price);
            }

            if (dataGridItem.RowCount > 0)
            {
                dataGridItem.FirstDisplayedScrollingRowIndex = 0;
                dataGridItem.Refresh();
                dataGridItem.CurrentCell = dataGridItem.Rows[0].Cells[0];
                dataGridItem.Rows[0].Selected = true;
            }
        }

        private void buttonOk_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(buttonOk, "Valider.");
        }
    }
}
