using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Odeme
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int odemeId { get; set; }

		public int faturaId { get; set; }
		[ForeignKey("faturaId")]
		public virtual Fatura Fatura { get; set; }

		public int SiparisId { get; set; }
		[ForeignKey("SiparisId")]
		public virtual Siparis Siparis { get; set; }

		public int odemeyiAlanId { get; set; }
		[ForeignKey("odemeyiAlanId")]
		public virtual Kullanici Kullanici { get; set; }

		public int musteriId { get; set; }
		[ForeignKey("musteriId")]
		public virtual Musteri Musteri { get; set; }

		public Yontem yontem { get; set; }

		public decimal tutar { get; set; }

		public DateTime odemeTarihi { get; set; }

		public bool odemeDurumu { get; set; }


		[StringLength(255)]
		public string aciklama { get; set; }

		public bool taksitmi { get; set; }

	}
	public enum Yontem
	{
		Nakit,
		Kart,
		Havale,
		Cek,
		Senet,
		AltıTaksit,
	}
}
