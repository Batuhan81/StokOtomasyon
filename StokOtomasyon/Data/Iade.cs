using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Iade
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int iadeId { get; set; }

		public int MusteriId { get; set; }
		[ForeignKey("MusteriId")]
		public virtual Musteri Musteri { get; set; }

		public int KullaniciId { get; set; }
		[ForeignKey("KullaniciId")]
		public virtual Kullanici Kullanici { get; set; }

		public int SiparisId { get; set; }
		[ForeignKey("SiparisId")]
		public virtual Siparis Siparis { get; set; }

		public DateTime iadeTarihi { get; set; }

	}

}
