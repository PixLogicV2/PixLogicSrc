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

        public void AddItem(string name, string description, bool dispo, int price, Image image, string reference, int quantity,Categorie cat)
        {
            Item item = container.get("item_factory").build(name, description, dispo, price, image, reference, quantity);
            container.get("add_item").addItem(item);
            container.get("add_categorie_to_item").addCategorieToItem(item.ReservableId, cat.CategorieId);
        }
        public void AddPack(string name, string description, bool dispo, int price)
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
        public List<Item> GetItemsInPack(int packId)
        {
            return container.get("get_items_in_pack").getItemsInPack(packId);
        }
        public List<Item> GetItemsInPackByName(string name)
        {
            return container.get("get_items_in_pack_by_name").getItemsInPackByName(name);
        }
        public void UpdateItem(string nom,string newName, string des, bool disp, float prix, Image img, string refe, int quant,Categorie cat)
        {
            container.get("update_item").updateItem(nom,newName, des, disp, prix, img, refe, quant,cat);
        }
        public void UpdatePack(string nom, string newName, string des, bool disp)
        {
            container.get("update_pack").updatePack(nom, newName, des, disp);
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
        public List<UserClass> GetAllUserClass()
        {
            return container.get("get_userclass").getAllUserClass();
        }
        public List<UserClass> GetAllUserClassByString(string search)
        {
            return container.get("get_userclass").getAllUserClassByString(search);
        }
        public UserClass GetUserClassById(int id)
        {
            return container.get("get_userclass").getUserClassById(id);
        }
        public UserClass GetUserClassByName(string name)
        {
            return container.get("get_userclass").getUserClassByName(name);
        }
        public List<User> GetAllUsersByString(string search)
        {
            return container.get("get_all_users").getAllUsersByString(search);
        }
        public bool ContainUserClass(string search)
        {
            return container.get("contain_userclass").containUserClass(search);
        }
        public void AddUser(string name, string nickname, string mail, string phoneNumber, Image image,UserClass classe)
        {
            User user = container.get("user_factory").build(name, nickname, mail, phoneNumber, image);
            container.get("add_user").addUser(user);
            container.get("add_userclass_to_user").addUserClassToUser(user.UserId, classe.UserClassId);
        }
        public void AddUserClass(string name,int credits,int level)
        {
            container.get("add_userclass").addUserClass(container.get("userclass_factory").build(name,credits,level));
        }
        public void AddUserClassToUser(int userId,int userClassId)
        {
            container.get("add_user").addUserClassToUser(userId,userClassId);
        }
        public void UpdateUserClass(int userClassId,string name,int credit,int level)
        {
            container.get("update_userclass").updateUserClass(userClassId,name,credit,level);
        }
        public void DeleteUserClass(int userclassId)
        {
            container.get("delete_userclass").deleteUserClass(userclassId);
        }
        /*public User GetUserByName(string itemName)
        {
            return container.get("get_user_by_name").getUserByName(itemName);
        }*/
        public User GetUserById(int id)
        {
            return container.get("get_user_by_id").getUserById(id);
        }
        public void UpdateUser(int id, string name, string nickname, string mail, string phoneNumber, Image image,UserClass userClass)
        {
            container.get("update_user").updateUser(id,  name, nickname, mail, phoneNumber, image,userClass);
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
            container.get("add_reservation").removeCredit(user, element.price);
        }

        public bool CreditSuffisant(User user, Reservable res)
        {
            return container.get("add_reservation").creditSuffisant(user, res);
        }
        public bool LevelSuffisant(User user, float level)
        {
            return container.get("add_reservation").levelSuffisant(user, level);
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
        public List<Reservation> GetAllReservationsByDateDebut(DateTime dateDebut)
        {
            return container.get("get_all_reservations_by_date_debut").getAllReservationsByDateDebut(dateDebut);
        }
        public List<Reservation> GetAllReservationsByReservableId(int idReservable)
        {
            return container.get("get_all_reservations_by_reservable_id").getAllReservationsByReservableId(idReservable);
        }
        public List<Reservation> GetAllReservationsByUserId(int idReservable)
        {
            return container.get("get_all_reservations_by_user_id").getAllReservationsByUserId(idReservable);
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
        public List<Reservation> GetAllEmpruntsByDateFin(DateTime fin)
        {
            return container.get("get_all_emprunts_by_date_fin").getAllEmpruntsByDateFin(fin);
        }
        public List<Reservation> GetAllEmpruntsByString(string search)
        {
           return container.get("get_all_emprunts_by_date").getAllEmpruntsByString(search);
        }
        public List<Reservation> GetAllEmpruntsByReservableId(int idReservable)
        {
            return container.get("get_all_emprunts_by_reservable_id").getAllEmpruntsByReservableId(idReservable);
        }
        public List<Reservation> GetAllItemsEmprunts(List<Reservation> list)
        {
            return container.get("get_all_items_emprunts").getAllItemEmprunts(list);
        }
        public List<Item> GetAllItemsInCategorie(int id)
        {
            return container.get("get_all_items_in_categorie").getAllItemsInCategorie(id);
        }
        public List<Reservation> GetAllPacksEmprunts(List<Reservation> list)
        {
            return container.get("get_all_packs_emprunts").getAllPacksEmprunts(list);
        }
        /*
        *LOG
        */
        public List<Log> GetAllLogs()
        {
            return container.get("get_all_logs").getAllLogs();
        }
        public List<Log> GetAllLogsByString(string search)
        {
            return container.get("get_all_logs").getAllLogsByString(search);
        }
        public List<Log> GetAllLogsByDate(DateTime debut,DateTime fin)
        {
            return container.get("get_all_logs").getAllLogsByDate(debut,fin);
        }
        public Reservable GetReservableById(int id)
        {
            return container.get("get_reservable_by_id").getReservableById(id);
        }
        public Log GetLogById(int id)
        {
            return container.get("get_log_by_id").getLogById(id);
        }
        public void AddLog(bool isPack,DateTime? beginDateEmprunt, DateTime? endDateEmprunt,string userName,string userNickname ,string userMail,string userClasse,string userPhoneNumber,string reservableName)
        {
            container.get("add_log").addLog(container.get("log_factory").build(isPack, beginDateEmprunt, endDateEmprunt,userName,userNickname,userMail,userClasse,userPhoneNumber,reservableName));
        }
        public void RetourEmprunt(int id, DateTime? retour)
        {
            Reservation reservation = GetReservationById(id);
            User user = GetUserById(reservation.user.UserId);
            Reservable reservable = GetReservableById(reservation.reservable.ReservableId);
            AddLog(reservation.isPack, reservation.beginDateEmprunt, reservation.endDateEmprunt, user.name, user.nickname,user.mail,user.userClass.name,user.phoneNumber,reservable.name);
            container.get("delete_reservation").deleteReservation(reservation.ReservationId);
        }
        public List<Log> GetAllPackLogs(List<Log> list)
        {
            return container.get("get_all_pack_logs").getAllPackLogs(list);
        }
        public List<Log> GetAllItemLogs(List<Log> list)
        {
            return container.get("get_all_item_logs").getAllItemLogs(list);
        }
        /*
        *Categorie
        */
        public void AddCategorie(string name, int level,string description)
        {
            container.get("add_categorie").addCategorie(container.get("categorie_factory").build(name, level,description));
        }
        public void AddCategorieToItem(int itemId, int catId)
        {
            container.get("add_categorie_to_item").addCategorieToItem(itemId, catId);
        }
        public void UpdateCategorie(int id,string nom,int lvl,string description)
        {
            container.get("update_categorie").updateCategorie(id,nom,lvl,description);
        }
        public Categorie GetCategorieById(int id)
        {
            return container.get("get_categorie_by_id").getCategorieById(id);
        }
        public Categorie GetCategorieByName(string name)
        {
            return container.get("get_categorie_by_id").getCategorieByName(name);
        }
        public List<Categorie>GetAllCategorie()
        {
            return container.get("get_all_categorie").getAllCategorie();
        }
        public List<Categorie> GetAllCategorieByString(string text)
        {
            return container.get("get_all_categorie").getAllCategorieByString(text);
        }

        public void DeleteCategorie(int id)
        {
            container.get("delete_categorie").deleteCategorie(id);
        }
        public bool ContainReservationByUserId(int id)
        {
           return container.get("contain_reservation_by_user_id").containReservationByUserId(id);
        }
        public bool ContainReservationByReservableId(int id)
        {
            return container.get("contain_reservation_by_reservable_id").containReservationByReservableId(id);
        }
        public bool ContainCategorie(string name)
        {
            return container.get("contain_categorie").containCategorie(name);
        }
        public int GetIdCategorie(string name)
        {
            return container.get("get_id_categorie").getIdCategorie(name);
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
        
        /*
        *Requete
        */
        public void AddRequete(string name, string text)
        {
            container.get("add_requete").addRequete(container.get("requete_factory").Build(name, text));
        }

        public void DeleteRequete(int queryToDelete)
        {
            container.get("delete_requete").deleteRequete(queryToDelete);
        }

        public void UpdateRequete(Requete query)
        {
            container.get("update_requete").updateRequete();
        }

        public List<Requete> GetAllRequete()
        {
            return container.get("get_all_requete").getAllRequete();
        }
    }
}
