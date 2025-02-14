using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Tedarikci
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int tedarikciId { get; set; }

		[Required]
		[StringLength(50)]
		public string firmaAdi { get; set; }

		[StringLength(50)]
		public string yetkiliAdi { get; set; }

		[StringLength(15)]
		public string telefon { get; set; }

		[StringLength(30)]
		public string eposta { get; set; }

		[StringLength(255)]
		public string adres { get; set; }

		[StringLength(10)]
		public string vergino { get; set; }

		public bool aktiflik { get; set; }

		public DateTime olusturmaTarihi { get; set; }

		// Many-to-Many ilişki: Tedarikçi ile Ürünler arasında bir ilişki
		public virtual ICollection<UrunTedarikci> UrunTedarikcis { get; set; } = new HashSet<UrunTedarikci>();
	}

}
