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
        private int idUser;
        private List<string> materiels;

        public WindowReservationUser(int id)
        {
            InitializeComponent();
            idUser = id;
            materiels = new List<string>();
            setInfosUser();
        }

        private void setInfosUser()
        {
            User u = database.GetUserById(idUser);
            valNom.Text = u.name;
            valPrenom.Text = u.nickname;
            valClasse.Text = u.userClass.name;
            valCrédits.Text = u.credits.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            List<Item> list = Helper.getAllItemsDispoByDate(dateTimeBegin.Value.Date, dateTimeEnd.Value.Date);
            setTableItem(list);
            dataGridListeUser.Rows.Clear();
            materiels.Clear();
            calcul();
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

        private void buttonTransfert_Click(object sender, EventArgs e)
        {
            if(dataGridItem.RowCount > 0)
            {
                string libelle = dataGridItem.CurrentRow.Cells[0].Value.ToString();
                string prix = dataGridItem.CurrentRow.Cells[1].Value.ToString();
                if (!materiels.Contains(libelle))
                {
                    materiels.Add(libelle);
                    dataGridListeUser.Rows.Add(libelle, prix);
                }
                calcul();

            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un matériel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEnlever_Click(object sender, EventArgs e)
        {
            if(dataGridListeUser.RowCount > 0)
            {
                string libelle = dataGridListeUser.CurrentRow.Cells[0].Value.ToString();
                dataGridListeUser.Rows.Remove(dataGridListeUser.CurrentRow);
                materiels.Remove(libelle);
                calcul();
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un matériel à enlever.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcul()
        {
            double totalMateriels = 0;
            foreach(DataGridViewRow r in dataGridListeUser.Rows)
            {
                totalMateriels += double.Parse(r.Cells[1].Value.ToString());
            }
            valTotal.Text = totalMateriels.ToString();
            valCreditsRestants.Text = (double.Parse(valCrédits.Text) - totalMateriels).ToString();
        }
    }
}
