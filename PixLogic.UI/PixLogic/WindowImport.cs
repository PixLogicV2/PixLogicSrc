using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using PixLogic.DAL;

namespace PixLogic
{
    public partial class WindowImport : Form
    {

        private int nbColumns;
        private Database database = Helper.database;
        private panUsers panU;
        private panItemPack panI;
        private List<User> users;
        private List<Item> items;
        private List<Champs> listChamps;
        private List<int> indexWrongRows;
        private bool user;

        public WindowImport(panUsers p, panItemPack pi, List<Champs> c, bool u)
        {
            InitializeComponent();
            panU = p;
            panI = pi;
            listChamps = c;
            user = u;
            if (user)
                users = new List<User>();
            else
                items = new List<Item>();

            indexWrongRows = new List<int>();
            init();
            setTableChamps();
        }
        public WindowImport()
        {
            InitializeComponent();
            init();
            setTableChamps();
        }

        private void init()
        {
            radioPointVirgule.Checked = true;
            radioYes.Checked = true;
            if (user)
                valImport.Text = "Import d'utilisateurs";
            else
                valImport.Text = "Import de matériels";
        }

        private void setTableChamps()
        {
            dataGrid.Rows.Clear();

            foreach(Champs champ in listChamps)
            {
                dataGrid.Rows.Add(champ.Nom, champ.Coche);
                if (!champ.Oblige)
                    dataGrid.Rows[dataGrid.Rows.Count - 1].Cells[dataGrid.ColumnCount - 1].ReadOnly = false;
                else
                {
                    dataGrid.Rows[dataGrid.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Aquamarine;
                    dataGrid.Rows[dataGrid.Rows.Count - 1].Cells[dataGrid.ColumnCount - 1].ReadOnly = true;
                }
            }

            //--------------------
            nbColumns = listChamps.Count;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = ".csv";
            openFileDialog.Filter = "Csv documents|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                valChemin.Text = openFileDialog.FileName;
                Cursor.Current = Cursors.WaitCursor;
                if (user)
                    users = Helper.importCSVuser(valChemin, radioVirgule.Checked, radioYes.Checked);
                else
                    items = Helper.importCSVitem(valChemin, radioVirgule.Checked, radioYes.Checked);

                Cursor.Current = Cursors.Default;
            }
        }

        private void setTableImportUser(List<User> us)
        {
            List<User> users = us;
            indexWrongRows = new List<int>();
            dataGridImport.Rows.Clear();
            if (dataGridImport.Columns.Count < nbColumns)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    User u = users.ElementAt(i);
                    if (dataGridImport.Columns.Count == 3)
                    {
                        dataGridImport.Rows.Add(u.userClass.name, u.name, u.nickname);
                    }
                    else if (dataGridImport.Columns.Count == 4)
                    {
                        dataGridImport.Rows.Add(u.userClass.name, u.name, u.nickname, u.mail);
                    }
                    if (rowUserIsCorrect(u.userClass.name, u.name, u.nickname))
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
                    else
                    {
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                        indexWrongRows.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < users.Count; i++)
                {
                    User u = users.ElementAt(i);
                    dataGridImport.Rows.Add(u.userClass.name, u.name, u.nickname, u.mail, u.phoneNumber);
                    if (rowUserIsCorrect(u.userClass.name, u.name, u.nickname))
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
                    else
                    {
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                        indexWrongRows.Add(i);
                    }
                }
            }

