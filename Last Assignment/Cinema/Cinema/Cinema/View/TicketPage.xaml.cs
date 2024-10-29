using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.ViewModel;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TicketPage : ContentPage
	{
		public static Show shoedb = new Show();
		public static string seatlist_db = null;
		public static FunctionVM vm = new FunctionVM();

		public TicketPage(Show show, string seatlist)
		{
			InitializeComponent();

			shoedb = show;
			seatlist_db = seatlist;

			vm.getTicket(show, seatlist);
			BindingContext = vm;
		}

		private async void Back(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			Navigation.PopAsync();
		}

		private async void Payment(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			Navigation.PushAsync(new PaymentPage(shoedb, seatlist_db));

		}
	}
}