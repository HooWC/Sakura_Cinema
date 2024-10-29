using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.PopupPage;
using Cinema.ViewModel;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public static LoginVM vm = new LoginVM();
		public LoginPage()
		{
			InitializeComponent();
			Preferences.Set("Username", "");
			Preferences.Set("Password", "");
			UserDB.userID = 0;
			BindingContext = vm;
		}

		private void SignUpMethod(object sender, EventArgs e)
		{
			PopupNavigation.PushAsync(new SignupPopup());
		}

		private void ForgetPasswordMethod(object sender, EventArgs e)
		{
			PopupNavigation.PushAsync(new ForgetPasswordPopup());
		}

		private async void IconImage(object sender, EventArgs e)
		{
			await ((Frame)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Frame)sender).ScaleTo(1, 10, Easing.Linear);
		}

		private async void LoginMethod(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			loadingpic.IsVisible = true;
			Boxblack.IsVisible = true;
			await Task.Delay(TimeSpan.FromSeconds(8));

			bool loginsuccess = vm.CheckLogin_New(vm.Username, vm.Password);

			loadingpic.IsVisible = false;
			Boxblack.IsVisible = false;

			if (loginsuccess)
				await Navigation.PushAsync(new HomePage());
			else
				await PopupNavigation.PushAsync(new LoginFailedPopup());
		}
	}
}