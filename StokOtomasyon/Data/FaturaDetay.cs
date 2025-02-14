using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class FaturaDetay
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int faturaDetayId { get; set; }

		public int FaturaId { get; set; }
		[ForeignKey("FaturaId")]
		public virtual Fatura Fatura { get; set; }

		public int UrunId { get; set; }
		[ForeignKey("UrunId")]
		public virtual Urun Urun { get; set; }

		public int miktar { get; set; }

		//public decimal birimFiyat { get; set; } //ürün içinde birimfiyat var zaten

		public int KdvId { get; set; }	

		public virtual KdvOrani KdvOrani { get; set; }

		public decimal kdvTutari { get; set; }	

		public decimal toplamTutar { get; set; }
	}

}
