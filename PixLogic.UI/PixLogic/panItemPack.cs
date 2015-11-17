using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PixLogic.DAL;


namespace PixLogic
{
    public partial class panItemPack : UserControl
    {
        Database database;
        public panItemPack()
        {
            InitializeComponent();
            if (MainWindow.START)
            {
                database = Helper.database;
                setTableItem(database.GetAllItems());
                setComboBoxPack();
            }
        }

        public void setTableItem(List<Item> l)
        {
            List<Item> list = l;
            dataGridItem.Rows.Clear();
            foreach(var item in list)
            {
                dataGridItem.Rows.Add(item.name, item.quantity, item.price);
            }

            if(dataGridItem.RowCount > 0)
            {
                dataGridItem.FirstDisplayedScrollingRowIndex = 0;
                dataGridItem.Refresh();
                dataGridItem.CurrentCell = dataGridItem.Rows[0].Cells[0];
                dataGridItem.Rows[0].Selected = true;
            }

            setNewsItem();
            checkEnableButton();
        }

        private void checkEnableButton()
        {
            if(dataGridItem.RowCount > 0)
            {
                buttonModify.Enabled = true;
                buttonDelete.Enabled = true;
                buttonTransfert.Enabled = true;
            }
            else
            {
                buttonModify.Enabled = false;
                buttonDelete.Enabled = false;
                buttonTransfert.Enabled = false;
            }
        }

        private void setNewsItem()
        {
            if (dataGridItem.RowCount > 0)
            {
                listBoxItem.AllowDrop = true;
                valItemName.Text = dataGridItem.CurrentRow.Cells[0].Value.ToString();
                valQuantity.Text = dataGridItem.CurrentRow.Cells[1].Value.ToString();
                valPrice.Text = dataGridItem.CurrentRow.Cells[2].Value.ToString();
                Item item = database.GetItemByName(valItemName.Text);
                valDispo.Text = item.dispo ? "OUI" : "NON";
                valDescription.Text = item.description;

                Image img = database.ByteArrayToImage(item.image);
                Helper.putImageInBox(pictureBoxItem, img);
            }
            else
            {
                listBoxItem.AllowDrop = false;
                valItemName.Text = "-";
                valQuantity.Text = "-";
                valPrice.Text = "-";
                valDispo.Text = "-";
                valDescription.Text = "-";
                pictureBoxItem.Image = null;
            }

            checkTransfert();
        }

        private void checkTransfert()
        {
            if (comboBoxPack.Items.Count == 0 || dataGridItem.RowCount == 0)
            {
                listBoxItem.AllowDrop = false;
                buttonTransfert.Enabled = false;
            }
            else
            {
                listBoxItem.AllowDrop = true;
                buttonTransfert.Enabled = true;
            }
        }
        
        public void setComboBoxPack()
        {
            comboBoxPack.Items.Clear();
            List<Pack> listPacks = database.GetAllPacks();

            foreach (var pack in listPacks)
            {
                comboBoxPack.Items.Add(pack.name);
            }
            if (comboBoxPack.Items.Count > 0)
            {
                comboBoxPack.SelectedIndex = 0;
                setListBoxItemsOfPack(comboBoxPack.SelectedItem.ToString());
            }
            else
                setListBoxItemsOfPack("");
            checkButtonRemoveItem(0);

            checkTransfert();
            
        }

        private void setListBoxItemsOfPack(string namePack)
        {
            listBoxItem.Items.Clear();
            if(!namePack.Equals(""))
            {
                List<Item> list = database.GetItemsInPack(namePack);

                foreach (var item in list)
                {
                    listBoxItem.Items.Add(item.name);
                }
                checkButtonRemoveItem(0);
            }
            
        }

        private void checkButtonRemoveItem(int index)
        {
            if (listBoxItem.Items.Count > 0)
            {
                listBoxItem.SelectedIndex = index;
                buttonRemoveItemInPack.Enabled = true;
            }
            else
            {
                buttonRemoveItemInPack.Enabled = false;
            }
        }
        private void pictureBoxItem_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxItem.DoDragDrop(valItemName.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBoxItem_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WindowItem windowAdd = new WindowItem(this);
            windowAdd.ShowDialog(this);
        }

        private void listBoxItem_DragDrop(object sender, DragEventArgs e)
        {
            string itemName = e.Data.GetData(DataFormats.Text).ToString();
            addingItemInPack(itemName);
        }

        private void addingItemInPack(string itemName)
        {
            string packName = comboBoxPack.SelectedItem.ToString();
            if (!Helper.IsInListBox(itemName, listBoxItem))
            {
                database.AddItemToPack(itemName, packName);
                listBoxItem.Items.Add(itemName);

                checkButtonRemoveItem(listBoxItem.Items.Count - 1);
            }
        }
        

        private void dataGridItem_Click(object sender, EventArgs e)
        {
            if (dataGridItem.RowCount > 0)
                setNewsItem();
        }

        private void dataGridItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridItem.RowCount > 0)
                setNewsItem();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxSearch.Text != "")
                setTableItem(database.GetAllItemsByString(textBoxSearch.Text));
            else
                setTableItem(database.GetAllItems());
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            WindowItem modif = new WindowItem(this, pictureBoxItem.Image, valItemName.Text, Convert.ToDouble(valPrice.Text), Convert.ToInt32(valQuantity.Text), valDescription.Text);
            modif.ShowDialog(this);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(Helper.confirmation(Helper.DELETE))
            {
                database.DeleteItem(valItemName.Text);
                setTableItem(database.GetAllItems());
                setComboBoxPack();
            }
        }

        private void buttonManagePack_Click(object sender, EventArgs e)
        {
            WindowPackManager manager = new WindowPackManager(this);
            manager.ShowDialog();
        }

        private void buttonTransfert_Click(object sender, EventArgs e)
        {
            string itemName = valItemName.Text;
            addingItemInPack(itemName);
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTableItem(database.GetAllItemsByString(textBoxSearch.Text));
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            setTableItem(database.GetAllItems());
        }

        private void comboBoxPack_SelectedIndexChanged(object sender, EventArgs e)
        {
            setListBoxItemsOfPack(comboBoxPack.SelectedItem.ToString());
        }

        private void buttonRemoveItemInPack_Click(object sender, EventArgs e)
        {
            if (Helper.confirmation(Helper.REMOVE))
            {
                database.DeleteItemToPack(listBoxItem.SelectedItem.ToString());
                setListBoxItemsOfPack(comboBoxPack.SelectedItem.ToString());
            }
        }
    }
}
