package crc6464e9980dccb00d43;


public class OneSignalImplementation_OSEmailUpdateHandler
	extends crc6464e9980dccb00d43.OneSignalImplementation_JavaLaterProxy_1
	implements
		mono.android.IGCUserPeer,
		com.onesignal.OneSignal.EmailUpdateHandler
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFailure:(Lcom/onesignal/OneSignal$EmailUpdateError;)V:GetOnFailure_Lcom_onesignal_OneSignal_EmailUpdateError_Handler:Com.OneSignal.Android.OneSignal/IEmailUpdateHandlerInvoker, OneSignal.Android.Binding\n" +
			"n_onSuccess:()V:GetOnSuccessHandler:Com.OneSignal.Android.OneSignal/IEmailUpdateHandlerInvoker, OneSignal.Android.Binding\n" +
			"";
		mono.android.Runtime.register ("OneSignalSDK.Xamarin.OneSignalImplementation+OSEmailUpdateHandler, OneSignalSDK.Xamarin", OneSignalImplementation_OSEmailUpdateHandler.class, __md_methods);
	}


	public OneSignalImplementation_OSEmailUpdateHandler ()
	{
		super ();
		if (getClass () == OneSignalImplementation_OSEmailUpdateHandler.class) {
			mono.android.TypeManager.Activate ("OneSignalSDK.Xamarin.OneSignalImplementation+OSEmailUpdateHandler, OneSignalSDK.Xamarin", "", this, new java.lang.Object[] {  });
		}
	}


	public void onFailure (com.onesignal.OneSignal.EmailUpdateError p0)
	{
		n_onFailure (p0);
	}

	private native void n_onFailure (com.onesignal.OneSignal.EmailUpdateError p0);


	public void onSuccess ()
	{
		n_onSuccess ();
	}

	private native void n_onSuccess ();

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
