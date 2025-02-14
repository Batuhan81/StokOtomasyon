using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class IadeDetay
	{
		[Key]
		public int detayId { get; set; }

		public int iadeId { get; set; }
		[ForeignKey("iadeId")]
		public virtual Iade Iade { get; set; }

		public int urunId { get; set; }
		[ForeignKey("urunId")]
		public virtual Urun Urun { get; set; }

		public int miktar { get; set; }

		public decimal tutar { get; set; }

		public bool stokguncellensinMi { get; set; }

		public UrunDurum durum { get; set; }
	}

	public enum UrunDurum
	{
		Arizali,
		Hasarli,
		Eksikparca,
		Kullanilmis,
		YanlisUrun
	}
}
