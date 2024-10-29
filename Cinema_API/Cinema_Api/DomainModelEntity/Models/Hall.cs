using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class Hall
	{
		[Key]
		public int HallID { get; set; }
		public int HallNumber { get; set; }
		public string? SeatsAmount { get; set; }
		public int TotalSeat { get; set; }
	}
}
