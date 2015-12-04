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
    public partial class WindowSettings : Form
    {
        private Database database = Helper.database;
        private panItemPack pan;

        public WindowSettings(panItemPack p)
        {
            InitializeComponent();
            pan = p;
            setTableCategories(database.GetAllCategorie());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WindowCategorie categorie = new WindowCategorie(this, pan);
            categorie.Show(this);
        }

        public void setTableCategories(List<Categorie> l)
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
            if (dataGridCategories.RowCount > 0)
            {
                valLibelle.Text = dataGridCategories.CurrentRow.Cells[0].Value.ToString();
                valLevel.Text = dataGridCategories.CurrentRow.Cells[1].Value.ToString();
                valDescription.Text = dataGridCategories.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                valLibelle.Text = "-";
                valLevel.Text = "-";
                valDescription.Text = "-";
            }
        }

        private void checkEnableButton()
        {
            if (dataGridCategories.RowCount > 0)
            {
                buttonModify.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonModify.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridCategories.CurrentRow.Cells[0].Value.ToString());
            WindowCategorie categorieM = new WindowCategorie(this, pan, id);
            categorieM.Show(this);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(Helper.confirmation(Helper.DELETE))
            {
                int id = int.Parse(dataGridCategories.CurrentRow.Cells[0].Value.ToString());
                database.DeleteCategorie(id);
                setTableCategories(database.GetAllCategorie());
            }
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableCategories(database.GetAllCategorieByString(textBoxSearch.Text));
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            setTableCategories(database.GetAllCategorie());
        }

        private void dataGridCategories_Click(object sender, EventArgs e)
        {
            if (dataGridCategories.RowCount > 0)
                setNewsCategories();
        }

        private void dataGridCategories_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridCategories.RowCount > 0)
                setNewsCategories();
        }
    }
}
