﻿using System.Collections.Generic;

namespace PixLogic.DAL
{
    public class ServiceContainer
    {
        Dictionary<string, dynamic> arrayContainer;
        public ServiceContainer()
        {
            this.arrayContainer = new Dictionary<string, dynamic>();
        }

        public dynamic get(string serviceName)
        {
            if (this.arrayContainer.ContainsKey(serviceName))
            {
                return this.arrayContainer[serviceName];
            }
            switch (serviceName)
            {
                case "item_factory":
                    this.arrayContainer[serviceName] = new ItemFactory();
                    break;
                case "pack_factory":
                    this.arrayContainer[serviceName] = new PackFactory();
                    break;
                case "categorie_factory":
                    this.arrayContainer[serviceName] = new CategorieFactory();
                    break;
                case "user_factory":
                    this.arrayContainer[serviceName] = new UserFactory();
                    break;
                case "reservation_factory":
                    this.arrayContainer[serviceName] = new ReservationFactory();
                    break;

                case "add_item":
                    this.arrayContainer[serviceName] = new AddItem();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "add_pack":
                    this.arrayContainer[serviceName] = new AddPack();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "add_user":
                    this.arrayContainer[serviceName] = new AddUser();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "add_reservation":
                    this.arrayContainer[serviceName] = new AddReservation();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "data_context":
                    this.arrayContainer[serviceName] = new DataContext();
                    break;
                case "get_pack_by_name":
                    this.arrayContainer[serviceName] = new GetPackByName();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_items":
                    this.arrayContainer[serviceName] = new GetAllItems();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_reservations":
                    this.arrayContainer[serviceName] = new GetAllReservations();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_reservations_by_string":
                    this.arrayContainer[serviceName] = new GetAllReservations();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_item_reservations":
                    this.arrayContainer[serviceName] = new GetAllItemReservations();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_pack_reservations":
                    this.arrayContainer[serviceName] = new GetAllPackReservations();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_reservations_by_date":
                    this.arrayContainer[serviceName] = new GetAllReservationsByDate();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_reservations_by_reservable_id":
                    this.arrayContainer[serviceName] = new GetAllReservationsByReservableId();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_items_by_string":
                    this.arrayContainer[serviceName] = this.get("get_all_items");
                    break;
                case "get_item_by_name":
                    this.arrayContainer[serviceName] = new GetItemByName();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_item_by_id":
                    this.arrayContainer[serviceName] = new GetItemById();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_pack_by_id":
                    this.arrayContainer[serviceName] = new GetPackById();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_user_by_name":
                    this.arrayContainer[serviceName] = new GetUserByName();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_user_by_id":
                    this.arrayContainer[serviceName] = new GetUserById();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_reservation_by_id":
                    this.arrayContainer[serviceName] = new GetReservationById();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_packs":
                    this.arrayContainer[serviceName] = new GetAllPacks();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_packs_by_string":
                    this.arrayContainer[serviceName] = this.get("get_all_packs");
                    break;
                case "add_pack_to_item":
                    this.arrayContainer[serviceName] = new AddPackToItem();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "delete_pack_to_item":
                    this.arrayContainer[serviceName] = new DeletePackToItem();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "contain_item":
                    this.arrayContainer[serviceName] = new ContainItem();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "update_item":
                    this.arrayContainer[serviceName] = new UpdateItem();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "update_user":
                    this.arrayContainer[serviceName] = new UpdateUser();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "update_pack":
                    this.arrayContainer[serviceName] = new UpdatePack();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "update_reservation":
                    this.arrayContainer[serviceName] = new UpdateReservation();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "delete_item":
                    this.arrayContainer[serviceName] = new DeleteItem();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "delete_user":
                    this.arrayContainer[serviceName] = new DeleteUser();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "delete_pack":
                    this.arrayContainer[serviceName] = new DeletePack();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "delete_reservation":
                    this.arrayContainer[serviceName] = new DeleteReservation();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_items_in_pack":
                    this.arrayContainer[serviceName] = new GetItemsInPack();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "byte_array_to_image":
                    this.arrayContainer[serviceName] = new ByteArrayToImage();
                    break;
                case "get_all_users":
                    this.arrayContainer[serviceName] = new GetAllUsers();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_emprunts":
                    this.arrayContainer[serviceName] = new GetAllEmprunts();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_logs":
                    this.arrayContainer[serviceName] = new GetAllLogs();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_users_by_string":
                    this.arrayContainer[serviceName] = this.get("get_all_users");
                    break;
                case "emprunt_reservation":
                    this.arrayContainer[serviceName] = new EmpruntReservation();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "add_categorie":
                    this.arrayContainer[serviceName] = new AddCategorie();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "add_categorie_to_item":
                    this.arrayContainer[serviceName] = new AddCategorieToItem();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "add_reservation_by_user_id":
                    this.arrayContainer[serviceName] = new ContainReservationByUserId();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_emprunts_by_date":
                    this.arrayContainer[serviceName] = new GetAllEmprunts();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_emprunts_by_string":
                    this.arrayContainer[serviceName] = new GetAllEmprunts();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_items_emprunts":
                    this.arrayContainer[serviceName] = new GetAllItemsEmprunts();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_pack_emprunts":
                    this.arrayContainer[serviceName] = new GetAllPacksEmprunts();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "retour_emprunt":
                    this.arrayContainer[serviceName] = new RetourEmprunt();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "add_mail_config":
                    this.arrayContainer[serviceName] = new AddMailConfig();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "update_mail_config":
                    this.arrayContainer[serviceName] = new UpdateMailConfig();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_categorie_by_id":
                    this.arrayContainer[serviceName] = new GetCategorieById();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_mail_config":
                    this.arrayContainer[serviceName] = new GetMailConfig();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "get_all_categorie":
                    this.arrayContainer[serviceName] = new GetAllCategorie();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "update_categorie":
                    this.arrayContainer[serviceName] = new UpdateCategorie();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;
                case "delete_categorie":
                    this.arrayContainer[serviceName] = new DeleteCategorie();
                    this.arrayContainer[serviceName].setContext(this.get("data_context"));
                    break;

                default:
                    throw new System.Exception();

                
            }
            return this.arrayContainer[serviceName];
        }
    }
}
