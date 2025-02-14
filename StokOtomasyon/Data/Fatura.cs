using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class Fatura
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int faturaId { get; set; }

		public int MusteriId { get; set; }
		[ForeignKey("MusteriId")]
		public virtual Musteri Musteri { get; set; }

		public DateTime faturaTarihi { get; set; }

		public decimal toplamTutar { get; set; }

		public decimal aratoplam { get; set; }

		public decimal KdvTutari { get; set; }

		public int kdvId { get; set; }

		public virtual KdvOrani KdvOrani { get; set; }

		public Durum faturaDurumu { get; set; }

		[MaxLength(255)]
		public string aciklama { get; set; }

		public bool aktiflik { get; set; }

		public bool odemeDurumu { get; set; }

		// One-to-Many ilişki: Bir fatura birden fazla fatura detayı içerebilir
		public virtual ICollection<FaturaDetay> FaturaDetaylari { get; set; } = new HashSet<FaturaDetay>();
	}
	public enum Durum
	{
		Beklemede,
		Odendi,
		Iptal_Edildi
	}
}
