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
            foreach(Item i in list)
            {
                if (i.categorie.level > (database.GetUserById(idUser).userClass.level)) list.Remove(i);
            }
            setTableItem(list);
            dataGridListeItem.Rows.Clear();
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

        private void setTableListItems(Dictionary<string, int> entrees)
        {
            dataGridListeItem.Rows.Clear();

            foreach (KeyValuePair<string, int> e in entrees)
            {
                dataGridListeItem.Rows.Add(e.Key, e.Value);
            }

            if (dataGridListeItem.RowCount > 0)
            {
                dataGridListeItem.FirstDisplayedScrollingRowIndex = 0;
                dataGridListeItem.Refresh();
                dataGridListeItem.CurrentCell = dataGridListeItem.Rows[0].Cells[0];
                dataGridListeItem.Rows[0].Selected = true;
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
                int selectedRowCount = dataGridItem.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    List<string> items = new List<string>();
                    for (int i = selectedRowCount - 1; i >= 0; i--)
                    {
                        string libelle = dataGridItem.SelectedRows[i].Cells[0].Value.ToString();
                        string prix = dataGridItem.SelectedRows[i].Cells[1].Value.ToString();
                        if (!materiels.Contains(libelle))
                        {
                            materiels.Add(libelle);
                            dataGridListeItem.Rows.Add(libelle, prix);
                        }
                    }
                    
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
            if(dataGridListeItem.RowCount > 0)
            {
                Dictionary<string, int> entrees = new Dictionary<string, int>();
                foreach (DataGridViewRow r in dataGridListeItem.Rows)
                {
                    string libelle = r.Cells[0].Value.ToString();
                    int credits = int.Parse(r.Cells[1].Value.ToString());
                    if (r.Selected)
                    {
                        materiels.Remove(libelle);
                    }
                    else
                    {
                        entrees.Add(libelle, credits);
                    }
                }
                setTableListItems(entrees);

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
            foreach(DataGridViewRow r in dataGridListeItem.Rows)
            {
                totalMateriels += double.Parse(r.Cells[1].Value.ToString());
            }
            valTotal.Text = totalMateriels.ToString();
            valCreditsRestants.Text = (double.Parse(valCrédits.Text) - totalMateriels).ToString();
        }
        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (dataGridListeItem.Rows.Count == 0)
            {
                MessageBox.Show("Aucun matériel n'est désigné!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!radioButtonReserver.Checked && !radioButtonEmprunter.Checked)
            {
                MessageBox.Show("Vous devez choisir l'opération (Reservation ou Emprunt) à effectuer sur la liste des matériels!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(valCreditsRestants.Text) >= 0)
            {
                User user = database.GetUserById(idUser);

                if (radioButtonReserver.Checked && Helper.confirmationReservation(Helper.ADD))
                {
                    createPackEph(true);
                    this.Close();
                }

                else if (radioButtonEmprunter.Checked && Helper.confirmationEmpruntDirectPack(user))
                {
                    createPackEph(false);
                    this.Close();
                }
            }
            else MessageBox.Show("Credits insuffisants", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void createPackEph(bool reserv)
        {
            int last = database.GetLastPackId();
            database.AddPack("[Eph]. Pack " + Convert.ToString(last + 1), "reservation de " + valNom.Text, false, 0, true);
            Pack pack = database.GetPackById(last + 1);
            for (int i = 0; i < dataGridListeItem.Rows.Count; i++)
            {
                database.AddItemToPack(dataGridListeItem.Rows[i].Cells[0].Value.ToString(), pack.name);
            }

            if(reserv)
                database.AddReservation(true, dateTimeBegin.Value.Date, dateTimeEnd.Value.Date, null, null, database.GetUserById(idUser), pack, null);
            else
                database.AddReservation(true, null, null, dateTimeBegin.Value.Date, dateTimeEnd.Value.Date, database.GetUserById(idUser), pack, null);
        }
    }
}
