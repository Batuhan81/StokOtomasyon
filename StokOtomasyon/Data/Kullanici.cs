using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Kullanici
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int kullaniciId { get; set; }

		[Required]
		[StringLength(30)]
		public string adi { get; set; }

		[StringLength(15)]
		public string soyad { get; set; }

		[StringLength(30)]
		public string eposta { get; set; }

		[StringLength(15)]
		public string telefon { get; set; }

		[Required]
		[StringLength(100)]
		public string sifre { get; set; }

		public bool aktiflik { get; set; }

		public DateTime baslamaTarihi { get; set; }

		public KullaniciRol rol { get; set; }

		// One-to-Many ilişki: Kullanıcı birden fazla Stok Hareketi yapabilir
		public virtual ICollection<StokHareket> StokHareketleri { get; set; } = new HashSet<StokHareket>();
	}

	public enum KullaniciRol
	{
		Admin,
		Depo_Sorumlusu,
		Muhasebe,
		Personel
	}

}
