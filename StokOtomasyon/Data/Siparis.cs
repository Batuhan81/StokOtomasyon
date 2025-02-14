using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Compiler.CodeGeneratorResponse.Types;

namespace StokOtomasyon.Data
{
	public class Siparis
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int siparisId { get; set; }

		public int MusteriId { get; set; }
		[ForeignKey("MusteriId")]
		public virtual Musteri Musteri { get; set; }

		public int KullaniciId { get; set; }
		[ForeignKey("KullaniciId")]
		public virtual Kullanici Kullanici { get; set; }

		public DateTime siparisTarihi { get; set; }

		public siparisDurum siparisDurum { get; set; }

		public decimal ToplamTutar { get; set; }

		public bool odemeTamamlandimi { get; set; }

		public int? FaturaId { get; set; }
		[ForeignKey("FaturaId")]
		public virtual Fatura Fatura { get; set; }

		public string aciklama { get; set; }
	}

	public enum siparisDurum
	{
		Beklemede,
		Onaylandi,
		Hazirlaniyor,
		KargoyaVerildi,
		TeslimEdildi,
		IptalEdildi
	}

}
