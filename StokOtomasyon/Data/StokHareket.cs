using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class StokHareket
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int hareketId { get; set; }

		public int DepoId { get; set; }
		[ForeignKey("DepoId")]
		public virtual Depo Depo { get; set; }

		public int UrunId { get; set; }
		[ForeignKey("UrunId")]
		public virtual Urun Urun { get; set; }

		public int miktar { get; set; }

		public DateTime tarih { get; set; }

		public IslemTuru islemTuru { get; set; }

		public int KullaniciId { get; set; }
		[ForeignKey("KullaniciId")]
		public virtual Kullanici Kullanici { get; set; }
	}

	public enum IslemTuru
	{
		Iade,
		Satis,
		Duzenleme,
		Tedarik,
		TransferCikti,
		TransferGirdi,
		Zahiyat
	}

}
