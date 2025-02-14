using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class DepoYetkili
	{
		[Key]
		public int depoYetkiliId { get; set; }
		[ForeignKey("depoId")]
		public int depoId { get; set; }

		public virtual Depo Depo { get; set; }
		[ForeignKey("kullaniciId")]
		public int kullaniciId { get; set; }

		public virtual Kullanici Kullanici { get; set; }
	}
}
