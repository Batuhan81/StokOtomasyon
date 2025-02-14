using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Kategori
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string adi { get; set; }

		public bool aktiflik { get; set; }

		public DateTime eklenmeTarihi { get; set; }
		// Many-to-Many ilişki: Kategorinin birden fazla ürünü olabilir
		public virtual ICollection<KategoriUrun> KategoriUrunler { get; set; } = new HashSet<KategoriUrun>();

		
	}
}
