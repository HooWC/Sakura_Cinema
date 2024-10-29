using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.PopupPage;
using Cinema.ViewModel;
using OneSignalSDK.Xamarin;
using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public static UserVM us = new UserVM();
		//public MovieDB moviedb = new MovieDB();

		public HomePage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			UserDB userdbdata = new UserDB();
			var one_user = userdbdata.GetAllUser_One();
			if (one_user.OneSignalOpen == true)
			{
				notificationimg.Source = "NotificationIcon";
			}
			else
			{
				notificationimg.Source = "NoNotificationIcon";
			}

			List<Movie> MovieListData = new List<Movie>()
			{
				new Movie(){Title = "Action",Genre = "#cf1d46",Duration="#ffffff"},
				new Movie(){Title = "Horror",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Love",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Thriller",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Comedy",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Sci-Fi",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "War",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Crime",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Adventure",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Disaster",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Drama",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Classic",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Homosexual",Genre = "#f0eded",Duration="#9e9e9e"},
			};

			PromotionList.ItemsSource = MovieListData;

			//var movielist = UserVM.MovieList.Where(x => x.Genre.Contains("Action")).Take(6).ToList();
			//var dataFind = (from c in movielist
			//				)


			MediaList.ItemsSource = UserVM.MovieList.Where(x => x.Genre.Contains("Action")).Take(6).ToList();
			int count = UserVM.MovieList.Where(x => x.Genre.Contains("Action")).Take(6).ToList().Count;
			MediaList_SizeChanged(count);

			var allMovie = UserVM.MovieList.Where(x => x.Genre.Contains("Action")).ToList();

			List<string[]> list_inter = new List<string[]>();

			foreach (var i in allMovie)
			{
				string[] str = i.Genre.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
				list_inter.Add(str);
			}

			int num_inter = 0;

			var db = (from c in allMovie
					  select new
					  {
						  MovieID = c.MovieID,
						  list_inter = list_inter,
						  Genre = list_inter[num_inter++],
						  Title = c.Title,
						  Duration = c.Duration,
						  MovieTrailerLink = c.MovieTrailerLink,
						  MoviePoster = c.MoviePoster,
						  RatingStar = c.RatingStar,
						  Description = c.Description,
						  Director = c.Director,
					  }).ToList();

			PromotionList2.ItemsSource = MovieListData;
			MediaList2.ItemsSource = db;

		}

		private void MediaList_SizeChanged(int numberOfItems)
		{
			double collectionViewWidth = MediaList.Width;

			double itemWidth = (collectionViewWidth - (2 * 6)) / 2;

			double rows = Math.Ceiling((double)numberOfItems / 2);
			double collectionViewHeight = (itemWidth * rows) + (rows - 1) * 22;

			double additionalHeight = 50;
			collectionViewHeight += additionalHeight;

			MediaList.HeightRequest = collectionViewHeight;
		}


		private async void Follow(object sender, EventArgs e)
		{
			await ((StackLayout)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((StackLayout)sender).ScaleTo(1, 10, Easing.Linear);

			var Element = sender as StackLayout;
			var value = Element.GestureRecognizers[0] as TapGestureRecognizer;

			var data = value.CommandParameter.ToString();

			List<Movie> moviedataGrene = new List<Movie>()
			{
				new Movie(){Title = "Action",Genre = "#cf1d46",Duration="#ffffff"},
				new Movie(){Title = "Horror",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Love",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Thriller",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Comedy",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Sci-Fi",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "War",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Crime",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Adventure",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Disaster",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Drama",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Classic",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Homosexual",Genre = "#f0eded",Duration="#9e9e9e"},
			};

			List<Movie> NewmoviedataGrene = new List<Movie>();

			foreach (var i in moviedataGrene)
			{
				if (data == i.Title)
				{
					i.Duration = "#ffffff";
					i.Genre = "#cf1d46";
				}
				else
				{
					i.Duration = "#9e9e9e";
					i.Genre = "#f0eded";
				}
				NewmoviedataGrene.Add(i);
			}

			PromotionList.ItemsSource = NewmoviedataGrene;


			MediaList.ItemsSource = UserVM.MovieList.Where(x => x.Genre.Contains(data)).Take(6).ToList();
			int count = UserVM.MovieList.Where(x => x.Genre.Contains(data)).Take(6).ToList().Count;
			MediaList_SizeChanged(count);

		}

		private async void OpenTenu(object sender, EventArgs e)
		{
			await ((Frame)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Frame)sender).ScaleTo(1, 10, Easing.Linear);

			PopupNavigation.PushAsync(new OpenTenuPopup());

		}

		private async void NotificationOpen(object sender, EventArgs e)
		{
			await ((Frame)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Frame)sender).ScaleTo(1, 10, Easing.Linear);

			UserDB userdata_check = new UserDB();
			var usernotification = userdata_check.GetAllUser_One();
			if (usernotification.OneSignalOpen == true)
			{
				usernotification.OneSignalOpen = false;
			}
			else
			{
				usernotification.OneSignalOpen = true;
			}
			await userdata_check.EditUser(usernotification);


			//UserDB userdbdata = new UserDB();
			//var one_user = userdbdata.GetAllUser_One();
			if (usernotification.OneSignalOpen == true)
			{
				notificationimg.Source = "NotificationIcon";
			}
			else
			{
				notificationimg.Source = "NoNotificationIcon";
			}


			//if (usernotification.OneSignalOpen == true)
			//{



			//	var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

			//	request.KeepAlive = true;
			//	request.Method = "POST";
			//	request.ContentType = "application/json; charset=utf-8";

			//	var OneSignalID = OneSignal.Default.PushSubscriptionState.userId;


			//	List<string> Lists = new List<string>();

			//	Lists.Add(OneSignalID);

			//	string format = "";

			//	foreach (var i in Lists)
			//	{
			//		format += $"\"{i}\",";
			//	}

			//	var x = $"[{format.Remove(format.Length - 1)}]";

			//	byte[] byteArray = Encoding.UTF8.GetBytes("{"
			//											+ "\"app_id\": \"aa0150b5-ea7a-4d62-812e-3f7aaabaae5b\","
			//											+ "\"contents\": {\"en\": \"" + $"You've successfully turned off notifications!" + "\"},"
			//											+ "\"headings\": {\"en\": \"Sakura Cinema\"},"
			//											+ $"\"include_player_ids\":" + x + "}");

			//	string responseContent = null;

			//	try
			//	{
			//		using (var writer = request.GetRequestStream())
			//		{
			//			writer.Write(byteArray, 0, byteArray.Length);
			//		}

			//		using (var response = request.GetResponse() as HttpWebResponse)
			//		{
			//			using (var reader = new StreamReader(response.GetResponseStream()))
			//			{
			//				responseContent = reader.ReadToEnd();
			//			}
			//		}
			//	}
			//	catch (WebException ex)
			//	{
			//		System.Diagnostics.Debug.WriteLine(ex.Message);
			//		System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
			//	}

			//	System.Diagnostics.Debug.WriteLine(responseContent);

			//}
			//else
			//{

			//	var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

			//	request.KeepAlive = true;
			//	request.Method = "POST";
			//	request.ContentType = "application/json; charset=utf-8";

			//	var OneSignalID = OneSignal.Default.PushSubscriptionState.userId;


			//	List<string> Lists = new List<string>();

			//	Lists.Add(OneSignalID);

			//	string format = "";

			//	foreach (var i in Lists)
			//	{
			//		format += $"\"{i}\",";
			//	}

			//	var x = $"[{format.Remove(format.Length - 1)}]";

			//	byte[] byteArray = Encoding.UTF8.GetBytes("{"
			//											+ "\"app_id\": \"aa0150b5-ea7a-4d62-812e-3f7aaabaae5b\","
			//											+ "\"contents\": {\"en\": \"" + $"You've successfully open notifications!" + "\"},"
			//											+ "\"headings\": {\"en\": \"Sakura Cinema\"},"
			//											+ $"\"include_player_ids\":" + x + "}");

			//	string responseContent = null;

			//	try
			//	{
			//		using (var writer = request.GetRequestStream())
			//		{
			//			writer.Write(byteArray, 0, byteArray.Length);
			//		}

			//		using (var response = request.GetResponse() as HttpWebResponse)
			//		{
			//			using (var reader = new StreamReader(response.GetResponseStream()))
			//			{
			//				responseContent = reader.ReadToEnd();
			//			}
			//		}
			//	}
			//	catch (WebException ex)
			//	{
			//		System.Diagnostics.Debug.WriteLine(ex.Message);
			//		System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
			//	}

			//	System.Diagnostics.Debug.WriteLine(responseContent);
			//}




		}

		private async void Follow2(object sender, EventArgs e)
		{
			await ((StackLayout)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((StackLayout)sender).ScaleTo(1, 10, Easing.Linear);

			var Element = sender as StackLayout;
			var value = Element.GestureRecognizers[0] as TapGestureRecognizer;

			var data = value.CommandParameter.ToString();

			List<Movie> moviedataGrene = new List<Movie>()
			{
				new Movie(){Title = "Action",Genre = "#cf1d46",Duration="#ffffff"},
				new Movie(){Title = "Horror",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Love",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Thriller",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Comedy",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Sci-Fi",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "War",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Crime",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Adventure",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Disaster",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Drama",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Classic",Genre = "#f0eded",Duration="#9e9e9e"},
				new Movie(){Title = "Homosexual",Genre = "#f0eded",Duration="#9e9e9e"},
			};

			List<Movie> NewmoviedataGrene = new List<Movie>();

			foreach (var i in moviedataGrene)
			{
				if (data == i.Title)
				{
					i.Duration = "#ffffff";
					i.Genre = "#cf1d46";
				}
				else
				{
					i.Duration = "#9e9e9e";
					i.Genre = "#f0eded";
				}
				NewmoviedataGrene.Add(i);
			}

			var allMovie = UserVM.MovieList.Where(x => x.Genre.Contains(data)).ToList();

			List<string[]> list_inter = new List<string[]>();

			foreach (var i in allMovie)
			{
				string[] str = i.Genre.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
				list_inter.Add(str);
			}

			int num_inter = 0;

			var db = (from c in allMovie
					  where c.Genre.Contains(data)
					  select new
					  {
						  MovieID = c.MovieID,
						  list_inter = list_inter,
						  Genre = list_inter[num_inter++],
						  Title = c.Title,
						  Duration = c.Duration,
						  MovieTrailerLink = c.MovieTrailerLink,
						  MoviePoster = c.MoviePoster,
						  RatingStar = c.RatingStar,
						  Description = c.Description,
						  Director = c.Director,
					  }).ToList();

			PromotionList2.ItemsSource = NewmoviedataGrene;
			MediaList2.ItemsSource = db;
		}

		private async void MovieHot(object sender, EventArgs e)
		{
			await ((Frame)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Frame)sender).ScaleTo(1, 10, Easing.Linear);

			var Element = sender as Frame;
			var value = Element.GestureRecognizers[0] as TapGestureRecognizer;

			var data = value.CommandParameter.ToString();

			//Preferences.Set("MovieDetail", data);
			//UserVM.MovieDetail = data;
			Navigation.PushAsync(new MovieDetailPage(Convert.ToInt32(data)));
		}

		private async void MovieHot2(object sender, EventArgs e)
		{
			await ((StackLayout)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((StackLayout)sender).ScaleTo(1, 10, Easing.Linear);

			var Element = sender as StackLayout;
			var value = Element.GestureRecognizers[0] as TapGestureRecognizer;

			var data = value.CommandParameter.ToString();

			//Preferences.Set("MovieDetail", data);
			//UserVM.MovieDetail = data;
			Navigation.PushAsync(new MovieDetailPage(Convert.ToInt32(data)));
		}

		private async void Ticket(object sender, EventArgs e)
		{
			await ((Grid)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Grid)sender).ScaleTo(1, 10, Easing.Linear);

			Navigation.PushAsync(new TransferPage());
		}

		private async void Signout(object sender, EventArgs e)
		{
			await ((Grid)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Grid)sender).ScaleTo(1, 10, Easing.Linear);

			Preferences.Set("Username", "");
			Preferences.Set("Password", "");
			UserDB.userID = 0;

			Navigation.PopToRootAsync();
		}

		private async void MoveActorMovie(object sender, EventArgs e)
		{
			await ((StackLayout)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((StackLayout)sender).ScaleTo(1, 10, Easing.Linear);

			var Element = sender as StackLayout;
			var value = Element.GestureRecognizers[0] as TapGestureRecognizer;

			var data = value.CommandParameter.ToString();

			ActorDB ac = new ActorDB();
			var dataall = ac.GetAllActor_User();
			var dataFirst = dataall.Where(x => x.ActorID == Convert.ToInt32(data)).FirstOrDefault();
			Navigation.PushAsync(new ActorMoviePage(dataFirst));


		}

		private async void MoveSearch(object sender, EventArgs e)
		{
			await ((Image)sender).ScaleTo(0.9, 30, Easing.Linear);
			await Task.Delay(10);
			await ((Image)sender).ScaleTo(1, 30, Easing.Linear);

			if (Search.Text == "")
			{
				SearchName.ErrorColor = Color.Red;
				SearchName.ErrorText = "This Movie has not been found";
				SearchName.HasError = true;
			}
			else
			{
				MovieDB moviedb = new MovieDB();
				var movie = moviedb.GetAllMovie();
				var datafind = movie.Where(x => x.Title.Contains(Search.Text)).FirstOrDefault();
				if (datafind != null)
				{
					Navigation.PushAsync(new MovieDetailPage(datafind.MovieID));
				}
				else
				{
					SearchName.ErrorColor = Color.Red;
					SearchName.ErrorText = "This song has not been found";
					SearchName.HasError = true;
				}
			}
		}

		private void Handle_Completed(object sender, EventArgs e)
		{
			if (Search.Text == "")
			{
				SearchName.ErrorColor = Color.Red;
				SearchName.ErrorText = "This Movie has not been found";
				SearchName.HasError = true;
			}
			else
			{
				MovieDB moviedb = new MovieDB();
				var movie = moviedb.GetAllMovie();
				var datafind = movie.Where(x => x.Title.Contains(Search.Text)).FirstOrDefault();
				if (datafind != null)
				{
					Navigation.PushAsync(new MovieDetailPage(datafind.MovieID));
				}
				else
				{
					SearchName.ErrorColor = Color.Red;
					SearchName.ErrorText = "This song has not been found";
					SearchName.HasError = true;
				}
			}
		}

		private void OnAutoCompleteItemSelected(object sender, Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs e)
		{
			if (Search.Text != "")
			{
				MovieDB moviedb = new MovieDB();
				var movie = moviedb.GetAllMovie();
				var datafind = movie.Where(x => x.Title.Contains(Search.Text)).FirstOrDefault();
				if (datafind != null)
				{
					SearchName.ErrorText = "";
					SearchName.HasError = false;
					Navigation.PushAsync(new MovieDetailPage(datafind.MovieID));
				}
				else
				{
					SearchName.ErrorColor = Color.Red;
					SearchName.ErrorText = "This song has not been found";
					SearchName.HasError = true;
				}
			}
		}
	}
}