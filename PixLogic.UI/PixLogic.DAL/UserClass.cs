using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
        [Table("UserClass")]
        public class UserClass
        {
            public string name { get; set; }
            public int credits { get; set; }
            public int UserClassId { get; set; }
            
        }
}
