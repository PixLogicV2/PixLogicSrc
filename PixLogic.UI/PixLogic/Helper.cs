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

        public static bool IsInListBox(string name, ListBox list)
        {
            foreach(string n in list.Items)
            {
                if (n.Equals(name))
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
                    foreach (DataGridViewColumn col in table.Columns)
                    {
                        csv.WriteField(col.HeaderText.ToString());
                    }
                    csv.NextRecord();

                    foreach (DataGridViewRow row in table.Rows)
                    {
                        //line = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            csv.WriteField(cell.Value.ToString());
                        }
                        csv.NextRecord();
                    }
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static List<Item> importCSVitem(string path, bool virgule, bool entete)
        {
            List<Item> items = new List<Item>();
            Encoding encod = GetFileEncoding(path);
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(path, encod))
                {
                    
                    if(!entete)
                    {
                        var csv = new CsvReader(file);
                        csv.Configuration.Delimiter = virgule ? "," : ";";
                        while (csv.Read())
                        {
                            List<String> headers = new List<string>();
                            foreach (string h in csv.FieldHeaders)
                            {
                                //Console.Write(h + " | ");
                                headers.Add(h);
                                
                            }
                            Item u = new Item();
                            try
                            {
                                u.reference = headers.ElementAt<string>(0);
                                u.name = headers.ElementAt<string>(1);
                                u.categorie = new Categorie();
                                u.categorie.name = headers.ElementAt<string>(2);
                                u.price = int.Parse(headers.ElementAt<string>(3));
                                u.quantity = int.Parse(headers.ElementAt<string>(4));
                            }
                            catch (Exception e) {
                                MessageBox.Show("Le fichier importé ne correspond pas à celui attendu. Vérifiez que tous les champs obligatoires sont bien renseignés dans votre fichier et qu'ils correspondent bien aux types attendus.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return new List<Item>();
                            }
                            try
                            {
                                u.description = headers.ElementAt<string>(5);
                            }
                            catch (Exception e) { }
                            
                            items.Add(u);
                            break;
                        }
                        csv.Dispose();
                    }
                    
                    using (System.IO.StreamReader fi = new System.IO.StreamReader(path, encod))
                    {
                        var csv2 = new CsvReader(fi);
                        csv2.Configuration.Delimiter = virgule ? "," : ";";
                        while (csv2.Read())
                        {
                            Item u = new Item();
                            try
                            {
                                u.reference = csv2.GetField(0);
                                u.name = csv2.GetField(1);
                                u.categorie = new Categorie();
                                u.categorie.name = csv2.GetField(2);
                                u.price = int.Parse(csv2.GetField(3).ToString());
                                u.quantity = int.Parse(csv2.GetField(4).ToString());
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Le fichier importé ne correspond pas à celui attendu. Vérifiez que tous les champs obligatoires sont bien renseignés dans votre fichier et qu'ils correspondent bien aux types attendus.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return new List<Item>();
                            }
                            try
                            {
                                u.description = csv2.GetField(5).ToString();
                            }
                            catch (Exception e) { }

                            items.Add(u);
                            //Console.WriteLine(id + " | " + nom + " | " + prenom);
                        }
                        csv2.Dispose();
                    }
                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            return items;
        }

        public static List<User> importCSVuser(string path, bool virgule, bool entete)
        {
            List<User> users = new List<User>();
            Encoding encod = GetFileEncoding(path);
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(path, encod))
                {

                    if (!entete)
                    {
                        var csv = new CsvReader(file);
                        csv.Configuration.Delimiter = virgule ? "," : ";";
                        while (csv.Read())
                        {
                            List<String> headers = new List<string>();
                            foreach (string h in csv.FieldHeaders)
                            {
                                //Console.Write(h + " | ");
                                headers.Add(h);

                            }
                            User u = new User();
                            try
                            {
                                u.userClass = new UserClass();
                                u.userClass.name = headers.ElementAt<string>(0);
                                u.name = headers.ElementAt<string>(1);
                                u.nickname = headers.ElementAt<string>(2);
                            }
                            catch(Exception e) {
                                MessageBox.Show("Le fichier importé ne correspond pas à celui attendu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return new List<User>();
                            }
                            
                            try
                            {
                                u.mail = headers.ElementAt<string>(3);
                            }
                            catch (Exception e) { }
                            try
                            {
                                u.phoneNumber = headers.ElementAt<string>(4);
                            }
                            catch (Exception e) { }

                            users.Add(u);
                            break;
                        }
                        csv.Dispose();
                    }

                    using (System.IO.StreamReader fi = new System.IO.StreamReader(path, encod))
                    {
                        var csv2 = new CsvReader(fi);
                        csv2.Configuration.Delimiter = virgule ? "," : ";";
                        while (csv2.Read())
                        {
                            User u = new User();
                            try
                            {
                                u.userClass = new UserClass();
                                u.userClass.name = csv2.GetField(0).ToString();
                                u.name = csv2.GetField(1).ToString();
                                u.nickname = csv2.GetField(2).ToString();
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Le fichier importé ne correspond pas à celui attendu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return new List<User>();
                            }

                            try
                            {
                                var mail = csv2.GetField(3);
                                u.mail = mail;
                            }
                            catch (Exception e) { }
                            try
                            {
                                var tel = csv2.GetField(4);
                                u.phoneNumber = tel;
                            }
                            catch (Exception e) { }

                            users.Add(u);
                            //Console.WriteLine(id + " | " + nom + " | " + prenom);
                        }
                        csv2.Dispose();
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return users;
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
            if (Helper.manager.ManagerId == id)
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
    }
}
