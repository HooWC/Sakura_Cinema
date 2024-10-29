using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.View;
using OneSignalSDK.Xamarin;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.PopupPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentPopup
	{
		public static Show shoedb = new Show();
		public MovieDB Moviedb_Detail = new MovieDB();
		public UserDB user_Detail = new UserDB();
		public ReservationDB reservation_Detail = new ReservationDB();
		public SeatReservationDB seatReservation_Detail = new SeatReservationDB();
		public static string seatlist_db = null;
		public static string cardtype_db = null;
		public static Object cardnum_db = null;

		public PaymentPopup(string seatList, Show show, string CardType, Object value)
		{
			InitializeComponent();
			Boxblack.IsVisible = false;
			loadingpic.IsVisible = false;

			shoedb = show;
			seatlist_db = seatList;
			cardtype_db = CardType;
			cardnum_db = value;
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			PopupNavigation.PopAsync();
		}

		private async void Button_Clicked_1(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

			Boxblack.IsVisible = true;
			loadingpic.IsVisible = true;

			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == shoedb.MovieID).FirstOrDefault();
			var user_db = user_Detail.GetAllUser_One();

			Reservation res = new Reservation()
			{
				Active = true,
				ReservationCode = $"{movie_data.MovieID}Sakura{shoedb.ShowID}Cinema",
				UserID = user_db.UserID,
				ShowID = shoedb.ShowID
			};

			reservation_Detail.CreateReservation(res);

			await Task.Delay(TimeSpan.FromSeconds(10));
			var resdata = ResCreateData();

			SeatReservation seat = new SeatReservation()
			{
				ReservationID = resdata.ReservationID,
				NumberOfSeats = seatlist_db,
				Paid = true,
				Active = true,
				UserID = user_db.UserID
			};

			seatReservation_Detail.CreateSeatReservation(seat);


			PaymentData(resdata);


			UserDB userdata_check = new UserDB();
			var usernotification = userdata_check.GetAllUser_One();
			if (usernotification.OneSignalOpen == true)
			{
				var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

				request.KeepAlive = true;
				request.Method = "POST";
				request.ContentType = "application/json; charset=utf-8";

				var OneSignalID = OneSignal.Default.PushSubscriptionState.userId;


				List<string> Lists = new List<string>();

				Lists.Add(OneSignalID);

				string format = "";

				foreach (var i in Lists)
				{
					format += $"\"{i}\",";
				}

				var x = $"[{format.Remove(format.Length - 1)}]";

				byte[] byteArray = Encoding.UTF8.GetBytes("{"
														+ "\"app_id\": \"aa0150b5-ea7a-4d62-812e-3f7aaabaae5b\","
														+ "\"contents\": {\"en\": \"" + $"You Payment Success!" + "\"},"
														+ "\"headings\": {\"en\": \"Sakura Cinema\"},"
														+ $"\"include_player_ids\":" + x + "}");

				string responseContent = null;

				try
				{
					using (var writer = request.GetRequestStream())
					{
						writer.Write(byteArray, 0, byteArray.Length);
					}

					using (var response = request.GetResponse() as HttpWebResponse)
					{
						using (var reader = new StreamReader(response.GetResponseStream()))
						{
							responseContent = reader.ReadToEnd();
						}
					}
				}
				catch (WebException ex)
				{
					System.Diagnostics.Debug.WriteLine(ex.Message);
					System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
				}

				System.Diagnostics.Debug.WriteLine(responseContent);
			}




			Boxblack.IsVisible = false;
			loadingpic.IsVisible = false;

			PopupNavigation.PopAsync();
			Navigation.PushAsync(new HomePage());
		}


		public Reservation ResCreateData()
		{
			ReservationDB reservation_DetailNew = new ReservationDB();
			var resdata = reservation_DetailNew.GetAllReservation_User().LastOrDefault();
			return resdata;
		}

		public void PaymentData(Reservation res)
		{
			PaymentDB db = new PaymentDB();

			string[] str = seatlist_db.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			double money = str.Count() * 5;

			Payment pay = new Payment()
			{
				Amount = money,
				Timestamp = DateTime.Now,
				DiscountCode = "Null",
				TransactionNUm = cardnum_db.ToString(),
				PaymentMethod = "Online",
				ReservationID = res.ReservationID,
				CardType = cardtype_db
			};

			db.CreatePayment(pay);
		}


	}
}