            if (indexWrongRows.Count > 0)
            {
                MessageBox.Show("Il y'a " + indexWrongRows.Count + " lignes qui ne respectent pas les valeurs attendues.\nCes lignes ne seront pas importées.\n\nMerci de lire les valeurs attendues dans les informations sur l'import.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void setTableImportItem(List<Item> it)
        {
            List<Item> items = it;
            indexWrongRows = new List<int>();
            dataGridImport.Rows.Clear();
            if (dataGridImport.Columns.Count < nbColumns)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Item u = items.ElementAt(i);
                    if (dataGridImport.Columns.Count == 5)
                    {
                        dataGridImport.Rows.Add(u.reference, u.name, u.categorie.name, u.price, u.quantity);
                    }
                    if (rowItemIsCorrect(u.reference, u.name, u.categorie.name))
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
                    else
                    {
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                        indexWrongRows.Add(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Item u = items.ElementAt(i);
                    dataGridImport.Rows.Add(u.reference, u.name, u.categorie.name, u.price, u.quantity, u.description);
                    if (rowItemIsCorrect(u.reference, u.name, u.categorie.name))
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
                    else
                    {
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                        indexWrongRows.Add(i);
                    }
                }
            }

            if (indexWrongRows.Count > 0)
            {
                MessageBox.Show("Il y'a " + indexWrongRows.Count + " lignes qui ne respectent pas les valeurs attendues.\nCes lignes ne seront pas importées.\n\nMerci de lire les valeurs attendues dans les informations sur l'import.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool rowUserIsCorrect(string classe, string nom, string prenom)
        {
            bool result = true;

            if (Helper.fieldsAreEmpty(false, classe, nom, prenom))
                return false;
            if (!Helper.userClassExist(false, classe))
                return false;

            return result;
        }
        private bool rowItemIsCorrect(string reference, string nom, string categorie)
        {
            bool result = true;

            if (Helper.fieldsAreEmpty(false, reference, nom, categorie))
                return false;
            if (!Helper.categorieExist(false, categorie))
                return false;

            return result;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(valChemin.Text.Equals(string.Empty))
            {
                MessageBox.Show("Vous devez sélectionner le fichier source (.csv) pour l'import.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor = Cursors.WaitCursor;
            dataGridImport.Rows.Clear();
            dataGridImport.Columns.Clear();
            int i = 0;
            foreach(DataGridViewRow row in dataGrid.Rows)
            {
                if(Convert.ToBoolean(row.Cells[1].Value) == true)
                {
                    dataGridImport.Columns.Add("c"+i, row.Cells[0].Value.ToString());
                }
                i++;
            }
            if (user)
                setTableImportUser(users);
            else
                setTableImportItem(items);

            valWrongLine.Text = indexWrongRows.Count + " / " + dataGridImport.Rows.Count;
            Cursor = Cursors.Default;
        }

        private void buttonImporter_Click(object sender, EventArgs e)
        {
            if(dataGridImport.Rows.Count > 0)
            {
                if(dataGridImport.Rows.Count == indexWrongRows.Count)
                {
                    MessageBox.Show("Il n'ya aucun élément à importer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool result = false;
                    DialogResult resultBox = MessageBox.Show("Il ya des lignes erronées dans la liste d'éléments. Seules les lignes valides seront importées.\nVoulez-vous continuer l'import ?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    result = (resultBox == DialogResult.Yes) ? true : false;

                    if(result)
                    {
                        Cursor = Cursors.WaitCursor;
                        if (user)
                        {
                            for (int i = 0; i < users.Count; i++)
                            {
                                if (!indexWrongRows.Contains(i))
                                {
                                    User u = users.ElementAt(i);
                                    Image img = Properties.Resources.noprofil;
                                    u.userClass = database.GetUserClassByName(u.userClass.name);
                                    if (dataGridImport.ColumnCount == 3)
                                    {
                                        u.mail = "";
                                        u.phoneNumber = "";
                                    }
                                    else if (dataGridImport.ColumnCount == 4)
                                        u.phoneNumber = "";

                                    database.AddUser(u.name, u.nickname, u.mail, u.phoneNumber, img, u.userClass);
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < items.Count; i++)
                            {
                                if (!indexWrongRows.Contains(i))
                                {
                                    Item u = items.ElementAt(i);
                                    Image img = Properties.Resources.noitem;
                                    u.categorie = database.GetCategorieByName(u.categorie.name);
                                    if (dataGridImport.ColumnCount == 5)
                                        u.description = "";
                                    u.dispo = true;
                                    database.AddItem(u.name, u.description, u.dispo, u.price, img, u.reference, u.quantity, u.categorie);
                                }

                            }
                        }

                        Cursor = Cursors.Default;
                        MessageBox.Show("La liste a été bien importée.");
                        if (user)
                            panU.setTableUsers(database.GetAllUsers());
                        else
                            panI.setTableItem(database.GetAllItems());
                        this.Close();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Il n'ya aucun élément à importer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void pictureBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(pictureBoxInfo, "Information sur l'import");
            pictureBoxInfo.Cursor = Cursors.Hand;
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            if(user)
            {
                string info = "- Classe : \n\t* Vous devez préalablement créer les classes avec les noms indiqués dans votre fichier si celles-ci n'existent pas.";
                info += "\n\t* La valeur du nom de la classe dans votre fichier doit être non nul.";
                info += "\n\n- Nom et Prénom : \n\t* Le nom et le prénom de chaque utilisateur doivent être non nuls.";
                info += "\n\n Autres champs : \n\t* Les autres champs sont facultatifs.";
                MessageBox.Show(info, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string info = "- Catégorie : \n\t* Vous devez préalablement créer les catégories avec les noms indiqués dans votre fichier si celles-ci n'existent pas.";
                info += "\n\t* La valeur du nom de la catégorie dans votre fichier doit être non nul.";
                info += "\n\n- Nom du matériel et Référence : \n\t* Le nom et la référence de chaque matériel doivent être non nuls.";
                info += "\n\n- Prix et Quantité : \n\t* Le prix et la quantité de chaque matériel doivent être des entiers non nuls.";
                info += "\n\n Autres champs : \n\t* Les autres champs sont facultatifs.";
                MessageBox.Show(info, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
