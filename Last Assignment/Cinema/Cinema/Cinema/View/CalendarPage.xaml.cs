using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cinema.API;
using Cinema.Models;
using Cinema.PopupPage;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarPage : ContentPage
	{

		public static DateTime displayweek;
		public static int Page;
		private DateTime currentDate;
		private int numRows = 6;
		private int numCols = 7;
		public static int MovieID = 0;
		public MovieDB Moviedb_Detail = new MovieDB();
		public ShowDB Showdb_Detail = new ShowDB();
		public static List<Show> showList = new List<Show>();

		public CalendarPage(int id)
		{
			InitializeComponent();

			MovieID = id;
			var show_db = Showdb_Detail.GetAllShowr_User();
			var movie_db = Moviedb_Detail.GetAllMovie();
			var movie_data = movie_db.Where(x => x.MovieID == MovieID).FirstOrDefault();
			showList = show_db.Where(x => x.MovieID == movie_data.MovieID).ToList();

			currentDate = DateTime.Today;
			UpdateMonthLabel(); // 更新月份标签
			CreateCalendar();
		}

		private void CreateCalendar()
		{

			int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
			int startingDay = (int)new DateTime(currentDate.Year, currentDate.Month, 1).DayOfWeek;

			foreach (var i in showList)
			{
				DateTime cv = DateTime.Today;
				string date = i.Date.ToString().Substring(0, 10);
				string[] dateParts = date.Split('/');
				int month = Convert.ToInt32(dateParts[0]);
				int day = Convert.ToInt32(dateParts[1]);
				int year = Convert.ToInt32(dateParts[2]);

				DateTime startingDayNew = currentDate.Date;
				// 如果 currentDate.Date 大于 cv.Date，就将 startingDay 设置为新的日期
				if (currentDate.Date > cv.Date)
				{
					startingDayNew = new DateTime(currentDate.Year, currentDate.Month, 1);
				}

				if (new DateTime(year, month, day) < startingDayNew)
				{
					i.ShowDate = true;
				}
			}

			// 清除之前的日历
			myGrid.Children.Clear();

			for (int row = 0; row < numRows; row++)
			{
				for (int col = 0; col < numCols; col++)
				{
					//int dayNumber = (row * numCols) + col + 1;
					int dayNumber = (row * numCols) + col - startingDay + 1;
					if (dayNumber <= daysInMonth && dayNumber > 0)
					{
						var frame = new Frame
						{
							Padding = 5,
							HasShadow = false,
							Margin = new Thickness(5),
							HeightRequest = 30,
							WidthRequest = 30,
							CornerRadius = 15 // 设置半径以创建圆形
						};


						// 检查是否为目标日期（2023-10-06 或 2023-10-07）并更改背景颜色为红色
						bool redcolor = false;
						foreach (var i in showList)
						{
							string date = i.Date.ToString().Substring(0, 10);
							string[] dateParts = date.Split('/');
							int month = Convert.ToInt32(dateParts[0]);
							int day = Convert.ToInt32(dateParts[1]);
							int year = Convert.ToInt32(dateParts[2]);
							string s = $"{year},{month},{day}";
							string ss = currentDate.Date.ToString();

							if (redcolor == false)
							{     //2023/9/1                                  2023/9/16 | 2023.10/6                             
								if (new DateTime(currentDate.Year, currentDate.Month, dayNumber) == new DateTime(year, month, day))
								{
									if (i.ShowDate != true)
									{
										frame.BackgroundColor = Color.Red;
										i.ShowDate = true;
										redcolor = true;
									}
								}
							}
							else
							{
								break;
							}
						}

						if (redcolor == false)
						{
							frame.BackgroundColor = (currentDate.Year == DateTime.Today.Year && currentDate.Month == DateTime.Today.Month) ?
									((dayNumber < DateTime.Today.Day) ? Color.LightGray : Color.FromHex("#3498db")) :
									(currentDate.Year < DateTime.Today.Year || (currentDate.Year == DateTime.Today.Year && currentDate.Month < DateTime.Today.Month)) ? Color.LightGray : Color.FromHex("#3498db");
						}


						var label = new Label
						{
							Text = dayNumber.ToString(),
							FontSize = 14,
							//TextColor = (currentDate < DateTime.Today) ? Color.Gray : Color.White,
							TextColor = (currentDate.Year == DateTime.Today.Year && currentDate.Month == DateTime.Today.Month) ?
									((dayNumber < DateTime.Today.Day) ? Color.Gray : Color.White) :
									(currentDate.Year < DateTime.Today.Year || (currentDate.Year == DateTime.Today.Year && currentDate.Month < DateTime.Today.Month)) ? Color.Gray : Color.White,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							VerticalOptions = LayoutOptions.CenterAndExpand
						};



						frame.Content = new StackLayout
						{
							Children = { label },
						};

						var tapGesture = new TapGestureRecognizer();
						tapGesture.Tapped += async (s, e) =>
						{
							var clickedFrame = s as Frame;

							if (clickedFrame.BackgroundColor == Color.Red)
							{
								int selectedDay = int.Parse(label.Text);

								Show db = new Show();
								foreach (var i in showList)
								{
									DateTime cv = DateTime.Today;
									string date = i.Date.ToString().Substring(0, 10);
									string[] dateParts = date.Split('/');
									int month = Convert.ToInt32(dateParts[0]);
									int day = Convert.ToInt32(dateParts[1]);
									int year = Convert.ToInt32(dateParts[2]);

									DateTime startingDayNew = currentDate.Date;
									// 如果 currentDate.Date 大于 cv.Date，就将 startingDay 设置为新的日期
									if (new DateTime(year, month, day) == new DateTime(currentDate.Year, currentDate.Month, selectedDay))
									{
										db = i; break;
									}
								}

								var text = $"{currentDate.Month}/{selectedDay}/{currentDate.Year}";
								MonthLabel.Text = text;

								PopupNavigation.PushAsync(new CalendarPopup(db));
							}


						};

						frame.GestureRecognizers.Add(tapGesture);

						// 将日期框架添加到Grid中
						myGrid.Children.Add(frame, col, row);
					}
				}
			}
		}




		//private void CreateCalendar()
		//{

		//	int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
		//	int startingDay = (int)new DateTime(currentDate.Year, currentDate.Month, 1).DayOfWeek;

		//	// 清除之前的日历
		//	myGrid.Children.Clear();

		//	for (int row = 0; row < numRows; row++)
		//	{
		//		for (int col = 0; col < numCols; col++)
		//		{
		//			//int dayNumber = (row * numCols) + col + 1;
		//			int dayNumber = (row * numCols) + col - startingDay + 1;
		//			if (dayNumber <= daysInMonth && dayNumber > 0)
		//			{
		//				var frame = new Frame
		//				{
		//					Padding = 5,
		//					HasShadow = false,
		//					Margin = new Thickness(5),
		//					HeightRequest = 30,
		//					WidthRequest = 30,
		//					CornerRadius = 15 // 设置半径以创建圆形
		//				};

		//				var label = new Label
		//				{
		//					Text = dayNumber.ToString(),
		//					FontSize = 14,
		//					TextColor = (currentDate < DateTime.Today) ? Color.Gray : Color.White,
		//					HorizontalOptions = LayoutOptions.CenterAndExpand,
		//					VerticalOptions = LayoutOptions.CenterAndExpand
		//				};

		//				// 检查是否为目标日期（2023-10-06 或 2023-10-07）并更改背景颜色为红色
		//				foreach (var i in showList)
		//				{
		//					string date = i.Date.ToString().Substring(0, 10);
		//					string[] dateParts = date.Split('/');
		//					int month = Convert.ToInt32(dateParts[0]);
		//					int day = Convert.ToInt32(dateParts[1]);
		//					int year = Convert.ToInt32(dateParts[2]);
		//					string s = $"{year},{month},{day}";
		//					string ss = currentDate.Date.ToString();

		//					//这边重复

		//					if (i.StartTime != "true")
		//					{
		//						if (currentDate.Date == new DateTime(year, month, day))
		//						{
		//							frame.BackgroundColor = Color.Red;
		//							i.StartTime = "true";
		//						}
		//						else
		//						{
		//							frame.BackgroundColor = (currentDate.Year == DateTime.Today.Year && currentDate.Month == DateTime.Today.Month) ?
		//								((dayNumber < DateTime.Today.Day) ? Color.LightGray : Color.FromHex("#3498db")) :
		//								(currentDate.Year < DateTime.Today.Year || (currentDate.Year == DateTime.Today.Year && currentDate.Month < DateTime.Today.Month)) ? Color.LightGray : Color.FromHex("#3498db");
		//						}
		//					}
		//				}

		//				frame.Content = new StackLayout
		//				{
		//					Children = { label },
		//				};

		//				var tapGesture = new TapGestureRecognizer();
		//				tapGesture.Tapped += async (s, e) =>
		//				{
		//					var clickedFrame = s as Frame;
		//					int selectedDay = int.Parse(label.Text);

		//					var text = $"{currentDate.Month}/{selectedDay}/{currentDate.Year}";
		//					MonthLabel.Text = text;

		//					PopupNavigation.PushAsync(new CalendarPopup(text));
		//				};
		//				frame.GestureRecognizers.Add(tapGesture);

		//				// 将日期框架添加到Grid中
		//				myGrid.Children.Add(frame, col, row);
		//			}
		//		}
		//	}
		//}



		//private void CreateCalendar()
		//{
		//	var show_db = Showdb_Detail.GetAllShowr_User();

		//	var movie_db = Moviedb_Detail.GetAllMovie();
		//	var movie_data = movie_db.Where(x => x.MovieID == MovieID).FirstOrDefault();

		//	List<Show> showList = new List<Show>();
		//	foreach (var i in show_db)
		//	{
		//		if (i.MovieID == movie_data.MovieID)
		//			showList.Add(i);
		//	}


		//	int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
		//	int startingDay = (int)new DateTime(currentDate.Year, currentDate.Month, 1).DayOfWeek;

		//	// 清除之前的日历
		//	myGrid.Children.Clear();

		//	for (int row = 0; row < numRows; row++)
		//	{
		//		for (int col = 0; col < numCols; col++)
		//		{
		//			//int dayNumber = (row * numCols) + col + 1;
		//			int dayNumber = (row * numCols) + col - startingDay + 1;
		//			if (dayNumber <= daysInMonth && dayNumber > 0)
		//			{
		//				var frame = new Frame
		//				{
		//					BackgroundColor = (currentDate.Year == DateTime.Today.Year && currentDate.Month == DateTime.Today.Month) ?
		//						((dayNumber < DateTime.Today.Day) ? Color.LightGray : Color.FromHex("#3498db")) :
		//						(currentDate.Year < DateTime.Today.Year || (currentDate.Year == DateTime.Today.Year && currentDate.Month < DateTime.Today.Month)) ? Color.LightGray : Color.FromHex("#3498db"),

		//					Padding = 5,
		//					HasShadow = false,
		//					Margin = new Thickness(5),
		//					HeightRequest = 30,
		//					WidthRequest = 30,
		//					CornerRadius = 15 // 设置半径以创建圆形
		//				};

		//				var label = new Label
		//				{
		//					Text = dayNumber.ToString(),
		//					FontSize = 14,
		//					TextColor = (currentDate.Year < DateTime.Today.Year || (currentDate.Year == DateTime.Today.Year && currentDate.Month < DateTime.Today.Month) || (currentDate.Month == DateTime.Today.Month && dayNumber < DateTime.Today.Day)) ? Color.Gray : Color.White,
		//					HorizontalOptions = LayoutOptions.CenterAndExpand,
		//					VerticalOptions = LayoutOptions.CenterAndExpand
		//				};

		//				frame.Content = new StackLayout
		//				{
		//					Children = { label },
		//				};

		//				var tapGesture = new TapGestureRecognizer();
		//				tapGesture.Tapped += async (s, e) =>
		//				{
		//					var clickedFrame = s as Frame;
		//					int selectedDay = int.Parse(label.Text);

		//					var text = $"{currentDate.Month}/{selectedDay}/{currentDate.Year}";
		//					MonthLabel.Text = text;

		//					PopupNavigation.PushAsync(new CalendarPopup(text));
		//				};
		//				frame.GestureRecognizers.Add(tapGesture);

		//				// 将日期框架添加到Grid中
		//				myGrid.Children.Add(frame, col, row);
		//			}
		//		}
		//	}
		//}



		private void NextMonthButton_Clicked(object sender, EventArgs e)
		{
			showList.ForEach(x => x.ShowDate = false);
			currentDate = currentDate.AddMonths(1);
			UpdateMonthLabel(); // 更新月份标签
			CreateCalendar();
		}

		private void PreviousMonthButton_Clicked(object sender, EventArgs e)
		{
			showList.ForEach(x => x.ShowDate = false);
			currentDate = currentDate.AddMonths(-1);
			UpdateMonthLabel(); // 更新月份标签
			CreateCalendar();
		}

		private void UpdateMonthLabel()
		{
			MonthLabel.Text = currentDate.ToShortDateString();
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