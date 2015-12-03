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
        public string name;
        public string text;
        
        public int RequeteId { get; set; }
    }
} 
