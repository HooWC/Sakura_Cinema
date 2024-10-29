using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class Reservation
	{
		[Key]
		public int ReservationID { get; set; }
		public bool Active { get; set; }
		public string? ReservationCode { get; set; }
		public int UserID { get; set; }
		public int ShowID { get; set; }
	}
}
