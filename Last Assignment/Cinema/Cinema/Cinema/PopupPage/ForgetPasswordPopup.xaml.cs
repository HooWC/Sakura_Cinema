using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.ViewModel;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.PopupPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgetPasswordPopup
	{
		public static ForgetPasswordVM vm = new ForgetPasswordVM();
		public ForgetPasswordPopup()
		{
			InitializeComponent();
			BindingContext = vm;
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			PopupNavigation.PopAsync();
		}

		public static void PopupClose()
		{
			PopupNavigation.PopAsync();
		}

		private async void SfButton_Clicked(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			if (vm.Email != null && vm.Password != null)
			{
				loadingpic.IsVisible = true;
				Boxblack.IsVisible = true;
				await Task.Delay(TimeSpan.FromSeconds(8));

				UserDB userdb = new UserDB();
				var user = userdb.GetAllUser();
				var b = user.Where(x => x.Email == vm.Email).FirstOrDefault();
				if (b != null)
				{
					vm.CheckForgetPassword_New(vm.Email, vm.Password);

					loadingpic.IsVisible = false;
					Boxblack.IsVisible = false;

					PopupNavigation.PopAsync();
				}
				else
				{
					loadingpic.IsVisible = false;
					Boxblack.IsVisible = false;
					await PopupNavigation.PushAsync(new ForgetPasswordFailedPopup());

				}


			}
			else
			{
				await PopupNavigation.PushAsync(new ForgetPasswordFailedPopup());
			}

		}
	}
}