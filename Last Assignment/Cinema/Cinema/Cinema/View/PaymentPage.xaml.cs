using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.PopupPage;
using Cinema.ViewModel;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentPage : ContentPage
	{
		public static Show shoedb = new Show();
		public static User userdb = new User();
		public MovieDB Moviedb_Detail = new MovieDB();
		public UserDB user_Detail = new UserDB();
		public static string seatlist_db = null;

		public PaymentPage(Show show, string seatlist)
		{
			InitializeComponent();

			shoedb = show;
			seatlist_db = seatlist;

			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == show.MovieID).FirstOrDefault();
			userdb = user_Detail.GetAllUser_One();

		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			HorizontalList.ItemsSource = new List<Movie>
			{
				new Movie{MovieID = 1 , Title = "Master Card",MoviePoster = "MasterCard"},
				new Movie{MovieID = 2 , Title = "Visa Card",MoviePoster = "VisaCard"},
				new Movie{MovieID = 3 , Title = "PayPal Card",MoviePoster = "PayPalCard"}
			};
			CardType.Text = "Master Card";
			NameType.Text = userdb.FullName;

		}


		private void ChangedTheName(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			var x = HorizontalList.SelectedIndex;
			if (x == 0)
			{
				CardType.Text = "Master Card";
			}
			else if (x == 1)
			{
				CardType.Text = "Visa Card";
			}
			else if (x == 2)
			{
				CardType.Text = "Paypal Card";
			}
		}

		private async void PopupPayment(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			PopupNavigation.PushAsync(new PaymentPopup(seatlist_db, shoedb, CardType.Text, CNumber.Value));

		}
	}
}