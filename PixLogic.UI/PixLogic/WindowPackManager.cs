﻿using PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixLogic
{
    public partial class WindowPackManager : Form
    {
        private panItemPack pan;
        private Database database = new Database();

        public WindowPackManager(panItemPack p)
        {
            InitializeComponent();
            pan = p;
            setTablePacks(database.GetAllPacks());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WindowPack winpack = new WindowPack(pan, this);
            winpack.ShowDialog(this);
        }

        public void setTablePacks(List<Pack> l)
        {
            List<Pack> list = l;
            dataGridPack.Rows.Clear();
            foreach (var pack in list)
            {
                dataGridPack.Rows.Add(pack.name, pack.price, pack.dispo ? "OUI" : "NON");
                Console.WriteLine("Description: " + pack.description);
            }

            if (dataGridPack.RowCount > 0)
            {
                dataGridPack.FirstDisplayedScrollingRowIndex = 0;
                dataGridPack.Refresh();
                dataGridPack.CurrentCell = dataGridPack.Rows[0].Cells[0];
                dataGridPack.Rows[0].Selected = true;

                setNewsPack();
            }

        }

        private void setNewsPack()
        {
            valNamePack.Text = dataGridPack.CurrentRow.Cells[0].Value.ToString();
            valPrice.Text = dataGridPack.CurrentRow.Cells[1].Value.ToString();
            valDispo.Text = dataGridPack.CurrentRow.Cells[2].Value.ToString();
            int nbItemInPack = database.GetItemsInPack(valNamePack.Text).Count;
            valNbItems.Text = ""+nbItemInPack;

            Pack packT = database.GetPackByName(valNamePack.Text);
            valDispo.Text = packT.dispo ? "OUI" : "NON";
            
            valDescription.Text = packT.description;

            setListItemsOfPack(valNamePack.Text);
        }

        private void setListItemsOfPack(string namePack)
        {
            listBoxItemsOfPack.Items.Clear();
            List<Item> items = database.GetItemsInPack(namePack);

            foreach (var item in items)
            {
                listBoxItemsOfPack.Items.Add(item.name);
            }
            if (listBoxItemsOfPack.Items.Count > 0)
                listBoxItemsOfPack.SelectedIndex = 0;
            else
                pictureBoxItem.Image = null;
        }

        private void dataGridPack_Click(object sender, EventArgs e)
        {
            if (dataGridPack.RowCount > 0)
                setNewsPack();
        }

        private void listBoxItemsOfPack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxItemsOfPack.Items.Count > 0)
            {
                Item item = database.GetItemByName(listBoxItemsOfPack.SelectedItem.ToString());
                Image img = database.ByteArrayToImage(item.image);
                Helper.putImageInBox(pictureBoxItem, img);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            WindowPack winpack = new WindowPack(valNamePack.Text, valPrice.Text, valDescription.Text, pan, this);
            winpack.ShowDialog(this);
        }
    }
}

