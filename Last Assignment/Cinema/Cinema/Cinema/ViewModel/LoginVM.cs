using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.View;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Cinema.ViewModel
{
	public class LoginVM : INotifyPropertyChanged
	{
		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public UserDB userDB = new UserDB();

		public string username { get; set; }
		public string Username
		{
			get { return username; }
			set
			{
				if (username != value)
				{
					username = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string password { get; set; }
		public string Password
		{
			get { return password; }
			set
			{
				if (password != value)
				{
					password = value;
					NotifyPropertyChanged();
				}
			}
		}

		public Command LoginFunction { get; set; }

		public LoginVM()
		{
			LoginFunction = new Command(async async => await CheckLogin());
		}

		async Task CheckLogin()
		{
			UserDB userDB2 = new UserDB();
			var userData = userDB2.GetAllUser();
			var data = userData.Where(x => x.Username == this.Username & x.Password == this.Password).FirstOrDefault();
			if (data != null)
			{
				Preferences.Set("Username", this.Username);
				Preferences.Set("Password", this.Password);
				UserDB.userID = data.UserID;

				await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
				//await Application.Current.MainPage.Navigation.PushAsync(new MovieTuneSearchPage());
			}
		}

		public bool CheckLogin_New(string us, string pass)
		{
			UserDB userDB2 = new UserDB();
			var userData = userDB2.GetAllUser();
			var data = userData.Where(x => x.Username == us & x.Password == pass).FirstOrDefault();
			if (data != null)
			{
				Preferences.Set("Username", us);
				Preferences.Set("Password", pass);
				UserDB.userID = data.UserID;
				return true;
			}
			return false;
		}

	}

}
