using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.View;
using Cinema.ViewModel;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.PopupPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SignupPopup
	{
		public static SignUpVM vm = new SignUpVM();
		public SignupPopup()
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

			if (vm.UserName != null && vm.Password != null && vm.Email != null && vm.FullName != null && vm.Phone != null)
			{
				loadingpic.IsVisible = true;
				Boxblack.IsVisible = true;
				await Task.Delay(TimeSpan.FromSeconds(8));

				vm.CheckSignUp_New(vm.UserName, vm.Password, vm.Email, vm.FullName, vm.Phone);

				loadingpic.IsVisible = false;
				Boxblack.IsVisible = false;

				PopupNavigation.PopAsync();
			}
			else
			{
				await PopupNavigation.PushAsync(new SignupFailedPopup());
			}


		}
	}
}