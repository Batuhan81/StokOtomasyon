using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class UrunFiyatGecmisi
	{
		[Key]
		public int fiyatgecmisiId { get; set; }

		[ForeignKey("UrunId")]
		public int urunId { get; set; }

		public decimal eskifiyat {  get; set; }

		public decimal yenifiyat {  get; set; }

		public DateTime degisimTarihi { get; set; }

		public virtual Urun Urun { get; set; }
	}
}
