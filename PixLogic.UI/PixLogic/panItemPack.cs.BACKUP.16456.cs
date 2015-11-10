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
<<<<<<< HEAD
        ServiceContainer container = new ServiceContainer();
=======
        Database database = new Database();
>>>>>>> cf11b349cb06fa96e0a43aa1fc07fd5c6283152a
        public panItemPack()
        {
            InitializeComponent();
            setTableItem();
            setComboBoxPack();
        }

        public void setTableItem()
        {
            List<Item> list = database.GetAllItems();
            foreach(var item in list)
            {
                dataGridItem.Rows.Add(item.name, item.quantity, item.price);
            }

            //AJOUT DES ELEMENTS DANS DATAGRIDVIEW
            /*for(int i = 1; i < 5; i++)
            {
                dataGridItem.Rows.Add("Matériel " + i, i * 5, 1.25 * i);
            }*/

            if(dataGridItem.RowCount > 0)
            {
                dataGridItem.FirstDisplayedScrollingRowIndex = 0;
                dataGridItem.Refresh();
                dataGridItem.CurrentCell = dataGridItem.Rows[0].Cells[0];
                dataGridItem.Rows[0].Selected = true;

                setNewsItem();
            }
            
        }

        private void setNewsItem()
        {
            valItemName.Text = dataGridItem.CurrentRow.Cells[0].Value.ToString();
            valQuantity.Text = dataGridItem.CurrentRow.Cells[1].Value.ToString();
            valPrice.Text = dataGridItem.CurrentRow.Cells[2].Value.ToString();
        }
        
        private void setComboBoxPack()
        {
            comboBoxPack.Items.Clear();

            //AJOUT DES ELEMENTS DANS LA COMBOBOX
            for (int i = 0; i < 4; i++)
                comboBoxPack.Items.Add("Pack " + i);

            comboBoxPack.SelectedIndex = 0;
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
            listBoxItem.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
        }

        private void dataGridItem_Click(object sender, EventArgs e)
        {
            setNewsItem();
        }

        private void dataGridItem_KeyUp(object sender, KeyEventArgs e)
        {
            setNewsItem();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            WindowItem modif = new WindowItem("", valItemName.Text, Convert.ToDouble(valPrice.Text), Convert.ToInt32(valQuantity.Text), valDescription.Text);
            modif.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce matériel ?",
                "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                //...
            }
        }

        private void buttonManagePack_Click(object sender, EventArgs e)
        {
            WindowPackManager manager = new WindowPackManager();
            manager.ShowDialog();
        }

        private void buttonTransfert_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Add(valItemName.Text);
        }
    }
}
