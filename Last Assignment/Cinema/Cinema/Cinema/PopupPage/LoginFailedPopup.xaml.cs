using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.PopupPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginFailedPopup
	{
		public LoginFailedPopup()
		{
			InitializeComponent();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await ((Button)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Button)sender).ScaleTo(1, 10, Easing.Linear);

			PopupNavigation.PopAsync();
		}
	}
}