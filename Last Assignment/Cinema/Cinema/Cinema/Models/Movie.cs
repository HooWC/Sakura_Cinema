using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Models
{
	public class Movie
	{
		public int MovieID { get; set; }
		public string Title { get; set; }
		public string MoviePoster { get; set; }
		public string Genre { get; set; }
		public string Actor { get; set; }
		public string Director { get; set; }
		public string Language { get; set; }
		public string Age_restrictions { get; set; }
		public string Duration { get; set; }
		public string Description { get; set; }
		public string MovieTrailerLink { get; set; }
		public double RatingStar { get; set; }

	}
}
