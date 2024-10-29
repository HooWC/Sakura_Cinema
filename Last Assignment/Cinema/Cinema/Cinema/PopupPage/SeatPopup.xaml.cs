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
	public partial class SeatPopup
	{
		public static Show shoedb = new Show();
		public MovieDB Moviedb_Detail = new MovieDB();
		public static string seatlist_db = null;

		public SeatPopup(string seatList, Show show)
		{
			InitializeComponent();
			shoedb = show;

			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == show.MovieID).FirstOrDefault();

			MovieTitle.Text = movie_data.Title;
			seatlist_db = seatList;

			string[] str = seatList.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			SeatText.Text = $"You have {str.Count()} reservations";
			int money = str.Count() * 5;
			MoneyName.Text = $"RM {money.ToString("0.00")}";
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
			Navigation.PushAsync(new TicketPage(shoedb, seatlist_db));

		}
	}
}