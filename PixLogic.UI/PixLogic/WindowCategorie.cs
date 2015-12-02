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
    public partial class WindowCategorie : Form
    {
        Database database = Helper.database;
        private DataGridView dataGridCategories;

        public WindowCategorie(DataGridView d)
        {
            InitializeComponent();
            dataGridCategories = d;
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            if(!Helper.fieldsAreEmpty(true, valLibelle.Text)
                && Helper.AreNumbers(true, valLevel.Text)
                && Helper.confirmation(Helper.ADD))
            {
                database.AddCategorie(valLibelle.Text, int.Parse(valLevel.Text));
            }
        }
        
        private void setTableCategories(List<Categorie> l)
        {
            List<Categorie> list = l;
            dataGridCategories.Rows.Clear();
            //dataGridUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            foreach (var cat in list)
            {
                dataGridCategories.Rows.Add(cat.CategorieId, cat.name, cat.level);
            }

            if (dataGridCategories.RowCount > 0)
            {
                dataGridCategories.FirstDisplayedScrollingRowIndex = 0;
                dataGridCategories.Refresh();
                dataGridCategories.CurrentCell = dataGridCategories.Rows[0].Cells[0];
                dataGridCategories.Rows[0].Selected = true;
            }

            setNewsCategories();
            checkEnableButton();
        }

        private void setNewsCategories()
        {

        }

        private void checkEnableButton()
        {

        }
    }
}
