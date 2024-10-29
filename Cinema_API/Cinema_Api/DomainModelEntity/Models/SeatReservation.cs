using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class SeatReservation
	{
		[Key]
		public int SeatReservationID { get; set; }
		public int ReservationID { get; set; }
		public string? NumberOfSeats { get; set; }
		public bool Paid { get; set; }
		public bool Active { get; set; }
		public int UserID { get; set; }
	}
}
