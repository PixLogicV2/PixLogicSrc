using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("Reservable")]
    public class Reservable
    {
        public Reservable()
        {

        }
        public int ReservableId { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public bool isPack { get; set; }
    }
}
