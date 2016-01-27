using iTextSharp.text;
using iTextSharp.text.pdf;
using PixLogic.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using System.Security.Cryptography;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;

namespace PixLogic
{
    class Helper
    {
        public static Database database = new Database();
        public static Manager manager = new Manager();
        public static readonly string ADD = "ajouter";
        public static readonly string DELETE = "supprimer";
        public static readonly string SET = "modifier";
        public static readonly string REMOVE = "enlever";
        public static readonly string CANCEL = "annuler";
        public static readonly string PACK = "Pack";
        public static readonly string ITEM = "Matériel";
        public static bool CLOSING;

        public static void help()
        {
            database.AddUserClass("1EREA", 20, 5);
            database.AddUserClass("TER B", 20, 5);
        }

        public static bool fieldsAreEmpty(bool withMessageBox, params string[] args)
        {
            bool result = false;

            foreach(string field in args)
            {
                if(field.Equals(""))
                {
                    result = true;
                    if(withMessageBox)
                        MessageBox.Show("Tous les champs obligatoires (*) n'ont pas été rempli.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return result;
        }

        public static bool beginBeforeEndDate(bool withMessageBox, DateTime begin, DateTime end)
        {
            if (begin.CompareTo(end) <= 0)
                return true;
            else
            {
                if(withMessageBox)
                    MessageBox.Show("La date de debut est supérieure à celle de fin.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        public static bool IsInListBox(string refItem, int idPack)
        {
            List<Item> items = database.GetItemsInPack(idPack);
            foreach(Item it in items)
            {
                if (it.reference.Equals(refItem))
                    return true;
            }

            return false;
        }

        public static bool AreNumbers(bool withMessageBox, params string[] args)
        {
            bool result = true;
            double nombre;

            foreach(string num in args)
            {
                if(!double.TryParse(num, out nombre))
                {
                    result = false;
                    if(withMessageBox)
                        MessageBox.Show("Vous avez renseigné un texte dans un champs de type nombre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return result;
        }

        public static bool confirmation(string op)
        {
            bool result = false;
            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment "+op+" cet élément ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }
        public static bool confirmationReservation(string op)
        {
            bool result = false;
            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment " + op + " cette réservation ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }
        public static bool confirmationManager(string op)
        {
            bool result = false;
            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment " + op + " ce manager ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }

        public static bool confirmationEmprunt(int idReservation)
        {
            bool result = false;
            Reservation reservation = database.GetReservationById(idReservation);
            string nameReservable = reservation.reservable.name;
            string user = reservation.user.name +" "+ reservation.user.nickname;

            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment prêter l'élément " + nameReservable.ToUpper() + " à l'utilisateur "+user.ToUpper()+" ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }

        public static bool confirmationEmpruntDirectPack(User user)
        {
            bool result = false;
            string u = user.name + " " + user.nickname;

            DialogResult resultBox = MessageBox.Show("Voulez-vous vraiment prêter le pack à l'utilisateur " + u.ToUpper() + " ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }

        public static bool getDispoReservable(int idElement, bool isPack)
        {
            if (isPack == false)
            {
                Item elem;
                elem = database.GetItemById(idElement);
                if (elem.dispo == false) MessageBox.Show("matériel indisponible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return elem.dispo;
            }
            else
            {
                Pack p;
                p = database.GetPackById(idElement);
                if (p.dispo == false) MessageBox.Show("pack indisponible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return p.dispo;
            }
        }

        public static bool confirmationRemise(int idReservation)
        {
            bool result = false;
            Reservation reservation = database.GetReservationById(idReservation);
            string nameReservable = reservation.reservable.name;
            string type = reservation.isPack ? PACK : ITEM;
            string user = reservation.user.name + " " + reservation.user.nickname;

            DialogResult resultBox = MessageBox.Show("Rendre le " + type.ToLower() + " "+nameReservable.ToUpper()+" emprunté par l'utilisateur " + user.ToUpper() + " ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            result = (resultBox == DialogResult.Yes) ? true : false;

            return result;
        }


        public static void addSuccess()
        {
            MessageBox.Show("L'élément a été bien ajouté !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool itemExist(bool withMessageBox, string name)
        {
            if(database.ContainItem(name))
            {
                if(withMessageBox)
                    MessageBox.Show("Le nom du matériel renseigné existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
                
        }

        public static bool categorieExist(bool withMessageBox, string name)
        {
            if (database.ContainCategorie(name))
            {
                if (withMessageBox)
                    MessageBox.Show("Le nom de la catégorie renseigné existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }

        public static bool userClassExist(bool withMessageBox, string name)
        {
            if (database.ContainUserClass(name))
            {
                if (withMessageBox)
                    MessageBox.Show("Le nom de la classe renseigné existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }
        public static bool referenceExist(bool withMessageBox, string name)
        {
            if (database.ExistReference(name))
            {
                if (withMessageBox)
                    MessageBox.Show("La référence entrée existe déjà.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }
        public static bool ManagerExist(bool withMessageBox, string pseudo)
        {
            if (database.ContainPseudoManager(pseudo))
            {
                if (withMessageBox)
                    MessageBox.Show("Le pseudo choisi existe déjà, veuillez renseigner un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }
        public static bool ManagerExistModif(bool withMessageBox, int idM, string newPseudo)
        {
            Manager m = database.GetManagerById(idM);
            if (database.ContainItem(newPseudo) && !newPseudo.Equals(m.pseudo))
            {
                if (withMessageBox)
                    MessageBox.Show("Le pseudo choisi existe déjà, veuillez renseigner un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }

        public static bool itemExistModif(bool withMessageBox, string name, string oldName)
        {
            if (database.ContainItem(name) && !name.Equals(oldName))
            {
                if (withMessageBox)
                    MessageBox.Show("Le nom du matériel renseigné existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }

        public static bool referenceExistModif(bool withMessageBox, string name, string oldName)
        {
            if (database.ExistReference(name) && !name.Equals(oldName))
            {
                if (withMessageBox)
                    MessageBox.Show("La référence entrée existe déjà.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }

        public static bool categorieExistModif(bool withMessageBox, string name, string oldName)
        {
            if (database.ContainItem(name) && !name.Equals(oldName))
            {
                if (withMessageBox)
                    MessageBox.Show("Le nom de la catégorie renseignée existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }
        public static bool userClassExistModif(bool withMessageBox, string name, string oldName)
        {
            if (database.ContainItem(name) && !name.Equals(oldName))
            {
                if (withMessageBox)
                    MessageBox.Show("Le nom de la classe renseignée existe déjà !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }
        public static void putImageInBox(PictureBox picBox, System.Drawing.Image image)
        {
            picBox.Image = image;
            if (image != null)
            {
                if (image.Size.Height < picBox.Size.Height
                    && image.Size.Width < picBox.Size.Width)
                    picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                else
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        /*
        public static void testApp()
        {
            foreach (var item in database.GetAllItems())
            {
                database.DeleteItem(item.name);
            }
           for (int i = 0; i < 2000; i++)
            {
                database.AddItem("NameItem " + i, "Description " + i, true, (i * 0.8f), Properties.Resources.camera_photo, "Reference " + 1, i + 1);
            }
        }
        */

        public static bool reservationStartMinimumToday(bool withMessageBox, DateTime debut)
        {
            if (DateTime.Today <= debut.Date)
                return true;
            else
            {
                MessageBox.Show("La date de debut de reservation est inférieur à la date d'aujourdhui.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool isDispo(bool withMessageBox,Reservation reservation,DateTime dateDebut,DateTime dateFin)
        {
            if ((reservation.endDateReservation.Value.Date < dateDebut.Date) || 
                (reservation.beginDateReservation.Value.Date > dateFin.Date)/* ||
                (reservation.endDateReservation.Value.Date>=dateDebut.Date && reservation.endDateReservation.Value.Date<=dateFin.Date) ||
                (reservation.beginDateReservation.Value.Date >= dateDebut.Date && reservation.beginDateReservation.Value.Date <= dateFin.Date)*/)
            {
                return true;
            }
            return false;
        }
        public static bool isDispoEmprunt(bool withMessageBox, Reservation reservation, DateTime dateDebut, DateTime dateFin)
        {
            if ((reservation.endDateEmprunt.Value.Date <dateDebut.Date) ||
                (reservation.beginDateEmprunt.Value.Date > dateFin.Date)/* ||
                (reservation.endDateReservation.Value.Date>=dateDebut.Date && reservation.endDateReservation.Value.Date<=dateFin.Date) ||
                (reservation.beginDateReservation.Value.Date >= dateDebut.Date && reservation.beginDateReservation.Value.Date <= dateFin.Date)*/)
            {
                return true;
            }
           
            return false;
        }
        public static bool existReservation(int idReservable,DateTime dateDebut,DateTime dateFin)
        {
            List<Reservation> reservations = database.GetAllReservationsByReservableId(idReservable);
            foreach (Reservation reservation in reservations)
            {
                if (isDispo(true, reservation, dateDebut, dateFin) == false)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool existEmprunt(int idReservable,DateTime dateDebut,DateTime dateFin)
        {
            List<Reservation> emprunts = database.GetAllEmpruntsByReservableId(idReservable);
            foreach (Reservation emprunt in emprunts)
            {
                if (isDispoEmprunt(true, emprunt, dateDebut, dateFin) == false)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool getDispoReservableByDate(bool withMessageBox, int idReservable, DateTime dateDebut,DateTime dateFin)
        {
            if (existReservation(idReservable, dateDebut, dateFin))
            {
                if(withMessageBox)MessageBox.Show("Une reservation est deja présente à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (existEmprunt(idReservable, dateDebut, dateFin))
            {
                if (withMessageBox) MessageBox.Show("Un Emprunt est deja présent à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Reservable res = database.GetReservableById(idReservable);
            if (res.isPack == true)
                {
                    List<Item> items = database.GetItemsInPack(res.ReservableId);
                    foreach (Item i in items)
                    {
                    if (existReservation(i.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("Un matériel du pack est réservé à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (existEmprunt(i.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("un matériel du pack est emprunté à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    }
                }
            if (res.isPack == false)
                {
                    Item i = database.GetItemById(res.ReservableId);
                    if (i.pack != null)
                    {
                    if (existReservation(i.pack.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("Un pack contenant ce matériel est déjà reservé à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (existEmprunt(i.pack.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("Un pack contenant ce matériel est déjà emprunté à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    }
                }
            return true;     
        }
        public static int getDispoReservableByDateCalendar(bool withMessageBox, int idReservable, DateTime dateDebut, DateTime dateFin)
        {
            if (existReservation(idReservable, dateDebut, dateFin))
            {
                if (withMessageBox) MessageBox.Show("Une reservation est deja présente à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (existEmprunt(idReservable, dateDebut, dateFin))
            {
                if (withMessageBox) MessageBox.Show("Un Emprunt est deja présent à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            Reservable res = database.GetReservableById(idReservable);
            if (res.isPack == true)
            {
                List<Item> items = database.GetItemsInPack(res.ReservableId);
                foreach (Item i in items)
                {
                    if (existReservation(i.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("Un matériel du pack est réservé à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                    if (existEmprunt(i.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("un matériel du pack est emprunté à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 2;
                    }
                }
            }
            if (res.isPack == false)
            {
                Item i = database.GetItemById(res.ReservableId);
                if (i.pack != null)
                {
                    if (existReservation(i.pack.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("Un pack contenant ce matériel est déjà reservé à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                    if (existEmprunt(i.pack.ReservableId, dateDebut, dateFin))
                    {
                        if (withMessageBox) MessageBox.Show("Un pack contenant ce matériel est déjà emprunté à cette date.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 2;
                    }
                }
            }
            return 0;
        }
        public static List<Item> getAllItemsDispoByDate(DateTime debut, DateTime fin)
        {
            List<Item> items = database.GetAllItems();
            List<Item> res = new List<Item>();
            foreach (Item i in items)
            {
                if (getDispoReservableByDate(false, i.ReservableId, debut, fin) == true) res.Add(i);
            }
            return res;
        }


        public static bool getDispoReservableByDateForModif(bool withMessageBox, int idReservable, int idReservation, DateTime dateDebut, DateTime dateFin)
        {
            List<Reservation> reservations = database.GetAllReservationsByReservableId(idReservable);

            foreach (Reservation reservation in reservations)
            {
                if(reservation.ReservationId != idReservation)
                {
                    if ((reservation.beginDateReservation.Value.Date <= dateDebut.Date
                    && reservation.endDateReservation.Value.Date >= dateDebut.Date)
                    ||
                    (reservation.beginDateReservation.Value.Date <= dateFin.Date
                    && reservation.endDateReservation.Value.Date >= dateFin.Date))
                    {
                        if (withMessageBox)
                            MessageBox.Show("Les dates pour lesquelles vous désirez réserver ne sont plus disponibles.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;

        }

        public static bool exportPDF(DataGridView table, string path, string title)
        {
            PdfPTable pdfTable = new PdfPTable(table.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 90;
            pdfTable.HorizontalAlignment = 1;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding title of Pdf
            PdfPCell cellTitle = new PdfPCell(new Phrase(title.ToUpper()));
            cellTitle.Colspan = table.ColumnCount;
            cellTitle.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cellTitle.PaddingBottom = 10;
            pdfTable.AddCell(cellTitle);

            //Adding Header row
            foreach (DataGridViewColumn column in table.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                //cell.BackgroundColor = new iTextSharp.text.BaseColor(Color.Violet);
                pdfTable.AddCell(cell);
            }
            //Adding DataRow
            foreach (DataGridViewRow row in table.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    pdfTable.AddCell(c.Value.ToString());
                }
            }
            try
            {
                //Exporting to PDF
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public static bool exportCSV(DataGridView table, string path)
        {
            
            try
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, false, Encoding.Unicode))
                {
                    //string line = "";
                    var csv = new CsvWriter(file);
                    csv.Configuration.Delimiter = ";";
                    foreach (DataGridViewColumn col in table.Columns)
                    {
                        if (col.HeaderText != null)
                            csv.WriteField(col.HeaderText.ToString());
                        else
                            csv.WriteField("");
                    }
                    csv.NextRecord();

                    foreach (DataGridViewRow row in table.Rows)
                    {
                        //line = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                                csv.WriteField(cell.Value.ToString());
                            else
                                csv.WriteField("");
                        }
                        csv.NextRecord();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Export: "+e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        public static bool existReservationManager(string pseudo)
        {
            if (database.ExistReservationManager(pseudo) == true)
            {
                MessageBox.Show("Ce manager posséde une reservation active", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else return false;
        }


        public static List<string[]> importCSV(TextBox path, bool virgule, bool entete)
        {
            List<string[]> infos = new List<string[]>();
            bool firstRound = false;

            try
            {
                Encoding encod = GetFileEncoding(path.Text);
                using (System.IO.StreamReader file = new System.IO.StreamReader(path.Text, encod))
                {
                    var csv = new CsvReader(file);
                    csv.Configuration.Delimiter = virgule ? "," : ";";

                    while (csv.Read())
                    {
                        if (!entete && !firstRound)
                            infos.Add(csv.FieldHeaders);

                        string[] record = new string[csv.FieldHeaders.Count()];
                        for (int i = 0; i < record.Count(); i++)
                        {
                            record[i] = csv.GetField(i).ToString();
                        }
                        infos.Add(record);

                        firstRound = true;
                    }

                    csv.Dispose();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message+".", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                path.Text = string.Empty;
            }

            return infos;
        }

        public static bool existReservationUser(bool withMessageBox,int userId)
        {
            bool emp = database.ContainReservationByUserId(userId);
            if (emp==false) return false;
            else
            {
                if (withMessageBox) MessageBox.Show("Cet utilisateur possède une réservation active.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        public static bool existReservationItem(bool withMessageBox, int reservableId)
        {
            bool emp = database.ContainReservationByReservableId(reservableId);
            if (emp == true)
            { 
                if (withMessageBox) MessageBox.Show("Ce matériel possède une réservation active.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            Item item = database.GetItemById(reservableId);
            if (item.pack != null)
            {
                bool empPack = database.ContainReservationByReservableId(item.pack.ReservableId);
                if (empPack == true)
                {
                    if (withMessageBox) MessageBox.Show("Un pack contenant ce matériel possède une réservation active.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        public static bool existReservationPack(bool withMessageBox, int reservableId)
        {
            bool emp = database.ContainReservationByReservableId(reservableId);
            if (emp == true)
            {
                if (withMessageBox) MessageBox.Show("Ce matériel possède une réservation active.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            Pack pack = database.GetPackById(reservableId);
            List<Item> items = database.GetItemsInPack(reservableId);
            foreach (Item i in items)
            {
                bool res = database.ContainReservationByReservableId(i.ReservableId);
                if (res== true)
                {
                    if (withMessageBox) MessageBox.Show("Un materiel de ce pack possède une réservation active.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        public static Encoding GetFileEncoding(string srcFile)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;

            // *** Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[5];
            FileStream file = new FileStream(srcFile, FileMode.Open);
            file.Read(buffer, 0, 5);
            file.Close();

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;
            else if (buffer[0] == 0xFE && buffer[1] == 0xFF)
                // 1201 unicodeFFFE Unicode (Big-Endian)
                enc = Encoding.GetEncoding(1201);
            else if (buffer[0] == 0xFF && buffer[1] == 0xFE)
                // 1200 utf-16 Unicode
                enc = Encoding.GetEncoding(1200);


            return enc;
        }

        public static bool existItemInCategorie(int idCategorie)
        {
            Categorie cat = database.GetCategorieById(idCategorie);
            List<Item> items = database.GetAllItems();
            foreach(Item i in items)
            {
                if (i.categorie == cat)
                {
                    MessageBox.Show("Il existe un materiel dans la categorie", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        public static bool existUserInUserClass(int idUserclass)
        {
            UserClass userclass = database.GetUserClassById(idUserclass);
            List<User> users = database.GetAllUsers();
            foreach (User u in users)
            {
                if (u.userClass == userclass)
                {
                    MessageBox.Show("il existe un utilisateur dans cette classe", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        public static bool dateReservationToday(int idReservation)
        {
            Reservation res = database.GetReservationById(idReservation);
            if (res.beginDateReservation.Value.Date == DateTime.Today.Date) return true;
            else
            {
                MessageBox.Show("la date de la réservation n'est pas la date du jour", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static void initBase()
        {
            database.AddUserClass("cm2", 1000, 100);
            for (int i = 0; i < 20; i++)
            {
                database.AddUser("user" + i, "user" + i, "user" + i, "user" + i, null,database.GetUserClassById(1));
            }
            for (int k = 0; k < 5; k++)
            {
                database.AddCategorie("categorie" + k, k, "des" + k);
            }
            for (int k = 0; k < 20; k++)
            {
                database.AddPack("packname" + k, "des" + k,true,k,false);
            }
            
            for (int j = 0; j < 20; j++)
            {
                database.AddItem("itemname" + j, "itemdes" + j, true, j, null, "ref" + j, 1,database.GetCategorieById(1));
            }
            
        }
        //------------------------

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isNotConnected(int id)
        {
            if (manager.ManagerId == id)
            {
                MessageBox.Show("Le manager est actuellement connecté", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        public string DecryptString(string inputString, int dwKeySize, string xmlString)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider
                                         = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(xmlString);
            int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ?
              (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(
                     inputString.Substring(base64BlockSize * i, base64BlockSize));
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(
                                    encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(
                                      Type.GetType("System.Byte")) as byte[]);
        }

        public static void createUserSelectOnly()
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PixLogic.DAL.DataContext;Trusted_Connection=True;";
            string query = @"if not exists(select * from sys.sql_logins where name = N'SelectOnly')
                            begin
                                create login SelectOnly
                                    with password = 'a'
                            end
                            

                            use[PixLogic.DAL.DataContext]

                            IF NOT EXISTS(SELECT * FROM sys.database_principals WHERE name = N'SelectOnlyUser')
                            begin
                                create user SelectOnlyUser
                                    for login SelectOnly
                            end
                            

                            grant select to SelectOnlyUser
                            ";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connect;

                connect.Open();
                reader = cmd.ExecuteReader();
            }

        }

        public static void initCreateDatabase()
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;";
            string query = @"if not exists(SELECT name FROM master.sys.databases WHERE name = N'Pixlogic.Dal.DataContext')
create database [Pixlogic.DAL.Datacontext]
use [Pixlogic.DAL.Datacontext]
	BEGIN
		CREATE TABLE [dbo].[Categorie] (
			[CategorieId] [int] NOT NULL IDENTITY,
			[name] [nvarchar](max),
			[level] [int] NOT NULL,
			[description] [nvarchar](max),
			CONSTRAINT [PK_dbo.Categorie] PRIMARY KEY ([CategorieId])
		)
		CREATE TABLE [dbo].[Reservable] (
			[ReservableId] [int] NOT NULL IDENTITY,
			[name] [nvarchar](max),
			[price] [int] NOT NULL,
			CONSTRAINT [PK_dbo.Reservable] PRIMARY KEY ([ReservableId])
		)
		CREATE TABLE [dbo].[Log] (
			[LogId] [int] NOT NULL IDENTITY,
			[isPack] [bit] NOT NULL,
			[beginDateEmprunt] [datetime],
			[endDateEmprunt] [datetime],
			[userName] [nvarchar](max),
			[userNickname] [nvarchar](max),
			[userMail] [nvarchar](max),
			[userClasse] [nvarchar](max),
			[userPhoneNumber] [nvarchar](max),
			[reservableName] [nvarchar](max),
			CONSTRAINT [PK_dbo.Log] PRIMARY KEY ([LogId])
		)
		CREATE TABLE [dbo].[MailConfig] (
			[MailConfigId] [int] NOT NULL IDENTITY,
			[serveurStmp] [nvarchar](max),
			[port] [int] NOT NULL,
			[email] [nvarchar](max),
			[mdp] [nvarchar](max),
			CONSTRAINT [PK_dbo.MailConfig] PRIMARY KEY ([MailConfigId])
		)
		CREATE TABLE [dbo].[Managers] (
			[ManagerId] [int] NOT NULL IDENTITY,
			CONSTRAINT [PK_dbo.Managers] PRIMARY KEY ([ManagerId])
		)
		CREATE TABLE [dbo].[Requete] (
			[RequeteId] [int] NOT NULL IDENTITY,
			[name] [nvarchar](max),
			[text] [nvarchar](max),
			CONSTRAINT [PK_dbo.Requete] PRIMARY KEY ([RequeteId])
		)
		CREATE TABLE [dbo].[Reservation] (
			[ReservationId] [int] NOT NULL IDENTITY,
			[isPack] [bit] NOT NULL,
			[beginDateReservation] [datetime],
			[endDateReservation] [datetime],
			[beginDateEmprunt] [datetime],
			[endDateEmprunt] [datetime],
			[dateRendu] [datetime],
			[manager_ManagerId] [int],
			[reservable_ReservableId] [int],
			[user_UserId] [int],
			CONSTRAINT [PK_dbo.Reservation] PRIMARY KEY ([ReservationId])
		)
		CREATE INDEX [IX_manager_ManagerId] ON [dbo].[Reservation]([manager_ManagerId])
		CREATE INDEX [IX_reservable_ReservableId] ON [dbo].[Reservation]([reservable_ReservableId])
		CREATE INDEX [IX_user_UserId] ON [dbo].[Reservation]([user_UserId])
		CREATE TABLE [dbo].[User] (
			[UserId] [int] NOT NULL IDENTITY,
			[name] [nvarchar](max),
			[nickname] [nvarchar](max),
			[mail] [nvarchar](max),
			[phoneNumber] [nvarchar](max),
			[image] [varbinary](max),
			[credits] [int] NOT NULL,
			[userClass_UserClassId] [int],
			CONSTRAINT [PK_dbo.User] PRIMARY KEY ([UserId])
		)
		CREATE INDEX [IX_userClass_UserClassId] ON [dbo].[User]([userClass_UserClassId])
		CREATE TABLE [dbo].[UserClass] (
			[UserClassId] [int] NOT NULL IDENTITY,
			[name] [nvarchar](max),
			[credits] [int] NOT NULL,
			[level] [int] NOT NULL,
			CONSTRAINT [PK_dbo.UserClass] PRIMARY KEY ([UserClassId])
		)
		CREATE TABLE [dbo].[Item] (
			[ReservableId] [int] NOT NULL,
			[categorie_CategorieId] [int],
			[pack_ReservableId] [int],
			[description] [nvarchar](max),
			[dispo] [bit] NOT NULL,
			[image] [varbinary](max),
			[reference] [nvarchar](max),
			[quantity] [int] NOT NULL,
			CONSTRAINT [PK_dbo.Item] PRIMARY KEY ([ReservableId])
		)
		CREATE INDEX [IX_ReservableId] ON [dbo].[Item]([ReservableId])
		CREATE INDEX [IX_categorie_CategorieId] ON [dbo].[Item]([categorie_CategorieId])
		CREATE INDEX [IX_pack_ReservableId] ON [dbo].[Item]([pack_ReservableId])
		CREATE TABLE [dbo].[Pack] (
			[ReservableId] [int] NOT NULL,
			[description] [nvarchar](max),
			[dispo] [bit] NOT NULL,
			CONSTRAINT [PK_dbo.Pack] PRIMARY KEY ([ReservableId])
		)
		CREATE INDEX [IX_ReservableId] ON [dbo].[Pack]([ReservableId])
		ALTER TABLE [dbo].[Reservation] ADD CONSTRAINT [FK_dbo.Reservation_dbo.Managers_manager_ManagerId] FOREIGN KEY ([manager_ManagerId]) REFERENCES [dbo].[Managers] ([ManagerId])
		ALTER TABLE [dbo].[Reservation] ADD CONSTRAINT [FK_dbo.Reservation_dbo.Reservable_reservable_ReservableId] FOREIGN KEY ([reservable_ReservableId]) REFERENCES [dbo].[Reservable] ([ReservableId])
		ALTER TABLE [dbo].[Reservation] ADD CONSTRAINT [FK_dbo.Reservation_dbo.User_user_UserId] FOREIGN KEY ([user_UserId]) REFERENCES [dbo].[User] ([UserId])
		ALTER TABLE [dbo].[User] ADD CONSTRAINT [FK_dbo.User_dbo.UserClass_userClass_UserClassId] FOREIGN KEY ([userClass_UserClassId]) REFERENCES [dbo].[UserClass] ([UserClassId])
		ALTER TABLE [dbo].[Item] ADD CONSTRAINT [FK_dbo.Item_dbo.Reservable_ReservableId] FOREIGN KEY ([ReservableId]) REFERENCES [dbo].[Reservable] ([ReservableId])
		ALTER TABLE [dbo].[Item] ADD CONSTRAINT [FK_dbo.Item_dbo.Categorie_categorie_CategorieId] FOREIGN KEY ([categorie_CategorieId]) REFERENCES [dbo].[Categorie] ([CategorieId])
		ALTER TABLE [dbo].[Item] ADD CONSTRAINT [FK_dbo.Item_dbo.Pack_pack_ReservableId] FOREIGN KEY ([pack_ReservableId]) REFERENCES [dbo].[Pack] ([ReservableId])
		ALTER TABLE [dbo].[Pack] ADD CONSTRAINT [FK_dbo.Pack_dbo.Reservable_ReservableId] FOREIGN KEY ([ReservableId]) REFERENCES [dbo].[Reservable] ([ReservableId])
		CREATE TABLE [dbo].[__MigrationHistory] (
			[MigrationId] [nvarchar](150) NOT NULL,
			[ContextKey] [nvarchar](300) NOT NULL,
			[Model] [varbinary](max) NOT NULL,
			[ProductVersion] [nvarchar](32) NOT NULL,
			CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
		)
		INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
		VALUES (N'201512150827391_InitialCreate', N'PixLogic.DAL.DataContext',  0x1F8B0800000000000400ED5D5B6FDCB8157E2FD0FF3098A7DD22EBB1B32FADE1D94532490AA3896D789C45DF0C79448F85E8165D0C1B8BFEB23EF427F52F9414298977F122CD8CBD4580C043911F0F0F0F0F0FC9C3C3FFFEFB3F67BF3E25F1EC11146594A5CBF9C9D1F17C06D24D1646E97639AFABFB9FFE3AFFF5973FFFE9EC63983CCD7E6BF3FD8CF2C19269B99C3F54557EBA58949B079004E551126D8AACCCEEABA34D962C82305BBC3D3EFEDBE2E4640120C41C62CD6667D7755A4509687EC09FAB2CDD80BCAA83F84B1682B824E9F0CBBA419D5D040928F3600396F3ABE8E973B68D36471FDE7D9ECFDEC55100695883F87E3E0BD234AB820A5278FAB504EBAAC8D2ED3A8709417CF39C0398EF3E884B40283FEDB39B36E2F82D6AC4A22FD8426DEAB2CA124BC0939F0957167C7127DECE3BAE41BE7D84FCAD9E51AB1BDE2DE7ABA002DBAC8860EBF9DA4E57718172B2BC3DEA4ABC99D1E96F3A2980C282FEBD99ADEAB8AA0BB04C415D15410CF3D77771B4F90778BEC9BE817499D6714C5307E983DF9804987455643928AAE76B70CFD37C1ECE670B1660C12374E5658571F3CED3EAE7B7F3D9052427B88B41270E142BD6555680BF831414B0787815541528606F9E87A061A8400657690AFF6F6B83F20707D17CF62578FA0CD26DF5B09CC33FE7B34FD11308DB1442C1D73482630E16AA8A1A0C55128347100FB5490F11827253443996B551C93D5BF4A2A715C8F30A24C6B288328F2386B3F74109488BA1D238BA0625281E11EBE67BE298A4AEA8CCB3B696F759168320B5EEE22809B69D2CBE8FD2A0783623550F5B807B50C019627A31FF5E0764CC5949FA45F0186D1B59E2F036BD06BC067193A37C8872220748C26EA92C9F8A2CB9CE6222A8FD97DB7556174DEB33E9E79BA0D882CA9C2A38A97D531384BF72B4A0443919CD171905C6A3F2AAA9D07054A2CCFF1F951A7134663B64A031D7E15F7B9B91619D2E733129B6AB59382AB118FB29D03BB08DD20F90808F495E407BB5C54349375132581EA4A147E91A0E808B5D58134D45D1E6DB4E4C1754D997208A7752D12A0ECA72376DBA7AC85270512777A098BCBEA2D38D13C887B1C642BD08976DF791B9E2EA8BEC4D7FF524B8A831B6F4AEB419EA6D5017EB2AC92797AD3C2B2ABF95055CA7EE607827E1D8BCB010FC141AD68585D437F9F728F24DFD6EF2DE157D550BE87457D35D8EA685E96B29411D66AF79CC5D83EF35A8CCB7AE48FEBD8D3952BFCB98A38ABEAA315781A76A7FE2D3AD26CD25A82DB247216A49709323BAF4AB12A5BC88FAED27372B659C1562057A936CE40D01D27D7863C34E66518E7D0B2DA2C1436ADBE22F74C380E93CA74D030F84FD6E5B840DF169580F1654EE8826AD812DD914A5F872DBE5EBB747259F858D52591EDB4DDB829A5006A8A4B3CA09ED736869A5B2D9928B76280609C599E424A26F5AE29A0C5E1BCF5F4B8B3515CABC3715872A77D16D6DB9573517EF6C29B5936D857C87DB78139DCF6D0A10465539D6A159B78F2AD51F48A46FA92CBDF660BF08BA83FBECAD3948FD16EAA329B1571DD250E0AA48BAC2AF4A9BB809AFAF7B844AD2DE9565B6891AEE513E0BD421314BC6C7349CE94F8CFBF34DECFCF0054A5794437982952FE77F111AA6446CC70B8548F9F7B0B0C74747277C7BA9961934B83984D652C69E487B369339C4A6C0B0893E62E364C6A48A32AD65299C5B63BBDDBCDD3A9B9442EFB69E276242A13A7597532A335C476585C4E495FB088CC9106E4E53D1A99AE07AFAB0456BDE72C59CC82192996E2209681601265DC3AE0846ED75662D31C04F8B86631DBFCAD22A88E024481A0F97A7014A6B762705F30156492C88924C607C0310E61A54BCCF21ECA17E4E1135B4C00716065A243280C64964A0687F442943A00F6D07811A5D2347216A6800826C65CB20BA0DFD4188768CCB517A0D6006D4D8AF6A242CB60350480E6518583E0D0A63BF04150419E01C0E25D43D18EFB34665927BB5F186E9A0C9D291CF75C5C218A91DC814123D4A78DB976DA7290FB09B9CA2F9A2F93260C0B8369A315CCC401C1A2CDD02139B3E68DC189B37624BC828D2F04367D05078BD9219952DF49E9B9E332A8BC7C6E6F1E58FC4CA994C78F805BBC81D9DF963620051A41345A96183C2E4E1303A7D39AA90E0FD4EBD7888E6909941E42B128C0934C4510D1FDA956D67F574DFCE16F8660D49385B28AEE09C7D09F21C2EF6A92B392465B6C6F771563FADEDAFAB241863B12925B7563A6ABB9AAAAC807A82FB0AAB86947E8A8AB24256DC5D80D6F5AB3011B2D1369E62766E6B12CC38B1BFDA29BB2D82FE26BED3D2DB333C44CFC14FB0510948ABA67D4036418A6567E84A54100785EEB6CB2A8BEB241DBC43A3C3C3DB3D34104E314720DB3034044932C760DCBB6924E6838877B6E058CC77E342E8476E48F192612437B4AE76169C66CFC45E66E4C5548C65BD0368CEEABC0EA6E82A251EF6B6679070923906D962A7314892390675DF85C6A192CDB1FA1B2D34549F3ABE20DB08DE95C44E36103C79B13F86E04DDC3DE725FAFBF2FE07856BD28F0EDDA5BA59B3DB4EF39F5E8813100D41922CF40371FB601404493347C15E4034064E399869A9D94E72560B68D7C95ECCA4A5541C24D78368164A2F1A4DDF97A2F30C8D277E3547E6DD6A685CFE9B396A7F4B88C6EB532D91BAC37C01ADFB628788EFFAF06838D50EA9BDCCC363B5E97668CC7D1D1E92F9686329B4BA50EC11FEDBC1E8067ABFD8594550DBCAF69A425758C56AF6220ECD68DD051F1D62495FB2A101990F16D353739186999D9A140B8591086387249963342EFB3442937040C247B6FF3C244FBAB36924768A926A99EB2EC3B002A7B85EA3C3F2377F52A9AA4E1DD434B9A3C2882A4EB2C0203750181092F66AA4B53BCE7296D6F6D4CBC56A5794549BECDD3512D65E575C4CD161F94B2B3E5E654DE427A936DCEFCE0DDEA5F5E8DFFE14D17965262F3DB0346B1DE6256B33B92BBE0E7364539A395B959AD39AD3575D0D325F798959ED88FED2960294E73DB377D1271FCC68C3C718CEC3ECABE454C6607CC98BA9D8D97A6BD3BC947B7EEB500E69A217ED495B733257AD9A72B715D318FBB39DCB288DD2251E94C8B7E7985E822F3D9635947E4559DD10E8FC8CF971A0F05ED6E1F90F06DBCE1EE36C6A6A81610F6F59A9E11D7C344746743693B32174F2CC7145EEB92332C4EE00B207D41E452236750459D34A0EDE0D6975DDCFD6D2B8CA522886C8ADF2BC44EEE69DABB93533F8037D37B1C9BB1B8D2A89C1397C8485F678F2E67D03E6D1013A1A5F8A7C0CF2C05B36A4EE63C3EB993EAFC5B245D2251AC730C3CE51ECC3B4609AFD184BE9D1F8C4D9C991C3E2CC5F9206F931AA24D11E7706C244671F4F9E44473AEFF14E418EAA99F42E852F40BC0C19E32D64BCC3A2C632A6B399ACFD24DD22F74734EC0EA5B9DC036A0D674B1192FB5F5AD06ABABAF5171623068CAA8FB073A78126C219C7D341B4E7A6475F34304E1D6240DECBD1321A360C8B8BE0FCCA67E9567624A5FBDD39BF12C7D3E1A0F482272ACE329FC1E63F4621F2425D3F97D01C3D42198ED6DFE3551C01B4C1D76680F374740FCA0ADF2B9EBF3D3E79CB45B73F9C48F38BB20C996BCFBA70F36CAFED25EE7B84183D78FFD9F29A31DEBBC015A48F41B179088A1F92E0E9471AC93A9C7B43AA7F30770B825CA26839F4E9F8D1AC0EBB579920552EBDCAC624BA8BEC11E8F054C3E5AD62553B08C018A1A327E9727F46AB422EA1B397AA897D64273BF2104CAE687C24692FB196458BF606A423427B83B1519FBDE124919DBD30E5D19BA7D0D72AC7AA7D454A9E64F032EE5963A86D2A00B28BD666C21F7B5142855B9D463A64012F761E51F8B027713EBA959F68D1C180FD909880BF872C6552BFA5DDC7D03D6C29A343E34E68B88BBB19FB0BE979E8869C24FEA6A7313722E2619B9B4204505720C90906253C42AC96F334044FCBF9EF4DE9D3D9F93F6F058037B3CB2204C5E9EC78F62F77BBED56B91835A04901E34319B34966470D55D49C02BB909E0E0A679C009B87ADF347B52C46B33925F12FBDF098189710E8AE0973E904C5850674B1CD15C710F64346009968F0C82290ED25BCE4618FA51144C3720FD6EE91CBC3D92D35906F9359C92C10ADDCD5C98E1A2988CF642971B0B1A34800F0A1C66FE75E82473F51E862008FA8B0858742BD5AC63F063AE218150318FC61C6E89EE5CF3CF0AE4DA8D62E3C2126C32E722A832459B3D907B9BCC6E3003D42BECAD2B22A8248F421BE2AA27413E541CCB581CB67B71D8718DC01F35F3E801C2ED290A7B8D856935A8DFCEDBA4AB8C131C493C9E3D7768E6A0EB1640F444474813C2CB5D5A48262E142B70371B188EE4B799CD9C7DF15D01C42033B8985EE8E88D542C14A281457B2C40A8D7DE176AC3AB4818F8DFAEF60158571DFA8FDCD26530E037E6E3B1082E68E00EA8F1EE8163D634129ABDB9BEC56B290F3985474828263E65330B220FA52617B51D38822CC9D7D8DBB9291E1671FA800DF54F7593CCC602F0723A9085DB04A2BF7BC6944C0F80AD9AE6441FB22067D0865F170C5DE3A5F11F7EF10C6BED195B01D74FA5573CF6D709290EC244C3449B8CBD88B9A244613CDD16584732D6F35A3109098EF40C57B11FAE722B033F9721EDEA1CD15BC9D62FE9A042D61422DF4475935F4F7817A9AE729840A9A5419B2DD6B16038F59C82AB07FEC42F7D685BC0645F87AB10BC8731712FE932F72E65BBD9281D710AA2EC65F357D2C0B90227DBF42F9F6850CDCEE550CFD9B182A7CF993197C25780A15F071B20C1A7F1940C58A5740C5C93254591C9D1DBEF4C0893A130B4D549C8AF5ABE2AAD4C0151DCB26D39744C77BC58152837C3CDCFD377FE4E7199821C54501D135961EE4FDF5C9717B7784E7178CC8DC432FDA6C29A81EAD71D9911851DC695DD94785188935E3BC5824D84EDCD3097B6B9ECF6344F46CD24757DF47536C963C92C63AAF9846146223668EF37A8A785114AE2DEA14B93DE25F1F40196D7B0874FD35051B6655D1E5394FEFB37689C351D466E1DDEA41158470C9F1AEA8A2FB6053C1CF1B5096CD23ADBF05710DB37C4CEE40789E5ED6555E57B0C920B98B992707D02249577FF3440C4BF3D96573745C8ED1044866843C452FD3F77514871DDD9F24C7C60A08B4FA22FE49A82F2BE4A7B47DEE902E84A0A62A20C2BE6ED17803923C8660E565BA0E1E810B6D706AFA0CB6C1E6B9BDEFAB0619EE0896ED671FA2605B04494930FAF2F02794E13079FAE57FD715B1F2EA9B0000 , N'6.1.3-40302')
	END


                            ";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connect;

                connect.Open();
                reader = cmd.ExecuteReader();
            }
        }
    }

}
