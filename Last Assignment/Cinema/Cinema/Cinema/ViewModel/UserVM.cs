using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.View;
using Xamarin.Essentials;

namespace Cinema.ViewModel
{
	public class UserVM : INotifyPropertyChanged
	{
		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public static MovieDB Moviedb = new MovieDB();
		public static ObservableCollection<Movie> MovieList { get; set; } = Moviedb.GetAllMovie();

		public List<Movie> HotMovie { get; set; } = MovieList.OrderByDescending(x => x.RatingStar).Take(3).ToList();
		public List<string> SearName { get; set; } = MovieList.Select(x => x.Title).ToList();

		public static ActorDB Actordb = new ActorDB();
		public static ObservableCollection<Actor> ActorList { get; set; } = Actordb.GetAllActor_User();
		public List<Actor> ActorAvatar { get; set; } = ActorList.ToList();


		public static UserDB userDB = new UserDB();
		public static User userDB_Data = userDB.GetAllUser_One();

		public string UserFullname { get; set; } = userDB_Data.FullName;
		public string UserAvatar { get; set; } = userDB_Data.Avatar;
		public string UserEmail { get; set; } = userDB_Data.Email;

		public static User getUserdata()
		{
			string Username = Preferences.Get("Username", string.Empty);
			string Password = Preferences.Get("Password", string.Empty);
			var userData = userDB.GetAllUser();
			var data = userData.Where(x => x.Username == Username & x.Password == Password).FirstOrDefault();
			if (data != null)
			{
				return data;
			}
			return null;
		}

		//public static string MovieDetail_data = Preferences.Get("MovieDetail", string.Empty);
		//public Movie MovieDetailData { get; set; } = MovieList.Where(x => x.MovieID == Convert.ToInt32(MovieDetail_data)).FirstOrDefault();

		//public async Task getMovie()
		//{
		//	string MovieDetail_data = Preferences.Get("MovieDetail", string.Empty);
		//	MovieDetailData = MovieList.Where(x => x.MovieID == Convert.ToInt32(MovieDetail_data)).FirstOrDefault();
		//}

	}
}
