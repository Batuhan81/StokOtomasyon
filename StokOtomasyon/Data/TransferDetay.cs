using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class TransferDetay
	{
		[Key]
		public int detayId { get; set; }

		public int transferId { get; set; }
		[ForeignKey("transferId")]
		public DepoTransfer DepoTransfer { get; set; }

		public int urunId { get; set; }
		[ForeignKey("urunId")]
		public Urun urun { get; set; }

		public int miktar { get; set; }

	}
}
