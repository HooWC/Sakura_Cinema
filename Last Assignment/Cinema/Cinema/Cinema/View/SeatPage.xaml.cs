using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Cinema.API;
using Cinema.Models;
using Cinema.PopupPage;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SeatPage : ContentPage
	{

		public static Show showdb = new Show();
		public HallDB hall_Api = new HallDB();
		public ReservationDB Res_Api = new ReservationDB();
		public SeatReservationDB Seat_Api = new SeatReservationDB();

		public SeatPage(Show show)
		{
			InitializeComponent();
			showdb = show;
			HallName.Text = $"H{show.HallID}";
			Button_Clicked();



		}

		public void Button_Clicked()
		{
			var hall = hall_Api.GetAllHall_User();
			var findhal = hall.Where(x => x.HallID == showdb.HallID).FirstOrDefault();
			string[] hallseat = findhal.SeatsAmount.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
			var resdata = Res_Api.GetAllReservation_User();
			var resall = resdata.Where(x => x.ShowID == showdb.ShowID).ToList();



			var mygridlayout = MyGrid as Grid;

			if (resall != null)
			{

				var seatdata = Seat_Api.GetAlSeatReservation_User();
				var seatall = seatdata.Where(x => resall.Any(res => res.ReservationID == x.ReservationID)).ToList();

				List<string> seatdata_list = new List<string>();
				foreach (var i in seatall)
				{
					string[] str = i.NumberOfSeats.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
					seatdata_list.AddRange(str);
				}


				for (int i = 0; i < Convert.ToInt32(hallseat[0]); i++)
				{
					for (int j = 0; j < Convert.ToInt32(hallseat[1]); j++)
					{
						var NewStack = new StackLayout();

						if (seatdata_list.Contains($"R{i} C{j}"))
						{
							//已经订的位置
							NewStack = new StackLayout
							{
								BackgroundColor = Color.Transparent,
								Children = {new Image
							{
									Source = "redseatIcon.png",
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.CenterAndExpand,
							} },
							};
						}
						else
						{
							//新位置
							//NewStack = new StackLayout
							//{
							//	BackgroundColor = Color.White,
							//	Children = {new Label
							//{
							//	Text = $"R{i} C{j}",
							//	VerticalTextAlignment = TextAlignment.Center,
							//	FontSize = 10,
							//	TextColor = Color.Black,
							//	HorizontalOptions = LayoutOptions.CenterAndExpand,
							//	VerticalOptions = LayoutOptions.CenterAndExpand,
							//} },
							//};
							NewStack = new StackLayout
							{
								BackgroundColor = Color.Transparent,
								Children = {new Image
								{
									Source = "seatIcon.png",
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.CenterAndExpand,
								} },
							};
						}

						TapGestureRecognizer tapGesture = new TapGestureRecognizer();
						tapGesture.CommandParameter = $"R{i} C{j}";
						tapGesture.Tapped += async (s, arg) =>
						{

							await ((StackLayout)s).ScaleTo(0.9, 10, Easing.Linear);
							await Task.Delay(10);
							await ((StackLayout)s).ScaleTo(1, 10, Easing.Linear);

							var clickedItem = s as StackLayout;
							//位置名字
							var selectedSeatPosition = clickedItem.GestureRecognizers[0] as TapGestureRecognizer;
							//图片名字
							var selecttedSeat = clickedItem.Children[0] as Image;

							//if (clickedItem.BackgroundColor != Color.Red)
							//{

							//	var labeldata = clickedItem.Children[0] as Label;

							//	if (clickedItem.BackgroundColor == Color.White)
							//	{
							//		clickedItem.BackgroundColor = Color.LightGreen;
							//		labeldata.TextColor = Color.Black;
							//	}
							//	else
							//	{
							//		clickedItem.BackgroundColor = Color.White;
							//		labeldata.TextColor = Color.Black;
							//	}
							//}

							if (selecttedSeat.Source.ToString() != "File: redseatIcon.png")
							{
								if (selecttedSeat.Source.ToString() == "File: seatIcon.png")
								{
									selecttedSeat.Source = "greenseatIcon.png";
								}
								else
								{
									selecttedSeat.Source = "seatIcon.png";
								}
							}



						};
						NewStack.GestureRecognizers.Add(tapGesture);

						mygridlayout.Children.Add(NewStack, j, i);
					}
				}

			}
			else
			{
				for (int i = 0; i < 9; i++)
				{
					for (int j = 0; j < 8; j++)
					{

						var NewStack = new StackLayout
						{
							BackgroundColor = Color.Transparent,
							Children = {new Image
								{
									Source = "seatIcon.png",
									HorizontalOptions = LayoutOptions.CenterAndExpand,
									VerticalOptions = LayoutOptions.CenterAndExpand,
								} },
							//	Children = {new Label
							//{
							//	Text = $"R{i} C{j}",
							//	VerticalTextAlignment = TextAlignment.Center,
							//	FontSize = 10,
							//	TextColor = Color.Black,
							//	HorizontalOptions = LayoutOptions.CenterAndExpand,
							//	VerticalOptions = LayoutOptions.CenterAndExpand,
							//} },
						};

						TapGestureRecognizer tapGesture = new TapGestureRecognizer();
						tapGesture.CommandParameter = $"R{i} C{j}";
						tapGesture.Tapped += async (s, arg) =>
						{

							await ((StackLayout)s).ScaleTo(0.9, 10, Easing.Linear);
							await Task.Delay(10);
							await ((StackLayout)s).ScaleTo(1, 10, Easing.Linear);

							var clickedItem = s as StackLayout;
							//位置名字
							var selectedSeatPosition = clickedItem.GestureRecognizers[0] as TapGestureRecognizer;
							//图片名字
							var selecttedSeat = clickedItem.Children[0] as Image;

							if (selecttedSeat.Source.ToString() != "File: redseatIcon.png")
							{
								if (selecttedSeat.Source.ToString() == "File: seatIcon.png")
								{
									selecttedSeat.Source = "greenseatIcon.png";
								}
								else
								{
									selecttedSeat.Source = "seatIcon.png";
								}
							}

							//var clickedItem = s as StackLayout;
							//var labeldata = clickedItem.Children[0] as Label;

							//if (clickedItem.BackgroundColor == Color.White)
							//{
							//	clickedItem.BackgroundColor = Color.LightGreen;
							//	labeldata.TextColor = Color.Black;
							//}
							//else
							//{
							//	clickedItem.BackgroundColor = Color.White;
							//	labeldata.TextColor = Color.Black;
							//}

						};
						NewStack.GestureRecognizers.Add(tapGesture);

						mygridlayout.Children.Add(NewStack, j, i);
					}
				}

			}

		}

		private async void CheckOut(object sender, EventArgs e)
		{
			await ((Image)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Image)sender).ScaleTo(1, 10, Easing.Linear);

			var mygridlaout = MyGrid as Grid;

			string myHighlightlist = "";

			foreach (var pair in (mygridlaout).Children)
			{
				var Eachseat = pair as StackLayout;
				//位置名字
				var selectedSeatPosition = Eachseat.GestureRecognizers[0] as TapGestureRecognizer;
				//图片名字
				var selecttedSeat = Eachseat.Children[0] as Image;

				if (selecttedSeat.Source.ToString() == "File: greenseatIcon.png")
				{
					myHighlightlist += selectedSeatPosition.CommandParameter.ToString() + "|";
				}
			}

			if (myHighlightlist != "")
			{
				PopupNavigation.PushAsync(new SeatPopup(myHighlightlist, showdb));
			}

		}


		private async void Back(object sender, EventArgs e)
		{
			await ((Image)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((Image)sender).ScaleTo(1, 10, Easing.Linear);

			Navigation.PopAsync();
		}

	}
}