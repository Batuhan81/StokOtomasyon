using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class KargoTakip
	{
		[Key]
		public int kargoId { get; set; }

		public int siparisId { get; set; }
		[ForeignKey("siparisId")]
		public Siparis siparis { get; set; }

		public string FirmaAdi { get; set; }

		public string takipNo { get; set; }

		public DateTime gonderimTarihi { get; set; }

		public DateTime teslimTarihi { get; set; }

		public KargoDurum Durum { get; set; }

		public string aciklama { get; set; }	
	}
	public enum KargoDurum
	{
		Hazirlaniyor,
		KargoyaVerildi,
		Dagitimda,
		TeslimEdildi,
		IadeEdildi,
	}
}
