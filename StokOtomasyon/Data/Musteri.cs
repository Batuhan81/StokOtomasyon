using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Musteri
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int musteriId { get; set; }

		[Required]
		[StringLength(100)]
		public string adi { get; set; }

		[StringLength(100)]
		public string soyad { get; set; }

		[StringLength(50)]
		public string telefon { get; set; }

		[StringLength(50)]
		public string eposta { get; set; }

		[StringLength(10)]
		public string vergino { get; set; }

		[StringLength(50)]
		public string vergiDairesi { get; set; }

		public bool kurumsalmi { get; set; }

		[StringLength(255)]
		public string adres { get; set; }

		public DateTime kayitTarihi { get; set; }

		public bool aktiflik { get; set; }

		// Many-to-Many ilişki: Müşteri ile Siparişler arasında bir ilişki
		public virtual ICollection<Siparis> Siparisler { get; set; } = new HashSet<Siparis>();
	}

}
