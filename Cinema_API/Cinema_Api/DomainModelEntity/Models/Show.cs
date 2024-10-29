using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class Show
	{
		[Key]
		public int ShowID { get; set; }
		public int HallID { get; set; }
		public int MovieID { get; set; }
		public DateTime Date { get; set; }
		public string? StartTime { get; set; }
		public string? EndTime { get; set; }
		public bool ShowDate { get; set; }
	}
}
