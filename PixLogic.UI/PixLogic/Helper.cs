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


namespace PixLogic
{
    class Helper
    {
        public static Database database = new Database();

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
                        MessageBox.Show("Tous les champs obligatoires (*) n'ont pas été rempli!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("La date de debut est supérieure à celle de fin!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return true;
        }
        public static bool getDispoReservableByDate(bool withMessageBox, int idReservable, DateTime dateDebut,DateTime dateFin)
        {
            List<Reservation> reservations = database.GetAllReservationsByReservableId(idReservable);
            foreach (Reservation reservation in reservations)
            {
                if(isDispo(true, reservation, dateDebut, dateFin)==false)return false;
            }
            List<Reservation> emprunts = database.GetAllEmpruntsByReservableId(idReservable);
            foreach (Reservation emprunt in emprunts)
            {
                if ((emprunt.beginDateEmprunt.Value.Date <= dateDebut.Date
                    && emprunt.endDateEmprunt.Value.Date >= dateDebut.Date)
                    ||
                    (emprunt.beginDateEmprunt.Value.Date <= dateFin.Date
                    && emprunt.endDateEmprunt.Value.Date >= dateFin.Date))
                {
                    if (withMessageBox)
                        MessageBox.Show("Les dates pour lesquelles vous désirez réserver ne sont plus disponibles.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            Reservation res = reservations.FirstOrDefault();
            if(res != null) { 
            if (res.isPack == true)
                {
                    List<Item> items = database.GetItemsInPack(res.reservable.name);
                    foreach (Item i in items)
                    {
                        List<Reservation> reser= database.GetAllReservationsByReservableId(i.ReservableId);
                        foreach (Reservation reservation in reser)
                        {
                            if (isDispo(true, reservation, dateDebut, dateFin) == false) return false;
                        }
                    }
                }
                if (res.isPack == false)
                {
                    Item i = database.GetItemById(res.reservable.ReservableId);
                    if (i.pack != null)
                    {
                        List<Reservation> rese = database.GetAllReservationsByReservableId(i.pack.ReservableId);
                        foreach (Reservation reservation in rese)
                        {
                            if (isDispo(true, reservation, dateDebut, dateFin) == false) return false;
                        }
                    }
                }
            }
            return true;     
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

        public static bool exportPDF(DataGridView table, string path)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(table.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            //Adding Header row
            foreach (DataGridViewColumn column in table.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            //Adding DataRow
            foreach (DataGridViewRow row in table.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            try
            {
                //Exporting to PDF
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
            catch(Exception e) {
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
                    string line = "";
                    foreach (DataGridViewColumn col in table.Columns)
                    {
                        line += col.HeaderText.ToString() + ";";
                    }
                    file.WriteLine(line);

                    foreach (DataGridViewRow row in table.Rows)
                    {
                        line = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            line += cell.Value.ToString() + ";";
                        }

                        file.WriteLine(line);
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
        public static bool existReservationReservable(bool withMessageBox, int reservableId)
        {
            bool emp = database.ContainReservationByReservableId(reservableId);
            if (emp == false) return false;
            else
            {
                if (withMessageBox) MessageBox.Show("Ce matériel possède une réservation active.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        public static void initBase()
        {
            for (int i = 0; i < 100; i++)
            {
                database.AddUser("user" + i, "user" + i, "user" + i, "user" + i, "user" + i, null);
            }
            for (int k = 0; k < 5; k++)
            {
                database.AddCategorie("categorie" + k, k, "des" + k);
            }
            for (int j = 0; j < 200; j++)
            {
                database.AddItem("itemname" + j, "itemdes" + j, true, j, null, "ref" + j, 1);
                database.AddCategorieToItem("itemname" + j, "categorie1");
            }
        }
    }
}
