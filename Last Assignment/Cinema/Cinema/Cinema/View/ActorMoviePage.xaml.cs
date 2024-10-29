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
	public partial class ActorMoviePage : ContentPage
	{
		public ActorMoviePage(Actor actor)
		{
			InitializeComponent();

			MovieDB movie = new MovieDB();
			var data = movie.GetAllMovie();
			var find = data.Where(x => x.Actor.Contains(actor.ActorName)).ToList();
			avatar.Source = actor.ActorImage;
			Name.Text = actor.ActorName;
			MediaList.ItemsSource = find;


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