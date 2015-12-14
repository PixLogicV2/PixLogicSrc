using PixLogic.DAL;
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
        private Database database = Helper.database;

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
            }
            setNewsPack();
            checkEnableButton();
        }

        private void setNewsPack()
        {
            if (dataGridPack.RowCount > 0)
            {
                valNamePack.Text = dataGridPack.CurrentRow.Cells[0].Value.ToString();
                valPrice.Text = dataGridPack.CurrentRow.Cells[1].Value.ToString();
                valDispo.Text = dataGridPack.CurrentRow.Cells[2].Value.ToString();
                int nbItemInPack = database.GetItemsInPackByName(valNamePack.Text).Count;
                valNbItems.Text = "" + nbItemInPack;

                Pack packT = database.GetPackByName(valNamePack.Text);
                valDispo.Text = packT.dispo ? "OUI" : "NON";
                valDescription.Text = packT.description;
                setListItemsOfPack(valNamePack.Text);
                valPackId.Text = packT.ReservableId.ToString();
            }
            else
            {
                listBoxItemsOfPack.Items.Clear();
                valNamePack.Text = "-";
                valNbItems.Text = "-";
                valPrice.Text = "-";
                valDispo.Text = "-";
                valDescription.Text = "-";
                pictureBoxItem.Image = null;
                valPackId.Text = "-";
            }
        }

        private void checkEnableButton()
        {
            if (dataGridPack.RowCount > 0)
            {
                buttonModify.Enabled = true;
                buttonDelete.Enabled = true;
                pictureReserver.Enabled = true;
            }
            else
            {
                buttonModify.Enabled = false;
                buttonDelete.Enabled = false;
                pictureReserver.Enabled = false;
            }
        }

        private void setListItemsOfPack(string namePack)
        {
            listBoxItemsOfPack.Items.Clear();
            List<Item> items = database.GetItemsInPackByName(namePack);

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
            if (Helper.existReservationPack(true, Convert.ToInt32(valPackId.Text)) == false)
            {
                WindowPack winpack = new WindowPack(valNamePack.Text, valDescription.Text, pan, this);
                winpack.ShowDialog(this);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (Helper.confirmation(Helper.DELETE) && (Helper.existReservationPack(true, Convert.ToInt32(valPackId.Text)) == false))
            {
                database.DeletePack(valNamePack.Text);
                setTablePacks(database.GetAllPacks());
                pan.setComboBoxPack();
            }
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            setTablePacks(database.GetAllPacksByString(textBoxSearch.Text));
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            setTablePacks(database.GetAllPacks());
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureReserver_Click(object sender, EventArgs e)
        {
            WindowReservation windowRes = new WindowReservation(this, Convert.ToInt32(valPackId.Text), true);
            windowRes.ShowDialog(this);
        }
        private void pictureReserver_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureReserver, "Réserver ce pack.");
            pictureReserver.Cursor = Cursors.Hand;
        }
    }
}

