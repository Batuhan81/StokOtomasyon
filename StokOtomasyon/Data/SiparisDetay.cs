using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class SiparisDetay
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int siparisDetayId { get; set; }

		public int SiparisId { get; set; }
		[ForeignKey("SiparisId")]
		public virtual Siparis Siparis { get; set; }

		public int UrunId { get; set; }
		[ForeignKey("UrunId")]
		public virtual Urun Urun { get; set; }

		public int KdvId { get; set; }
		[ForeignKey("KdvId")]
		public virtual KdvOrani KdvOrani { get; set; }

		public decimal KdvTutari { get; set; }
		//public decimal birimFiyat { get; set; }//Urun içinden alınacak

		public int miktar { get; set; }

		public decimal toplamTutar { get; set; }
	}

}
