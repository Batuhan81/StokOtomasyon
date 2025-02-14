using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class DepoTransfer
	{
		[Key]
		public int transferId { get; set; }

		public int gonderenDepoId { get; set; }
		[ForeignKey("gonderenDepoId")]
		public virtual Depo gonderenDepo { get; set; }

		public int alanDepoId { get; set; }
		[ForeignKey("alanDepoId")]
		public virtual Depo alanDepo { get; set; }

		public int onaylayanKullaniciId { get; set; }
		[ForeignKey("onaylayanKullaniciId")]
		public virtual Kullanici Kullanici { get; set; }

		public TransferDurum durum { get; set; }

	}
	public enum TransferDurum
	{
		Beklemede,
		Onaylandi,
		Yolda,
		TeslimEdildi,
		İptalEdildi,
	}
}
