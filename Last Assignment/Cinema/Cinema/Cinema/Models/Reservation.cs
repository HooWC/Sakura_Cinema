using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
	public class Reservation
	{
		public int ReservationID { get; set; }
		public bool Active { get; set; }
		public string ReservationCode { get; set; }
		public int UserID { get; set; }
		public int ShowID { get; set; }
	}
}
