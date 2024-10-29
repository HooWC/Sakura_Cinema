using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
	public class SeatReservation
	{
		public int SeatReservationID { get; set; }
		public int ReservationID { get; set; }
		public string NumberOfSeats { get; set; }
		public bool Paid { get; set; }
		public bool Active { get; set; }
		public int UserID { get; set; }
	}
}
