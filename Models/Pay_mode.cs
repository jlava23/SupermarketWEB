using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketEF.Models
{
	public class Pay_mode
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Observation { get; set; }
		public Invoice Invoice { get; set; }
	}
}
