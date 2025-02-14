using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyon.Data
{
	public class OdemeTaksit
	{
		[Key]
		public int taksitId { get; set; }	

		public int OdemeId { get; set; }
		[ForeignKey("OdemeId")]
		public virtual Odeme Odeme { get; set; }

		public int taksitNo {  get; set; }

		public decimal taksitTutar { get; set; }
		
		public DateTime sonOdemeTarih { get; set; }

		public bool odendiMi { get; set; }
	}
}
