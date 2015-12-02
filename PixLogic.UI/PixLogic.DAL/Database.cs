using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class Database
    {
        ServiceContainer container;
        public Database()
        {
            container = new ServiceContainer();
        }

        //------- FONCTION PANNEAU MATERIEL --------//

        public void AddItem(string name, string description, bool dispo, float price, Image image, string reference, int quantity)
        {
            container.get("add_item").addItem(container.get("item_factory").build(name, description,dispo,price,image,reference,quantity));
        }
        public void AddPack(string name, string description, bool dispo, float price)
        {
            container.get("add_pack").addPack(container.get("pack_factory").build(name, description, dispo, price));
        }
        public void AddItemToPack(string itemName,string packName)
        {
            container.get("add_pack_to_item").addPackToItem(itemName, packName);
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            return container.get("byte_array_to_image").byteArrayToImage(byteArray);
        }
        public bool ContainItem(string itemName)
        {
           return container.get("contain_item").containItem(itemName);
        }
        public void DeleteItem(string nameToDelete)
        {
            container.get("delete_item").deleteItem(nameToDelete);
        }
        public void DeleteItemToPack(string itemName)
        {
            container.get("delete_pack_to_item").deletePackToItem(itemName);
        }
        public Item GetItemByName(string itemName)
        {
            return container.get("get_item_by_name").getItemByName(itemName);
        }
        public Item GetItemById(int itemId)
        {
            return container.get("get_item_by_id").getItemById(itemId);
        }
        public Pack GetPackById(int itemId)
        {
            return container.get("get_pack_by_id").getPackById(itemId);
        }
        public Pack GetPackByName(string packName)
        {
            return container.get("get_pack_by_name").getPackByName(packName);
        }
        public List<Item> GetAllItems()
        {
            return container.get("get_all_items").getAllItems();
        }
        public List<Item> GetAllItemsByString(string search)
        {
            return container.get("get_all_items").getAllItemsByString(search);
        }
        public List<Pack> GetAllPacks()
        {
            return container.get("get_all_packs").getAllPacks();
        }
        public List<Pack> GetAllPacksByString(string search)
        {
            return container.get("get_all_packs").getAllPacksByString(search);
        }
        public List<Item> GetItemsInPack(string packName)
        {
            return container.get("get_items_in_pack").getItemsInPack(packName);
        }
        public void UpdateItem(string nom,string newName, string des, bool disp, float prix, Image img, string refe, int quant)
        {
            container.get("update_item").updateItem(nom,newName, des, disp, prix, img, refe, quant);
        }
        public void UpdatePack(string nom, string newName, string des, bool disp, float prix)
        {
            container.get("update_pack").updatePack(nom, newName, des, disp, prix);
        }
        public void DeletePack(string packName)
        {
            container.get("delete_pack").deletePack(packName);
        }

        //------- FONCTION PANNEAU UTILISATEUR --------//

        public List<User> GetAllUsers()
        {
            return container.get("get_all_users").getAllUsers();
        }
        public List<User> GetAllUsersByString(string search)
        {
            return container.get("get_all_users").getAllUsersByString(search);
        }
        public void AddUser(string name, string nickname, string mail, string classe, string phoneNumber, Image image)
        {
            container.get("add_user").addUser(container.get("user_factory").build(name, nickname, mail, classe, phoneNumber, image));
        }
        /*public User GetUserByName(string itemName)
        {
            return container.get("get_user_by_name").getUserByName(itemName);
        }*/
        public User GetUserById(int id)
        {
            return container.get("get_user_by_id").getUserById(id);
        }
        public void UpdateUser(int id, string name, string nickname, string mail, string classe, string phoneNumber, Image image)
        {
            container.get("update_user").updateUser(id,  name, nickname, mail, classe, phoneNumber, image);
        }
        public void DeleteUser(int id)
        {
            container.get("delete_user").deleteUser(id);
        }

        //***************

        public void AddReservation(bool isPack, DateTime? beginDateReservation, DateTime? endDateReservation,
            DateTime? beginDateEmprunt, DateTime? endDateEmprunt, User user, Reservable element, Manager manager)
        {
            container.get("add_reservation").addReservation(container.get("reservation_factory").build(isPack, beginDateReservation, endDateReservation,
                                                                                                        beginDateEmprunt, endDateEmprunt, user, element, manager));
        }
        public List<Reservation> GetAllReservations()
        {
            return container.get("get_all_reservations").getAllReservations();
        }
        public List<Reservation> GetAllItemReservations(List<Reservation> l)
        {
            return container.get("get_all_item_reservations").getAllItemReservations(l);
        }
        public List<Reservation> GetAllPackReservations(List<Reservation> l)
        {
            return container.get("get_all_pack_reservations").getAllPackReservations(l);
        }
        public List<Reservation> GetAllReservationsByDate(DateTime dateDebut,DateTime dateFin)
        {
            return container.get("get_all_reservations_by_date").getAllReservationsByDate(dateDebut,dateFin);
        }
        public List<Reservation> GetAllReservationsByReservableId(int idReservable)
        {
            return container.get("get_all_reservations_by_reservable_id").getAllReservationsByReservableId(idReservable);
        }
        public List<Reservation> GetAllReservationsByString(string search)
        {
            return container.get("get_all_reservations_by_string").getAllReservationsByString(search);
        }
        public List<Reservation> GetAllEmprunts()
        {
            return container.get("get_all_emprunts").getAllEmprunts();
        }
        public Reservation GetReservationById(int id)
        {
            return container.get("get_reservation_by_id").getReservationById(id);
        }
        public void DeleteReservation(int id)
        {
            container.get("delete_reservation").deleteReservation(id);
        }
        public void UpdateReservation(int id,DateTime? DateDebut,DateTime? DateFin)
        {
            container.get("update_reservation").updateReservation(id, DateDebut, DateFin);
        }

        public void EmpruntReservation(int id)
        {
            container.get("emprunt_reservation").empruntReservation(id);
        }
        public List<Reservation> GetAllEmpruntsByDate(DateTime debut,DateTime fin)
        {
            return container.get("get_all_emprunts_by_date").getAllEmpruntsByDate(debut, fin);
        }
        public List<Reservation> GetAllEmpruntsByString(string search)
        {
           return container.get("get_all_emprunts_by_date").getAllEmpruntsByString(search);
        }
        public List<Reservation> GetAllItemsEmprunts(List<Reservation> list)
        {
            return container.get("get_all_items_emprunts").getAllItemsEmprunts(list);
        }
        public List<Reservation> GetAllPacksEmprunts(List<Reservation> list)
        {
            return container.get("get_all_items_emprunts").getAllPacksEmprunts(list);
        }
        /*
        *LOG
        */
        public List<Reservation> GetAllLogs()
        {
            return container.get("get_all_logs").getAllLogs();
        }
        /*
        *Categorie
        */
        public void AddCategorie(string name, int level,string description)
        {
            container.get("add_categorie").addCategorie(container.get("categorie_factory").build(name, level,description));
        }
        public void AddCategorieToItem(string itemName, string packName)
        {
            container.get("add_categorie_to_item").addCategorieToItem(itemName, packName);
        }
        public void UpdateCategorie(int id,string nom,int lvl,string description)
        {
            container.get("update_categorie").updateCategorie(id,nom,lvl,description);
        }
        public Categorie GetCategorieById(int id)
        {
            return container.get("get_categorie_by_id").getCategorieById(id);
        }
        public List<Categorie>GetAllCategorie()
        {
            return container.get("get_all_categorie").getAllCategorie();
        }
        public List<Categorie> GetAllCategorieByString()
        {
            return container.get("get_all_categorie").getAllCategorieByString();
        }

        public void DeleteCategorie(string name)
        {
            container.get("delete_categorie").deleteCategorie(name);
        }
        public bool ContainReservationByUserId(int id)
        {
           return container.get("contain_reservation_by_user_id").containReservationByUserId(id);
        }
        public void RetourEmprunt(int id,DateTime? retour)
        {
            container.get("retour_emprunt").retourEmprunt(id, retour);
        }
        /*
        *mailconfig
        */
        public void AddMailConfig(MailConfig mailConfig)
        {
            container.get("add_mail_config").addMailConfig(mailConfig);
        }
        public void UpdateMailConfig()
        {
            container.get("update_mail_config").upDateMailConfig();
        }
        public MailConfig GetMailConfig()
        {
            return container.get("get_mail_config").getMailConfig();
        }

    }
}
