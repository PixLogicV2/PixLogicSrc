using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixLogic.DAL
{
    [Table("Requete")]
    public class Requete
    {
        public string name { get; set; }
        public string text { get; set; }
        
        public int RequeteId { get; set; }
    }
} 
