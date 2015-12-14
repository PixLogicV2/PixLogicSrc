﻿using System;
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
            setTableUserClass(database.GetAllUserClass());
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
                valLibelleCat.Text = dataGridCategories.CurrentRow.Cells[1].Value.ToString();
                valLevel.Text = dataGridCategories.CurrentRow.Cells[2].Value.ToString();
                valDescription.Text = database.GetCategorieById(int.Parse(dataGridCategories.CurrentRow.Cells[0].Value.ToString())).description;
            }
            else
            {
                valLibelleCat.Text = "-";
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

        public void setTableUserClass(List<UserClass> l)
        {
            List<UserClass> list = l;
            dataGridUserClass.Rows.Clear();
            //dataGridUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            foreach (var classe in list)
            {
                dataGridUserClass.Rows.Add(classe.UserClassId, classe.name, classe.credits, classe.level);
            }

            if (dataGridUserClass.RowCount > 0)
            {
                dataGridUserClass.FirstDisplayedScrollingRowIndex = 0;
                dataGridUserClass.Refresh();
                dataGridUserClass.CurrentCell = dataGridUserClass.Rows[0].Cells[0];
                dataGridUserClass.Rows[0].Selected = true;
            }

            setNewsUserClass();
            checkEnableButtonClasse();
        }

        private void setNewsUserClass()
        {
            if (dataGridUserClass.RowCount > 0)
            {
                valLibelleClasse.Text = dataGridUserClass.CurrentRow.Cells[1].Value.ToString();
                valCreditClasse.Text = dataGridUserClass.CurrentRow.Cells[2].Value.ToString();
                valNiveauAccesClasse.Text = dataGridUserClass.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                valLibelleClasse.Text = "-";
                valNiveauAccesClasse.Text = "-";
                valCreditClasse.Text = "-";
            }
        }

        private void checkEnableButtonClasse()
        {
            if (dataGridUserClass.RowCount > 0)
            {
                buttonModifierClasse.Enabled = true;
                buttonSuppClasse.Enabled = true;
            }
            else
            {
                buttonModifierClasse.Enabled = false;
                buttonSuppClasse.Enabled = false;
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
            textBoxSearch.Text = string.Empty;
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

        private void buttonAjouterClasse_Click(object sender, EventArgs e)
        {
            WindowClasse winClasse = new WindowClasse(this);
            winClasse.ShowDialog();
        }

        private void buttonModifierClasse_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridUserClass.CurrentRow.Cells[0].Value.ToString());
            WindowClasse winClasse = new WindowClasse(this, id);
            winClasse.ShowDialog();
        }

        private void dataGridUserClass_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridUserClass.RowCount > 0)
                setNewsUserClass();
        }

        private void dataGridUserClass_Click(object sender, EventArgs e)
        {
            if (dataGridUserClass.RowCount > 0)
                setNewsUserClass();
        }

        private void textBoxSearchClasse_KeyUp(object sender, KeyEventArgs e)
        {
            setTableUserClass(database.GetAllUserClassByString(textBoxSearchClasse.Text));
        }

        private void buttonCancelClasse_Click(object sender, EventArgs e)
        {
            textBoxSearchClasse.Text = string.Empty;
            setTableUserClass(database.GetAllUserClass());
        }
    }
}
