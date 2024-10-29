using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.ViewModel;
using FFImageLoading.Helpers.Gif;
using Syncfusion.XForms.Buttons;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MovieDetailPage : ContentPage
	{

		public MovieDB Moviedb_Detail = new MovieDB();
		public ActorDB Actor_Detail = new ActorDB();
		public DirectorDB Director_Detail = new DirectorDB();
		public static int id = 0;
		public static FunctionVM vm = new FunctionVM();

		public MovieDetailPage(int MovieID)
		{
			InitializeComponent();
			vm.getMovie(MovieID);
			BindingContext = vm;

			id = MovieID;

			var actor_db = Actor_Detail.GetAllActor_User();
			var director_db = Director_Detail.GetAllDirector_User();
			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == MovieID).FirstOrDefault();
			var link = movie_data.MovieTrailerLink;


			List<string> ds = new List<string>()
			{
				"<iframe src=\"https://www.youtube.com/embed/yjRHZEUamCc?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/9ix7TUGVYIo?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/WEQFbyUJjHA?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/9VykIypb_x0?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/-ziu6JzJTZ0?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/01ON04GCwKs?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/3BhsrCKEQDE?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/_hL0sAde1DA?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/4cvIV-Gx-R4?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/nPlFzfELxME?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/jhx-vpcgkMM?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/S_qZTk9109Q?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/gFowzp3b4uQ?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/DQmjwwQxtHU?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/yOfaCTrbGq4?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/2AUmvWm5ZDQ?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/3HSzDXPiCP8?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/-1Pb47teN2E?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/tBzfZORwu2s?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>",
				"<iframe src=\"https://www.youtube.com/embed/SribMKGqDAk?autoplay=1&mute=1&controls=0\" allowtransparency=\"true\" style=\"-webkit-transform:scale(1.085);-moz-transform-scale(1.085);overflow: hidden;\" height=\"100%\" width=\"100%\" frameborder=\"0\" marginwidth=\"0\" marginheight=\"0\" hspace=\"0\" vspace=\"0\" scrolling=\"no\" style=\"border: none;\"></iframe>"
			};


			var htmlsource = new HtmlWebViewSource();
			htmlsource.Html = ds[movie_data.MovieID - 1];
			TrailerDisplay.Source = htmlsource;

			List<string> list_inter = new List<string>();
			string[] str = movie_data.Genre.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			list_inter.AddRange(str);

			dataFind.ItemsSource = list_inter;

			List<string> Actor_Name = new List<string>();
			string[] str2 = movie_data.Actor.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			Actor_Name.AddRange(str2);

			List<Actor> actor_data = new List<Actor>();
			foreach (var i in Actor_Name)
			{
				var data = actor_db.Where(x => x.ActorName == i).FirstOrDefault();
				if (data != null)
				{
					actor_data.Add(data);
				}
			}

			List<Director> Drector_List = new List<Director>();
			var data_Drector = director_db.Where(x => x.DirectorName == movie_data.Director).ToList();
			foreach (var i in data_Drector)
			{
				Drector_List.Add(i);
			}

			ActorCast.ItemsSource = actor_data;
			DirectorCart.ItemsSource = Drector_List;

		}

		private async void MoveCalendar(object sender, EventArgs e)
		{
			await ((Frame)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Frame)sender).ScaleTo(1, 10, Easing.Linear);

			await Navigation.PushAsync(new CalendarPage(id));

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