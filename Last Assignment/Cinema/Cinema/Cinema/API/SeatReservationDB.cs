using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using Cinema.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Cinema.API
{
	public class SeatReservationDB
	{
		const string baseUrl = "http://10.0.2.2:5041/api/";
		HttpClient client = new HttpClient();
		public static string JWBToken = null;
		public static int userID = 0;

		public void Token_Admin()
		{
			Admin ad = new Admin()
			{
				Username = "hoo",
				Password = "hoo"
			};

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseUrl);
				StringContent content = new StringContent(JsonConvert.SerializeObject(ad), Encoding.UTF8, "application/json");

				var respose = client.PostAsync("AdminToken", content).Result;

				if (respose.IsSuccessStatusCode)
				{
					string token = respose.Content.ReadAsStringAsync().Result;
					if (token != "Invalid credentials")
					{
						JWBToken = token;
					}
				}
			}
		}

		public void Token_User()
		{
			string Username = Preferences.Get("Username", string.Empty);
			string Password = Preferences.Get("Password", string.Empty);

			User user = new User()
			{
				Username = Username,
				Password = Password
			};

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseUrl);
				StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
				var respose = client.PostAsync("UserToken", content).Result;

				if (respose.IsSuccessStatusCode)
				{
					string token = respose.Content.ReadAsStringAsync().Result;
					if (token != "Invalid credentials")
						JWBToken = token;
				}
			}
		}

		public async Task<ObservableCollection<SeatReservation>> GetAllSeatReservation_Api()
		{
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWBToken);
			client.BaseAddress = new Uri(baseUrl);
			var respose = client.GetAsync("SeatReservation").Result;

			if (respose.IsSuccessStatusCode)
			{
				string jsonString = respose.Content.ReadAsStringAsync().Result;
				return JsonConvert.DeserializeObject<ObservableCollection<SeatReservation>>(jsonString);
			}

			return null;
		}

		public ObservableCollection<SeatReservation> GetAllSeatReservation()
		{
			Token_Admin();
			return GetAllSeatReservation_Api().Result;
		}

		public ObservableCollection<SeatReservation> GetAlSeatReservation_User()
		{
			Token_User();
			return GetAllSeatReservation_Api().Result;
		}


		public async Task CreateSeatReservation_Api(SeatReservation seatReservation)
		{
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWBToken);
			client.BaseAddress = new Uri(baseUrl);
			var respose = client.GetAsync("SeatReservation").Result;

			if (respose.IsSuccessStatusCode)
			{
				var jsonStr = new StringContent(JsonConvert.SerializeObject(seatReservation), Encoding.UTF8, "application/json");
				await client.PostAsync(baseUrl + "SeatReservation", jsonStr);
			}
		}

		public async Task CreateSeatReservation(SeatReservation seatReservation)
		{
			Token_Admin();
			await CreateSeatReservation_Api(seatReservation);
		}
	}
}
