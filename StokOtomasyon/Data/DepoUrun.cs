using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class DepoUrun
	{
		public int DepoId { get; set; }
		[ForeignKey("DepoId")]
		public virtual Depo Depo { get; set; }

		public int UrunId { get; set; }
		[ForeignKey("UrunId")]
		public virtual Urun Urun { get; set; }

		public int stokmiktari { get; set; }

		public int minstok { get; set; }
	}

}
