using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixLogic.DAL
{
    [Table("User")]
    public class User
    {
        public string name { get; set; }
        public string nickname { get; set; }
        public string mail { get; set; }
        public string phoneNumber { get; set; }
        public byte[] image { get; set; }
        public int credits { get; set; }

        public UserClass userClass { get; set; }
        public int UserId { get; set; }
    }
}
