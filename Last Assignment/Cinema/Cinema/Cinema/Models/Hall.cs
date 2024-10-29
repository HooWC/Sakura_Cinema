using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
	public class Hall
	{
		public int HallID { get; set; }
		public int HallNumber { get; set; }
		public string SeatsAmount { get; set; }
		public int TotalSeat { get; set; }
	}
}
