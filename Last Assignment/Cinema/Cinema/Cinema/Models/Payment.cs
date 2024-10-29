using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
	public class Payment
	{
		public int PaymentID { get; set; }
		public double Amount { get; set; }
		public DateTime Timestamp { get; set; }
		public string DiscountCode { get; set; }
		public string TransactionNUm { get; set; }
		public string PaymentMethod { get; set; }
		public int ReservationID { get; set; }
		public string CardType { get; set; }
	}
}
