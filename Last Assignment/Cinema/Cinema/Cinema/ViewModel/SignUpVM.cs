using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Cinema.API;
using Cinema.Models;
using System.Threading.Tasks;
using Xamarin.Forms;
using Cinema.PopupPage;
using Rg.Plugins.Popup.Services;
using Cinema.View;
using System.Linq;
using Xamarin.Essentials;

namespace Cinema.ViewModel
{
	public class SignUpVM : INotifyPropertyChanged
	{
		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public UserDB userDB = new UserDB();


		public string username { get; set; }
		public string UserName
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

		public string fullName { get; set; }
		public string FullName
		{
			get { return fullName; }
			set
			{
				if (fullName != value)
				{
					fullName = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string email { get; set; }
		public string Email
		{
			get { return email; }
			set
			{
				if (email != value)
				{
					email = value;
					NotifyPropertyChanged();
				}
			}
		}

		public string phone { get; set; }
		public string Phone
		{
			get { return phone; }
			set
			{
				if (phone != value)
				{
					phone = value;
					NotifyPropertyChanged();
				}
			}
		}

		public Command CreateFunction { get; set; }

		public SignUpVM()
		{
			CreateFunction = new Command(async async => await GetCreate());
		}

		async Task GetCreate()
		{
			User user = new User()
			{
				Avatar = "avatar",
				Email = this.Email,
				FullName = this.FullName,
				Username = this.UserName,
				Password = this.Password,
				OneSignalOpen = true,
				Phone = this.Phone

			};

			//API Create
			await userDB.CreateUser(user);
			SignupPopup.PopupClose();
		}

		public async void CheckSignUp_New(string us, string pass, string email, string fullname, string phone)
		{
			User user = new User()
			{
				Avatar = "avatar",
				Email = email,
				FullName = fullname,
				Username = us,
				Password = pass,
				OneSignalOpen = true,
				Phone = phone

			};

			//API Create
			await userDB.CreateUser(user);
		}


	}
}
