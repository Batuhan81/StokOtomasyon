using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Kategori
	{
		[Key]
		public int Id { get; set; }

		public string adi { get; set; }

		public bool aktiflik { get; set; }

		public DateTime eklenmeTarihi { get; set; }
		// İlişkiler
		public virtual ICollection<Urun> Urunler { get; set; }

		public Kategori()
		{
			Urunler = new HashSet<Urun>();
		}
	}
}
