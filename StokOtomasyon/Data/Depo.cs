using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Depo
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int depoId { get; set; }

		[Required]
		[StringLength(20)]
		public string adi { get; set; }

		[StringLength(255)]
		public string adres { get; set; }

		public bool aktiflik { get; set; }

		public DateTime olusturmaTarihi { get; set; }

		// Many-to-Many ilişki: Depo ile Ürünler arasında bir ilişki
		public virtual ICollection<DepoUrun> DepoUrunler { get; set; } = new HashSet<DepoUrun>();
	}

}
