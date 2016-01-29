using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("Item")]
    public class  Item : Reservable
    {
        public String description { get; set; }
        public bool dispo { get; set; }
        public byte[] image { get; set; }
        public String reference { get; set; }
        public int quantity { get; set; }
        
        public Pack pack { get; set; }
        public Categorie categorie { get; set; }
    }
}
