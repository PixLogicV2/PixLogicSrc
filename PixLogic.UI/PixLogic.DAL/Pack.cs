using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("Pack")]

    public class Pack : Reservable
    {

            public String name { get; set; }
            public String description { get; set; }
            public bool dispo { get; set; }
            public float price { get; set; }
    }
}
