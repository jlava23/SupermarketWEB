using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }

        public int Pay_Mode { get; set; }
        
    }
}
