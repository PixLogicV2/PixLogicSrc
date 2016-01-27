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
using System.Configuration;
using System.IO;

namespace PixLogic
{
    public partial class WindowImport : Form
    {

        private int nbColumns;
        private Database database = Helper.database;
        private panUsers panU;
        private panItemPack panI;
        private List<string[]> informations;
        private List<Champs> listChamps;
        private List<int> indexWrongRows;
        DataGridView wrong = new DataGridView();
        DataGridView good = new DataGridView();
        private bool user;

        public WindowImport(panUsers p, panItemPack pi, List<Champs> c, bool u)
        {
            InitializeComponent();
            panU = p;
            panI = pi;
            listChamps = c;
            user = u;
            if (user)
            {
                Text = "Import - Utilisateurs";
                checkBoxForce.Visible = false;
            }
            else
            {
                Text = "Import - Matériels";
            }
            informations = new List<string[]>();
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
                informations = Helper.importCSV(valChemin, radioVirgule.Checked, radioYes.Checked);

                Cursor.Current = Cursors.Default;
            }
        }

        private void setTableImport(List<string[]> inf)
        {
            List<string[]> infos = inf;
            indexWrongRows = new List<int>();
            dataGridImport.Rows.Clear();

            int nbChampsTable = dataGridImport.ColumnCount;
            for (int i = 0; i < infos.Count; i++)
            {
                string[] info = new string[nbChampsTable];
                for(int j = 0; j < nbChampsTable; j++)
                {
                    if (infos.ElementAt(i).Count() > j)
                        info[j] = infos.ElementAt(i)[j];
                    else
                        info[j] = string.Empty;
                }
                dataGridImport.Rows.Insert(i, info);
                if (user)
                    checkRowUser(info);
                else
                    checkRowItem(info);
            }
            if (indexWrongRows.Count > 0)
            {
                MessageBox.Show("Il y'a " + indexWrongRows.Count + " lignes qui ne respectent pas les valeurs attendues.\nCes lignes ne seront pas importées.\n\nMerci de lire les valeurs attendues dans les informations sur l'import.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void checkRowUser(string[] info)
        {
            bool wrong = false;
            //Classe, Nom, Prénom, email, tel
            //Vérification des champs vides....
            int indexLastRow = dataGridImport.RowCount - 1;
            for (int i = 0; i < info.Count(); i++)
            {
                if(Helper.fieldsAreEmpty(false, info[i]) && (i < listChamps.Count(c => c.Oblige)))
                {
                    dataGridImport.Rows[indexLastRow].Cells[i].Style.BackColor = Color.Red;
                    wrong = true;
                }
            }
            //Vérification de l'existance de la classe...
            if(!Helper.userClassExist(false, info[0]))
            {
                dataGridImport.Rows[indexLastRow].Cells[0].Style.BackColor = Color.Red;
                wrong = true;
            }

            if(wrong)
                indexWrongRows.Add(indexLastRow);
        }

        private void checkRowItem(string[] info)
        {
            bool wrong = false;
            //Réf, Nom, Categorie, prix, qté, desc
            //Vérification des champs vides....
            int indexLastRow = dataGridImport.RowCount - 1;
            for (int i = 0; i < info.Count(); i++)
            {
                if (Helper.fieldsAreEmpty(false, info[i]) && (i < listChamps.Count(c => c.Oblige)))
                {
                    dataGridImport.Rows[indexLastRow].Cells[i].Style.BackColor = Color.Red;
                    wrong = true;
                }
            }

            //Vérification de l'existance de la référence...
            if (Helper.referenceExist(false, info[0]))
            {
                dataGridImport.Rows[indexLastRow].Cells[0].Style.BackColor = Color.Red;
                wrong = true;
            }

            //Vérification de l'existance de la catégorie...
            if (!Helper.categorieExist(false, info[2]))
            {
                dataGridImport.Rows[indexLastRow].Cells[2].Style.BackColor = Color.Red;
                wrong = true;
            }

            //Vérification du type nombre dans les champs concernés
            int valeur = 0;
            bool resultOfPrice = int.TryParse(info[3], out valeur);
            bool resultOfQty = int.TryParse(info[4], out valeur);

            if(!resultOfPrice)
            {
                dataGridImport.Rows[indexLastRow].Cells[3].Style.BackColor = Color.Red;
                wrong = true;
            }
            if (!resultOfQty)
            {
                dataGridImport.Rows[indexLastRow].Cells[4].Style.BackColor = Color.Red;
                wrong = true;
            }

            if (wrong)
                indexWrongRows.Add(indexLastRow);
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
            setTableImport(informations);
            valWrongLine.Text = indexWrongRows.Count + " / " + dataGridImport.Rows.Count;
            Cursor = Cursors.Default;
        }

        private void checkForceImport()
        {
            for(int i = 0; i < indexWrongRows.Count; i++)
            {
                if(dataGridImport.Rows[indexWrongRows.ElementAt(i)].Cells[2].Style.BackColor == Color.Red)
                {
                    if(nbOfWrong(dataGridImport.Rows[indexWrongRows.ElementAt(i)]) == 1)
                    {
                        string nomCat = dataGridImport.Rows[indexWrongRows.ElementAt(i)].Cells[2].Value.ToString();
                        database.AddCategorie(nomCat, 1, "Une description");
                        indexWrongRows.RemoveAt(i);
                    }
                }
            }
        }

        private int nbOfWrong(DataGridViewRow row)
        {
            int result = 0;
            foreach(DataGridViewCell c in row.Cells)
            {
                if (c.Style.BackColor == Color.Red)
                    result++;
            }
            return result;
        }

        private void buttonImporter_Click(object sender, EventArgs e)
        {
            if (checkBoxForce.Checked)
                checkForceImport();

            if (dataGridImport.Rows.Count > 0)
            {
                if(dataGridImport.Rows.Count == indexWrongRows.Count)
                {
                    MessageBox.Show("Il n'ya aucun élément à importer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool result = true;
                    if(indexWrongRows.Count > 0)
                    {
                        DialogResult resultBox = MessageBox.Show("Il ya des lignes erronées dans la liste d'éléments. Seules les lignes valides (ou celles repondant aux attentes du forcage) seront importées.\nVoulez-vous continuer l'import ?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        result = (resultBox == DialogResult.Yes) ? true : false;
                    }
                    

                    if(result)
                    {
                        Cursor = Cursors.WaitCursor;

                        if (user) //Classe, Nom, Prénom, email, tel
                        {
                            for (int i = 0; i < informations.Count; i++)
                            {
                                if (!indexWrongRows.Contains(i))
                                {
                                    string[] info = informations.ElementAt(i);

                                    UserClass classe = database.GetUserClassByName(info[0]);
                                    string nameUser = info[1];
                                    string nickNameUser = info[2];
                                    string email;
                                    string tel;
                                    try { email = info[3]; }catch(Exception ex) { email = ""; }
                                    try { tel = info[4]; } catch (Exception ex) { tel = ""; }

                                    Image img = Properties.Resources.noprofil;

                                    database.AddUser(nameUser, nickNameUser, email, tel, img, classe);
                                }
                            }
                        }
                        else //Réf, Nom, Categorie, prix, qté, desc
                        {
                            for (int i = 0; i < informations.Count; i++)
                            {
                                if (!indexWrongRows.Contains(i))
                                {
                                    string[] info = informations.ElementAt(i);

                                    string reference = info[0];
                                    string nameItem = info[1];
                                    Categorie categorie = database.GetCategorieByName(info[2]);
                                    Image img = Properties.Resources.noitem;
                                    int price = int.Parse(info[3]);
                                    int qte = int.Parse(info[4]);
                                    bool dispo = true;
                                    string desc;
                                    try { desc = info[4]; } catch (Exception ex) { desc = ""; }

                                    database.AddItem(nameItem, desc, dispo, price, img, reference, qte, categorie);
                                }

                            }
                        }

                        Cursor = Cursors.Default;
                        MessageBox.Show("La liste a été bien importée.");
                        if (user)
                            panU.setTableUsers(database.GetAllUsers());
                        else
                            panI.setTableItem(database.GetAllItems());
                        generateFiles();
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
                string info = "- Catégorie : \n\t* Vous devez préalablement créer les catégories avec les noms indiqués dans votre fichier si celles-ci n'existent pas. Celles-ci peuvent aussi être importées par le forcage.";
                info += "\n\t* La valeur du nom de la catégorie dans votre fichier doit être non nul.";
                info += "\n\n- Nom du matériel et Référence : \n\t* Le nom et la référence de chaque matériel doivent être non nuls. La référence doit être unique.";
                info += "\n\n- Prix et Quantité : \n\t* Le prix et la quantité de chaque matériel doivent être des entiers non nuls.";
                info += "\n\n Autres champs : \n\t* Les autres champs sont facultatifs.";
                info += "\n\n Forcer l'import : \n\t* les lignes qui pourront être forcées seront des lignes qui n'auront pour défaut que leur champs catégorie.";
                MessageBox.Show(info, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void generateFiles()
        {
            wrong = new DataGridView();
            good = new DataGridView();

            int num = 0;
            foreach(DataGridViewColumn c in dataGridImport.Columns)
            {
                wrong.Columns.Add("w"+num, c.HeaderText);
                good.Columns.Add("g"+num, c.HeaderText);
                num++;
            }

            for(int i = 0; i < dataGridImport.RowCount; i++)
            {
                string[] info = new string[dataGridImport.Rows[i].Cells.Count];
                for (int j = 0; j < dataGridImport.Rows[i].Cells.Count; j++)
                {
                    info[j] = dataGridImport.Rows[i].Cells[j].Value.ToString();
                }

                if (indexWrongRows.Contains(i))
                {
                    wrong.Rows.Add(info);
                }
                else
                {
                    good.Rows.Add(info);
                }
            }
            
            try
            {

                string nomRepPrinc;
                if(user)
                    nomRepPrinc = ConfigurationManager.AppSettings["nomRepImportUser"];
                else
                    nomRepPrinc = ConfigurationManager.AppSettings["nomRepImportItem"];

                if (!Directory.Exists(nomRepPrinc))
                    Directory.CreateDirectory(nomRepPrinc);

                string nomRepCourant = Path.Combine(nomRepPrinc, DateTime.Now.ToString("dd MMM yyyy. HH-mm-ss"));
                if (!Directory.Exists(nomRepCourant))
                    Directory.CreateDirectory(nomRepCourant);

                string nomWrongFile = ConfigurationManager.AppSettings["nomMauvaisFichier"];
                string nomGoodFile = ConfigurationManager.AppSettings["nomBonFichier"];

                string pathWrong = nomRepCourant + "\\" + nomWrongFile + ".csv";
                string pathGood = nomRepCourant + "\\" + nomGoodFile + ".csv"; ;

                Helper.exportCSV(wrong, pathWrong);
                Helper.exportCSV(good, pathGood);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
