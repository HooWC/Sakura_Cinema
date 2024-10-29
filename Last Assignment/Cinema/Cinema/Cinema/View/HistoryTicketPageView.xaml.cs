using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HistoryTicketPageView : ContentPage
	{
		public static Show shoedb = new Show();
		public MovieDB Moviedb_Detail = new MovieDB();
		public UserDB user_Detail = new UserDB();
		public static string seatlist_db = null;

		public HistoryTicketPageView(Show show, string seatlist)
		{
			InitializeComponent();

			shoedb = show;

			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == show.MovieID).FirstOrDefault();
			var user_db = user_Detail.GetAllUser_One();

			img.Source = movie_data.MoviePoster;
			MovieTitle.Text = movie_data.Title;
			MovieTime.Text = movie_data.Duration;
			Date.Text = show.Date.ToString().Substring(0, 10);
			CinemaTime.Text = $"{show.StartTime} - {show.EndTime}";

			userid.Text = $"SCUser-{user_db.UserID}";
			seatlist_db = seatlist;

			string[] str = seatlist.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			Hall.Text = "H: " + show.HallID;
			Seat.Text = "S: " + seatlist;

			int money = str.Count() * 5;
			amount.Text = $"RM {money.ToString("0.00")}";

		}

		private async void Back(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			Navigation.PopAsync();
		}
	}
}