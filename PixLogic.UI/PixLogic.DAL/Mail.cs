using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("Mail")]
    public class Mail
    {
        public string nameUser { get; set; }
        public string nicknameUser { get; set; }
        public string mailUser { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
        public string subject { get; set; }

        public int MailId { get; set; }
    }
}
