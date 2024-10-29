using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.View;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.PopupPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarPopup
	{
		public MovieDB Moviedb_Detail = new MovieDB();
		public ShowDB Showdb_Detail = new ShowDB();
		public static Show showdb = new Show();

		public CalendarPopup(Show db)
		{
			InitializeComponent();
			showdb = db;

			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == db.MovieID).FirstOrDefault();
			MovieName.Text = movie_data.Title;
			DateText.Text = db.Date.ToString().Substring(0, 10);
			Time.Text = $"{db.StartTime} - {db.EndTime}";
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			PopupNavigation.PopAsync();
		}

		private async void Button_Clicked_1(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			PopupNavigation.PopAsync();
			Navigation.PushAsync(new SeatPage(showdb));
		}

	}
}