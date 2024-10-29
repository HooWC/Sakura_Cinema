package crc6464e9980dccb00d43;


public class OneSignalImplementation_OSPromptForPushNotificationPermissionResponseHandler
	extends crc6464e9980dccb00d43.OneSignalImplementation_JavaLaterProxy_1
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.PromptForPushNotificationPermissionResponseHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_response:(Z)V:GetResponse_ZHandler:Com.OneSignal.Android.OneSignal/IPromptForPushNotificationPermissionResponseHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("OneSignalSDK.Xamarin.OneSignalImplementation+OSPromptForPushNotificationPermissionResponseHandler, OneSignalSDK.Xamarin", OneSignalImplementation_OSPromptForPushNotificationPermissionResponseHandler.class, __md_methods);
	}


	public OneSignalImplementation_OSPromptForPushNotificationPermissionResponseHandler ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSPromptForPushNotificationPermissionResponseHandler.class) {
			mono.android.TypeManager.Activate ("OneSignalSDK.Xamarin.OneSignalImplementation+OSPromptForPushNotificationPermissionResponseHandler, OneSignalSDK.Xamarin", "", this, new java.lang.Object[] {  });
		}
	}


	public void response (boolean p0)
	{
		n_response (p0);
	}

	private native void n_response (boolean p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
