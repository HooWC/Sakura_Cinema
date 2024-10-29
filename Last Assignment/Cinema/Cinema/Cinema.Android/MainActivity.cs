using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using OneSignalSDK.Xamarin;

namespace Cinema.Droid
{
	[Activity(Label = "Sakura Cinema", Icon = "@drawable/logonone", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			//信息通知
			OneSignal.Default.Initialize("aa0150b5-ea7a-4d62-812e-3f7aaabaae5b");
			OneSignal.Default.PromptForPushNotificationsWithUserResponse();
			Rg.Plugins.Popup.Popup.Init(this);

			Xamarin.Essentials.Platform.Init(this, savedInstanceState);
			global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
			ImageCircleRenderer.Init();
			Window.SetStatusBarColor(Android.Graphics.Color.Rgb(45, 45, 46));
			//Window.SetStatusBarColor(Android.Graphics.Color.Rgb(45, 45, 46));
			FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);
			LoadApplication(new App());
			Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
		}
		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
		{
			Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

			base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}
	}
}