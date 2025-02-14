using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Urun
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int urunId { get; set; }

		//[ForeignKey("Kategori")]// çoka çok ilişki kurdum ondan dolayı kaldırdum
		//public int kategoriId { get; set; }

		[Required]
		[StringLength(100)]
		public string Adi { get; set; }

		[MaxLength(20)]
		public string kodu { get; set; }

		[MaxLength(255)]
		public string qr { get; set; }

		public string foto { get; set; }

		public decimal birimFiyat { get; set; }

		public bool kdvdahil { get; set; }

		// Tüm depolardaki genel stok
		public int mevcutstok { get; set; }

		[ForeignKey("KdvOrani")]
		public int kdvId { get; set; }

		public Birim birim { get; set; }

		public DateTime olusturmaTarihi { get; set; }

		public bool aktiflik { get; set; }

		// Navigation properties
		// Many-to-Many ilişki: Ürün birden fazla kategoriye ait olabilir
		public virtual ICollection<KategoriUrun> KategoriUrunler { get; set; } = new HashSet<KategoriUrun>();
		public virtual KdvOrani KdvOrani { get; set; }
	}

	public enum Birim
	{
		Kg,
		Lt,
		Adet,
		Paket
	}
}
