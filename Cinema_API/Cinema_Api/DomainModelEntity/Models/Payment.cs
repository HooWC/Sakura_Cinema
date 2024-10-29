using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelEntity.Models
{
	public class Payment
	{
		[Key]
		public int PaymentID { get; set; }
		public double Amount { get; set; }
		public DateTime Timestamp { get; set; }
		public string? DiscountCode { get; set; }
		public string? TransactionNUm { get; set; }
		public string? PaymentMethod { get; set; }
		public int ReservationID { get; set; }
		public string? CardType { get; set; }
	}
}
