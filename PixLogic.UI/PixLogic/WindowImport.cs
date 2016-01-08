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
        private panUsers pan;
        private List<User> users;
        private List<Item> items;
        private List<Champs> listChamps;
        private List<int> indexWrongRows;
        private bool user;

        public WindowImport(panUsers p, List<Champs> c, bool u)
        {
            InitializeComponent();
            pan = p;
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
        }

        private void setTableChamps()
        {
            dataGrid.Rows.Clear();

            foreach(Champs champ in listChamps)
            {
                dataGrid.Rows.Add(champ.Nom, champ.Coche);
                if (!champ.Oblige)
                    dataGrid.Rows[dataGrid.Rows.Count - 1].Cells[dataGrid.ColumnCount - 1].ReadOnly = false;
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
                if (user)
                    users = Helper.importCSVuser(valChemin.Text, radioVirgule.Checked, radioYes.Checked);
                else
                    items = Helper.importCSVitem(valChemin.Text, radioVirgule.Checked, radioYes.Checked);
            }
        }

        private void setTableImportUser(List<User> us)
        {
            List<User> users = us;
            indexWrongRows = new List<int>();
            dataGridImport.Rows.Clear();
            if (dataGridImport.Columns.Count < nbColumns)
            {
                foreach (User u in users)
                {
                    if (dataGridImport.Columns.Count == 3)
                    {
                        dataGridImport.Rows.Add(u.userClass.name, u.name, u.nickname);
                    }
                    else if (dataGridImport.Columns.Count == 4)
                    {
                        dataGridImport.Rows.Add(u.userClass.name, u.name, u.nickname, u.mail, u.phoneNumber);
                    }
                    if (rowUserIsCorrect(u.userClass.name, u.name, u.nickname))
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
                    else
                    {
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                        indexWrongRows.Add(dataGridImport.Rows[dataGridImport.RowCount - 1].Index);
                    }
                }

                if(indexWrongRows.Count > 0)
                {
                    MessageBox.Show("Il y'a "+indexWrongRows.Count+" lignes qui ne respectent pas les valeurs attendues.\nCes lignes ne seront pas importées.\n\nMerci de lire les valeurs attendues dans les informations sur l'import.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                foreach (User u in users)
                {
                    dataGridImport.Rows.Add(u.userClass.name, u.name, u.nickname, u.mail, u.phoneNumber);
                    Console.WriteLine("Dans le else");
                }
            }
            //dataGridImport.Rows[]
            

        }

        private void setTableImportItem(List<Item> i)
        {
            List<Item> items = i;
            indexWrongRows = new List<int>();
            dataGridImport.Rows.Clear();
            if (dataGridImport.Columns.Count < nbColumns)
            {
                foreach (Item u in items)
                {
                    if (dataGridImport.Columns.Count == 5)
                    {
                        dataGridImport.Rows.Add(u.reference, u.name, u.categorie.name, u.price, u.quantity);
                    }
                    if (rowItemIsCorrect(u.reference, u.name, u.categorie.name))
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.White;
                    else
                    {
                        dataGridImport.Rows[dataGridImport.RowCount - 1].DefaultCellStyle.BackColor = Color.Red;
                        indexWrongRows.Add(dataGridImport.Rows[dataGridImport.RowCount - 1].Index);
                    }
                }

                if (indexWrongRows.Count > 0)
                {
                    MessageBox.Show("Il y'a " + indexWrongRows.Count + " lignes qui ne respectent pas les valeurs attendues.\nCes lignes ne seront pas importées.\n\nMerci de lire les valeurs attendues dans les informations sur l'import.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                foreach (Item u in items)
                {
                    dataGridImport.Rows.Add(u.reference, u.name, u.categorie.name, u.price, u.quantity, u.description);
                }
            }
            //dataGridImport.Rows[]


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
                
        }

        private void buttonImporter_Click(object sender, EventArgs e)
        {
            if(dataGridImport.Columns.Count < nbColumns)
            {
                UserClass classe = new UserClass();
                for (int i = 0; i < dataGridImport.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridImport.Rows[i];
                    classe = database.GetUserClassByName(row.Cells[2].Value.ToString());
                    Image img = Properties.Resources.noprofil;
                    database.AddUser(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), "", img, classe);
                }
            }
            else if(dataGridImport.Columns.Count == nbColumns)
            {
                for(int i = 0; i < dataGridImport.Rows.Count-1; i++)
                {
                    DataGridViewRow row = dataGridImport.Rows[i];
                    UserClass userClass = database.GetUserClassByName(row.Cells[2].Value.ToString());

                    Image img = Properties.Resources.noprofil;
                    database.AddUser(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), img, userClass);

                }
            }

            MessageBox.Show("La liste a été bien importée.");
            try
            {
                pan.setTableUsers(database.GetAllUsers());
            }catch(Exception ex) { }
            this.Close();
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
                info += "\n\t* La valeur du nom de la classe doit être non nul.";
                info += "\n\n- Nom et Prénom : \n\t* Le nom et le prénom de chaque utilisateur doivent être non nuls.";
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
