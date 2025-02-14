using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Kargo
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int kargoId { get; set; }

		public int SiparisId { get; set; }
		[ForeignKey("SiparisId")]
		public virtual Siparis Siparis { get; set; }

		public string kargoFirmasi { get; set; }

		public string takipNo { get; set; }

		public DateTime gonderimTarihi { get; set; }

		public DateTime? teslimTarihi { get; set; }

		public bool kargoDurumu { get; set; } // Örneğin, teslim edildi mi?
	}

}
