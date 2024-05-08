﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Invoice
    {
        public int Id { get; set; } //Será la llave primaria
        public int Number { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public int PaymodeId { get; set; }//Será la llave foranea
        public PayMode? PayModes { get; set; } // Propiedad de navegación 
    }
}
