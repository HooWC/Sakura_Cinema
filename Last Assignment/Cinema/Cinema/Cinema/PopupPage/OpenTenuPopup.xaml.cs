using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Cinema.View;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema.PopupPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OpenTenuPopup
	{
		public static string type = "";

		public OpenTenuPopup()
		{
			InitializeComponent();
			type = "";
			Button_Clicked();

		}

		public void Button_Clicked()
		{
			string[] str = new string[]
			{
				"Horror","Love","Action","Drama","Thriller","Comedy","Sci-Fi",
				"War","Crime","Adventure","Disaster","Classic","Homosexual"
			};

			var mygridlayout = MyGrid as Grid;

			int num = 0;
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 3; j++)
				{

					if (num < 13)
					{

						var NewStack = new Frame
						{
							BackgroundColor = Color.LightGray,
							Padding = 10,
							HasShadow = false,
							Margin = new Thickness(5),
							HeightRequest = 30,
							WidthRequest = 100,
							CornerRadius = 5
						};

						var label = new Label
						{
							Text = $"{str[num]}",
							FontAttributes = FontAttributes.Bold,
							VerticalTextAlignment = TextAlignment.Center,
							FontSize = 12,
							TextColor = Color.Black,
							HorizontalOptions = LayoutOptions.CenterAndExpand,
							VerticalOptions = LayoutOptions.CenterAndExpand,
						};

						NewStack.Content = new StackLayout
						{
							Children = { label },
						};

						num++;

						TapGestureRecognizer tapGesture = new TapGestureRecognizer();
						tapGesture.CommandParameter = $"";
						tapGesture.Tapped += async (s, arg) =>
						{

							await ((Frame)s).ScaleTo(0.9, 10, Easing.Linear);
							await Task.Delay(10);
							await ((Frame)s).ScaleTo(1, 10, Easing.Linear);

							var clickedFrame = s as Frame;
							var stackLayout = clickedFrame.Content as StackLayout;
							var label_text = stackLayout.Children[0] as Label;
							//var labeldata = clickedFrame.Children[0] as Label;
							//int selectedDay = int.Parse(label.Text);

							//DisplayAlert("", labeldata.Text, "ok");

							//var text = $"{currentDate.Month}/{selectedDay}/{currentDate.Year}";
							//MonthLabel.Text = text;

							//PopupNavigation.PushAsync(new CalendarPopup(text));


							if (clickedFrame.BackgroundColor == Color.LightGray)
							{
								clickedFrame.BackgroundColor = Color.LightGreen;
							}
							else
							{
								clickedFrame.BackgroundColor = Color.LightGray;
								//DisplayAlert("", label_text.Text, "ok");
								type = type.Replace($"{label_text.Text}|", "");
								//DisplayAlert("", type, "OK");
							}

							foreach (var pair in (clickedFrame).Children)
							{
								var Eachseat = pair as StackLayout;

								if (clickedFrame.BackgroundColor == Color.LightGreen)
								{
									type += (Eachseat.Children[0] as Label).Text + "|";
									//DisplayAlert("", type, "OK");
								}
							}


						};

						NewStack.GestureRecognizers.Add(tapGesture);

						mygridlayout.Children.Add(NewStack, j, i);
					}
				}
			}


		}

		private async void CheckOut(object sender, EventArgs e)
		{
			await ((SfButton)sender).ScaleTo(0.9, 10, Easing.Linear);
			await Task.Delay(10);
			await ((SfButton)sender).ScaleTo(1, 10, Easing.Linear);

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

			if (type != "")
			{
				PopupNavigation.PopAsync();
				Navigation.PushAsync(new MovieTuneSearchPage(type));
			}

		}
	}
}