using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieTuneSearchPage : ContentPage
	{
		public MovieTuneSearchPage(string list)
		{
			InitializeComponent();

			List<string> seatdata_list = new List<string>();
			string[] str = list.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			seatdata_list.AddRange(str);

			PromotionList2.ItemsSource = seatdata_list;

			MovieDB movie = new MovieDB();
			var movieall = movie.GetAllMovie();
			var keywordsToFind = seatdata_list;

			//var foundMovies = movieall.Where(x =>
			//	keywordsToFind.Any(keyword => x.Genre.Contains(keyword)))
			//	.ToList();

			var foundMovies = movieall.Where(x =>
							  keywordsToFind.All(keyword => x.Genre.Contains(keyword))).ToList();


			MediaList.ItemsSource = foundMovies;

			if (foundMovies.Count == 0)
			{
				ImgNoSearch.IsVisible = true;
				Scroll.IsVisible = false;
			}
			else
			{
				ImgNoSearch.IsVisible = false;
				Scroll.IsVisible = true;
			}

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();



		}

		private void Back(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		private async void MovieHot(object sender, EventArgs e)
		{
			await ((Frame)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Frame)sender).ScaleTo(1, 10, Easing.Linear);

			var Element = sender as Frame;
			var value = Element.GestureRecognizers[0] as TapGestureRecognizer;

			var data = value.CommandParameter.ToString();

			Navigation.PushAsync(new MovieDetailPage(Convert.ToInt32(data)));
		}
	}
}