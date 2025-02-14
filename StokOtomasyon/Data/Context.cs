using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))] // MySQL için gerekli!
	public class Context : DbContext
	{
		public Context() : base("Context") // Config'deki ConnectionString adı
		{
		}
		DbSet<Kategori> kategoriler { get; set; }
		DbSet<Urun> urunler { get; set; }
		DbSet<KdvOrani> KdvOranlari { get; set; }

		//MySql Decimal(18,2) ifadesini böyle kabul etmediğinde bu şekilde yapıldı
		/*[Column(TypeName = "decimal(18,2)")]
        public decimal birimFiyat { get; set; }*/
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// Decimal türü için hassasiyet (precision) ayarı
			modelBuilder.Entity<KdvOrani>()
				.Property(k => k.oran)
				.HasPrecision(18, 2);
			modelBuilder.Entity<Urun>()
				.Property(k => k.birimFiyat)
				.HasPrecision(18, 2);
			modelBuilder.Entity<UrunFiyatGecmisi>()
				.Property(k => k.eskifiyat)
				.HasPrecision(18, 2);
			modelBuilder.Entity<UrunFiyatGecmisi>()
				.Property(k => k.yenifiyat)
				.HasPrecision(18, 2);

			base.OnModelCreating(modelBuilder);
		}
	}
}
