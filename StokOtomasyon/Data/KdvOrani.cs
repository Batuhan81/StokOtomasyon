using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class KdvOrani
	{
		[Key]
		public int kdvId { get; set; }

		public decimal oran { get; set; }

		public DateTime guncellenmeTarihi { get; set; }
	}
}
