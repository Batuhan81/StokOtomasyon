using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class UrunTedarikci
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int urunTedarikId { get; set; }

		public int UrunId { get; set; }
		[ForeignKey("UrunId")]
		public virtual Urun Urun { get; set; }

		public int TedarikciId { get; set; }
		[ForeignKey("TedarikciId")]
		public virtual Tedarikci Tedarikci { get; set; }

		public decimal fiyat { get; set; }//Aynı ürün farklı Tedarikçilerde farklı fiyatla satılabilir her tedarikçi kaçtan satıyor o değer gelecek
	}

}
