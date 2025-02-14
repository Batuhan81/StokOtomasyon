using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class KategoriUrun//Bir ürün birden fazla kategoride olabilir aynı şekilde bir kategoride birden fazla üründe bulunabilir
	{
		[Key]
		public int Id { get; set; }

		public int KategoriId { get; set; }
		[ForeignKey("KategoriId")]
		public virtual Kategori Kategori { get; set; }

		public int UrunId { get; set; }
		[ForeignKey("UrunId")]
		public virtual Urun Urun { get; set; }

	}
}
