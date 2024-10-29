using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.PopupPage;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Cinema.ViewModel
{
	public class ForgetPasswordVM : INotifyPropertyChanged
	{
		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public UserDB userDB = new UserDB();

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

		public Command ForgetPasswordFunction { get; set; }

		public ForgetPasswordVM()
		{
			ForgetPasswordFunction = new Command(async async => await GetForgetPassword());
		}

		async Task GetForgetPassword()
		{
			var userData = userDB.GetAllUser();
			var userDB_Email = userData.Where(x => x.Email == this.Email).FirstOrDefault();
			if (userDB_Email != null)
			{
				userDB_Email.Password = this.Password;
				await userDB.EditUser(userDB_Email);
			}

			ForgetPasswordPopup.PopupClose();
		}

		public async void CheckForgetPassword_New(string em, string pass)
		{
			var userData = userDB.GetAllUser();
			var userDB_Email = userData.Where(x => x.Email == em).FirstOrDefault();
			if (userDB_Email != null)
			{
				userDB_Email.Password = pass;
				await userDB.EditUser(userDB_Email);
			}
		}

	}
}
