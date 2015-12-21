using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixLogic.DAL
{
    [Table("Pack")]

    public class Pack : Reservable
    {
            public String description { get; set; }
            public bool dispo { get; set; }
            public bool temp { get; set; }
    }
}
