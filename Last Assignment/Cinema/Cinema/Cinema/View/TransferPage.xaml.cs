using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransferPage : ContentPage
	{


		public TransferPage()
		{
			InitializeComponent();

			UserDB userdb = new UserDB();
			MovieDB moviedb = new MovieDB();
			ReservationDB reservationdb = new ReservationDB();
			ShowDB showdb = new ShowDB();
			PaymentDB paymentdb = new PaymentDB();
			SeatReservationDB seatdb = new SeatReservationDB();

			var userdata = userdb.GetAllUser_One();
			var resdata = reservationdb.GetAllReservation_User();
			var moviedata = moviedb.GetAllMovie();
			var showdata = showdb.GetAllShowr_User();
			var paydata = paymentdb.GetAllPayment_User();

			var db = (from c in resdata
					  where c.UserID == userdata.UserID
					  join pay in paydata on c.ReservationID equals pay.ReservationID
					  join show in showdata on c.ShowID equals show.ShowID
					  join movie in moviedata on show.MovieID equals movie.MovieID
					  select new
					  {
						  resid = c.ReservationID,
						  id = pay.PaymentID,
						  Date = show.Date.ToString().Substring(0, 10),
						  MovieName = movie.Title,
						  amount = pay.Amount
					  }).OrderByDescending(x => x.id).ToList();

			TrList.ItemsSource = db;

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

		}

		private void Back(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		private async void TicketMove(object sender, EventArgs e)
		{
			await ((Frame)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Frame)sender).ScaleTo(1, 10, Easing.Linear);

			var Element = sender as Frame;
			var value = Element.GestureRecognizers[0] as TapGestureRecognizer;

			var data = value.CommandParameter.ToString();

			SeatReservationDB seatdb2 = new SeatReservationDB();
			var seatdata = seatdb2.GetAlSeatReservation_User();
			ReservationDB reservationdb2 = new ReservationDB();
			var resdata = reservationdb2.GetAllReservation_User();
			ShowDB showdb2 = new ShowDB();
			var showdata = showdb2.GetAllShowr_User();

			var res = resdata.Where(x => x.ReservationID == Convert.ToInt32(data)).FirstOrDefault();
			var seatList = seatdata.Where(x => x.ReservationID == Convert.ToInt32(data)).FirstOrDefault().NumberOfSeats;
			var show = showdata.Where(x => x.ShowID == res.ShowID).FirstOrDefault();

			Navigation.PushAsync(new HistoryTicketPageView(show, seatList));

		}
	}
}