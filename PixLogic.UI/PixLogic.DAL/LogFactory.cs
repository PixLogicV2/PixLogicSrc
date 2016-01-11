using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    public class LogFactory
    {
        private DataContext context;

        public void setContext(DataContext context)
        {
            this.context = context;
        }

        public Log build(bool isPack, DateTime? beginDateEmprunt, DateTime? endDateEmprunt, string userName, string userNickname, string userMail, string userClasse, string userPhoneNumber, string reservableName,string managerName)
        {
            Log reservation = new Log();

            reservation.isPack = isPack;
            reservation.beginDateEmprunt = beginDateEmprunt;
            reservation.endDateEmprunt = endDateEmprunt;
            reservation.userName = userName;
            reservation.userNickname = userNickname;
            reservation.userMail = userMail;
            reservation.userClasse = userClasse;
            reservation.userPhoneNumber = userPhoneNumber;
            reservation.reservableName =reservableName;
            reservation.managerName = managerName;

            return reservation;
        }
    }
}
