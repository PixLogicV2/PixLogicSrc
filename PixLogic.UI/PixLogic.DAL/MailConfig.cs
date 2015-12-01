using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("MailConfig")]
    public class MailConfig
    {
        public string serveurStmp { get; set; }
        public int port { get; set; }
        public string email { get; set; }
        public string mdp { get; set; }

        public int MailConfigId { get; set; }
    }
}
