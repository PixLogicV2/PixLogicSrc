using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixLogic.DAL
{
    [Table("Categorie")]
    public class Categorie
    {
        public string name { get; set; }
        public int level { get; set; }
    }
}
