using System;
using Cinema.View;
using OneSignalSDK.Xamarin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("ZCOOLKuaiLe-Regular.ttf", Alias = "AC")]
[assembly: ExportFont("Kalam-Regular.ttf", Alias = "BC")]
[assembly: ExportFont("Playball-Regular.ttf", Alias = "CC")]
[assembly: ExportFont("Merienda-Bold.ttf", Alias = "DC")]
[assembly: ExportFont("BerkshireSwash-Regular.ttf", Alias = "EC")]
[assembly: ExportFont("ConcertOne-Regular.ttf", Alias = "FC")]
[assembly: ExportFont("Viga-Regular.ttf", Alias = "GC")]
[assembly: ExportFont("LibreBaskerville-Italic.ttf", Alias = "HC")]

[assembly: ExportFont("Exo2-VariableFont_wght.ttf", Alias = "AA")]
[assembly: ExportFont("BebasNeue-Regular.ttf", Alias = "BA")]
[assembly: ExportFont("NotoSerifSC-Bold.ttf", Alias = "CA")]
[assembly: ExportFont("Signika-VariableFont_wght.ttf", Alias = "DA")]
[assembly: ExportFont("AbrilFatface-Regular.ttf", Alias = "EA")]
[assembly: ExportFont("Kalam-Bold.ttf", Alias = "FA")]

namespace Cinema
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();

			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjY5NTMxMUAzMjMxMmUzMDJlMzBTYVYrUXlLZzk4V1hFZ2FXc3k3ODU1NWJ6M2pKeE9TR2pvaGV6Q1ZEZkJjPQ==");
			InitializeComponent();
			MainPage = new NavigationPage(new Start());
			//MainPage = new NavigationPage(new LoginPage());

			OneSignal.Default.Initialize("aa0150b5-ea7a-4d62-812e-3f7aaabaae5b");
			OneSignal.Default.PromptForPushNotificationsWithUserResponse();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
