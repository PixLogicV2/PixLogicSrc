using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("Log")]
    public class Log
    {
        public int LogId { get; set; }

        public bool isPack { get; set; }

        public DateTime? beginDateEmprunt { get; set; }
        public DateTime? endDateEmprunt { get; set; }

        public string userName { get; set; }
        public string userNickname { get; set; }
        public string userMail { get; set; }
        public string userClasse { get; set; }
        public string userPhoneNumber { get; set; }
        public string managerName { get; set; }

        public string reservableName { get; set; }
        
    }
}
