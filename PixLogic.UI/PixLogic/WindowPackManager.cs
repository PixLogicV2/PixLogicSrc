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

        public WindowPackManager(panItemPack p)
        {
            InitializeComponent();
            pan = p;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WindowPack winpack = new WindowPack(pan, this);
            winpack.ShowDialog(this);
        }

        public void setTableItem(List<Pack> l)
        {
            List<Pack> list = l;
            dataGridPack.Rows.Clear();
            foreach (var pack in list)
            {
                dataGridPack.Rows.Add(pack.name, pack.price, pack.dispo?"OUI":"NON");
            }
            
            if (dataGridPack.RowCount > 0)
            {
                dataGridPack.FirstDisplayedScrollingRowIndex = 0;
                dataGridPack.Refresh();
                dataGridPack.CurrentCell = dataGridPack.Rows[0].Cells[0];
                dataGridPack.Rows[0].Selected = true;

                //setNewsItem();
            }

        }

        /*private void setNewsItem()
        {
            valItemName.Text = dataGridItem.CurrentRow.Cells[0].Value.ToString();
            valQuantity.Text = dataGridItem.CurrentRow.Cells[1].Value.ToString();
            valPrice.Text = dataGridItem.CurrentRow.Cells[2].Value.ToString();
            Item item = database.GetItemByName(valItemName.Text);
            valDispo.Text = item.dispo ? "OUI" : "NON";
            valDescription.Text = item.description;

            Image img = database.ByteArrayToImage(item.image);
            pictureBoxItem.Image = img;
            if (img != null)
            {
                if (img.Size.Height < pictureBoxItem.Size.Height
                    && img.Size.Width < pictureBoxItem.Size.Width)
                    pictureBoxItem.SizeMode = PictureBoxSizeMode.CenterImage;
                else
                    pictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
            }*/

        }
    }

