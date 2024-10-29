using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cinema.API;
using Cinema.Models;

namespace Cinema.ViewModel
{
	public class FunctionVM : INotifyPropertyChanged
	{
		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public string language { get; set; }
		public string Language
		{
			get { return language; }
			set
			{
				if (language != value)
				{
					language = value;
					NotifyPropertyChanged();
				}
			}
		}

		public double ratingStar { get; set; }
		public double RatingStar
		{
			get { return ratingStar; }
			set
			{
				if (ratingStar != value)
				{
					ratingStar = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string age_restrictions { get; set; }
		public string Age_restrictions
		{
			get { return age_restrictions; }
			set
			{
				if (age_restrictions != value)
				{
					age_restrictions = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string title { get; set; }
		public string Title
		{
			get { return title; }
			set
			{
				if (title != value)
				{
					title = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string duration { get; set; }
		public string Duration
		{
			get { return duration; }
			set
			{
				if (duration != value)
				{
					duration = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string description { get; set; }
		public string Description
		{
			get { return description; }
			set
			{
				if (description != value)
				{
					description = value;
					NotifyPropertyChanged();
				}
			}
		}

		public void getMovie(int id)
		{
			MovieDB Moviedb_Detail = new MovieDB();
			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == id).FirstOrDefault();
			Language = movie_data.Language;
			RatingStar = movie_data.RatingStar;
			Age_restrictions = movie_data.Age_restrictions;
			Title = movie_data.Title;
			Duration = movie_data.Duration;
			Description = movie_data.Description;
		}





		public string img { get; set; }
		public string Img
		{
			get { return img; }
			set
			{
				if (img != value)
				{
					img = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string movieTitle { get; set; }
		public string MovieTitle
		{
			get { return movieTitle; }
			set
			{
				if (movieTitle != value)
				{
					movieTitle = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string movieTime { get; set; }
		public string MovieTime
		{
			get { return movieTime; }
			set
			{
				if (movieTime != value)
				{
					movieTime = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string date { get; set; }
		public string Date
		{
			get { return date; }
			set
			{
				if (date != value)
				{
					date = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string cinemaTime { get; set; }
		public string CinemaTime
		{
			get { return cinemaTime; }
			set
			{
				if (cinemaTime != value)
				{
					cinemaTime = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string userid { get; set; }
		public string Userid
		{
			get { return userid; }
			set
			{
				if (userid != value)
				{
					userid = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string hallSeat { get; set; }
		public string HallSeat
		{
			get { return hallSeat; }
			set
			{
				if (hallSeat != value)
				{
					hallSeat = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string amount { get; set; }
		public string Amount
		{
			get { return amount; }
			set
			{
				if (amount != value)
				{
					amount = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string seat { get; set; }
		public string Seat
		{
			get { return seat; }
			set
			{
				if (seat != value)
				{
					seat = value;
					NotifyPropertyChanged();
				}
			}
		}


		public void getTicket(Show show, string seatlist)
		{
			MovieDB Moviedb_Detail = new MovieDB();
			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == show.MovieID).FirstOrDefault();
			UserDB user_Detail = new UserDB();
			var user_db = user_Detail.GetAllUser_One();

			Img = movie_data.MoviePoster;
			MovieTitle = movie_data.Title;
			MovieTime = movie_data.Duration;
			Date = show.Date.ToString().Substring(0, 10);
			CinemaTime = $"{show.StartTime} - {show.EndTime}";
			Userid = $"SCUser-{user_db.UserID}";

			string[] str = seatlist.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			HallSeat = "H: " + show.HallID;
			Seat = "S: " + seatlist;

			int money = str.Count() * 5;
			Amount = $"RM {money.ToString("0.00")}";
		}


	}
}
