; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [314 x i64] [
	i64 2646484529726201, ; 0: FFImageLoading.Forms.Platform => 0x966f6b24c42f9 => 13
	i64 24362543149721218, ; 1: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 69
	i64 30579257353033782, ; 2: Syncfusion.Buttons.XForms => 0x6ca3ac2c05d836 => 28
	i64 120698629574877762, ; 3: Mono.Android => 0x1accec39cafe242 => 18
	i64 210515253464952879, ; 4: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 59
	i64 232391251801502327, ; 5: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 94
	i64 263803244706540312, ; 6: Rg.Plugins.Popup.dll => 0x3a937a743542b18 => 26
	i64 295915112840604065, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 95
	i64 347331204332682223, ; 8: ImageCircle.Forms.Plugin => 0x4d1f7e3dda87bef => 16
	i64 634308326490598313, ; 9: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 78
	i64 702024105029695270, ; 10: System.Drawing.Common => 0x9be17343c0e7726 => 8
	i64 720058930071658100, ; 11: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 72
	i64 872800313462103108, ; 12: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 68
	i64 940822596282819491, ; 13: System.Transactions => 0xd0e792aa81923a3 => 142
	i64 996343623809489702, ; 14: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 121
	i64 1000557547492888992, ; 15: Mono.Security.dll => 0xde2b1c9cba651a0 => 156
	i64 1120440138749646132, ; 16: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 126
	i64 1315114680217950157, ; 17: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 54
	i64 1425944114962822056, ; 18: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 9
	i64 1465843056802068477, ; 19: Xamarin.Firebase.Components.dll => 0x1457b87e6928f7fd => 111
	i64 1476839205573959279, ; 20: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 151
	i64 1624659445732251991, ; 21: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 52
	i64 1628611045998245443, ; 22: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 81
	i64 1636321030536304333, ; 23: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 73
	i64 1731380447121279447, ; 24: Newtonsoft.Json => 0x18071957e9b889d7 => 20
	i64 1795316252682057001, ; 25: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 53
	i64 1836611346387731153, ; 26: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 94
	i64 1837131419302612636, ; 27: Xamarin.Google.Android.DataTransport.TransportBackendCct.dll => 0x197ecd4ad53dce9c => 124
	i64 1875917498431009007, ; 28: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 50
	i64 1981742497975770890, ; 29: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 80
	i64 1984538867944326539, ; 30: FFImageLoading.Platform.dll => 0x1b8a7f95fac7058b => 14
	i64 2064708342624596306, ; 31: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 137
	i64 2076847052340733488, ; 32: Syncfusion.Core.XForms => 0x1cd27163f7962630 => 30
	i64 2133195048986300728, ; 33: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 20
	i64 2136356949452311481, ; 34: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 85
	i64 2165725771938924357, ; 35: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 57
	i64 2262844636196693701, ; 36: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 68
	i64 2284400282711631002, ; 37: System.Web.Services => 0x1fb3d1f42fd4249a => 147
	i64 2329709569556905518, ; 38: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 76
	i64 2469392061734276978, ; 39: Syncfusion.Core.XForms.Android.dll => 0x22450aff2ad74f72 => 29
	i64 2470498323731680442, ; 40: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 63
	i64 2479423007379663237, ; 41: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 102
	i64 2497223385847772520, ; 42: System.Runtime => 0x22a7eb7046413568 => 46
	i64 2547086958574651984, ; 43: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 49
	i64 2592350477072141967, ; 44: System.Xml.dll => 0x23f9e10627330e8f => 47
	i64 2624866290265602282, ; 45: mscorlib.dll => 0x246d65fbde2db8ea => 19
	i64 2689772414458801262, ; 46: Syncfusion.SfTabView.XForms.Android => 0x2553fdc28a762c6e => 39
	i64 2694427813909235223, ; 47: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 89
	i64 2787234703088983483, ; 48: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 98
	i64 2863324215353042462, ; 49: FFImageLoading.Forms => 0x27bc92340ce4661e => 12
	i64 2960931600190307745, ; 50: Xamarin.Forms.Core => 0x2917579a49927da1 => 118
	i64 3017704767998173186, ; 51: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 126
	i64 3289520064315143713, ; 52: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 75
	i64 3303437397778967116, ; 53: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 51
	i64 3311221304742556517, ; 54: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 45
	i64 3339480741387858005, ; 55: Xamarin.AndroidX.Work.Runtime => 0x2e58380a7cae7055 => 107
	i64 3364695309916733813, ; 56: Xamarin.Firebase.Common => 0x2eb1cc8eb5028175 => 110
	i64 3411255996856937470, ; 57: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 129
	i64 3446289425061894800, ; 58: OneSignalSDK.Xamarin => 0x2fd3adf90dffda90 => 23
	i64 3493805808809882663, ; 59: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 100
	i64 3522470458906976663, ; 60: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 99
	i64 3531994851595924923, ; 61: System.Numerics => 0x31042a9aade235bb => 44
	i64 3571415421602489686, ; 62: System.Runtime.dll => 0x319037675df7e556 => 46
	i64 3716579019761409177, ; 63: netstandard.dll => 0x3393f0ed5c8c5c99 => 140
	i64 3727469159507183293, ; 64: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 91
	i64 3772598417116884899, ; 65: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 69
	i64 3788644642786275579, ; 66: PanCardView => 0x3493f83ac17670fb => 24
	i64 3943415582112705276, ; 67: Syncfusion.Buttons.XForms.dll => 0x36b9d3942d916afc => 28
	i64 4152527201570278149, ; 68: Syncfusion.SfRotator.Android.dll => 0x39a0bd7d21be4b05 => 36
	i64 4247996603072512073, ; 69: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 132
	i64 4248804899347366872, ; 70: Xamarin.AndroidX.Room.Common.dll => 0x3af6c98b798a03d8 => 92
	i64 4335356748765836238, ; 71: Xamarin.Google.Android.DataTransport.TransportBackendCct => 0x3c2a47fe48c7b3ce => 124
	i64 4500292229471022193, ; 72: Xamarin.Google.Dagger.dll => 0x3e743ff06b122c71 => 127
	i64 4525561845656915374, ; 73: System.ServiceModel.Internals => 0x3ece06856b710dae => 139
	i64 4636684751163556186, ; 74: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 104
	i64 4702770163853758138, ; 75: Xamarin.Firebase.Components => 0x4143988c34cf0eba => 111
	i64 4782108999019072045, ; 76: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 56
	i64 4794310189461587505, ; 77: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 49
	i64 4795410492532947900, ; 78: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 99
	i64 4941606650460547470, ; 79: Syncfusion.SfTabView.XForms.dll => 0x44941d111c68a98e => 40
	i64 5081566143765835342, ; 80: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 1
	i64 5099468265966638712, ; 81: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 1
	i64 5142919913060024034, ; 82: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 120
	i64 5203618020066742981, ; 83: Xamarin.Essentials => 0x4836f704f0e652c5 => 108
	i64 5205316157927637098, ; 84: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 83
	i64 5348796042099802469, ; 85: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 84
	i64 5375264076663995773, ; 86: Xamarin.Forms.PancakeView => 0x4a98c632c779bd7d => 119
	i64 5376510917114486089, ; 87: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 102
	i64 5408338804355907810, ; 88: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 101
	i64 5446034149219586269, ; 89: System.Diagnostics.Debug => 0x4b94333452e150dd => 150
	i64 5451019430259338467, ; 90: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 62
	i64 5507995362134886206, ; 91: System.Core.dll => 0x4c705499688c873e => 41
	i64 5514426807633697079, ; 92: Xamarin.AndroidX.Sqlite => 0x4c872df700e5d937 => 96
	i64 5692067934154308417, ; 93: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 106
	i64 5757522595884336624, ; 94: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 60
	i64 5759039185982771185, ; 95: Xamarin.AndroidX.Lifecycle.Service => 0x4fec37a0800ecff1 => 79
	i64 5814345312393086621, ; 96: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 89
	i64 5896680224035167651, ; 97: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 77
	i64 6085203216496545422, ; 98: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 121
	i64 6086316965293125504, ; 99: FormsViewGroup.dll => 0x5476f10882baef80 => 15
	i64 6092862891035488599, ; 100: Xamarin.Firebase.Measurement.Connector.dll => 0x548e32849d547157 => 116
	i64 6167443447940383130, ; 101: OneSignal.Android.Binding.dll => 0x55972923aecc019a => 21
	i64 6319713645133255417, ; 102: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 78
	i64 6401687960814735282, ; 103: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 76
	i64 6414004466313930583, ; 104: Syncfusion.SfRotator.XForms => 0x59031f144a692757 => 38
	i64 6504860066809920875, ; 105: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 57
	i64 6548213210057960872, ; 106: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 66
	i64 6554405243736097249, ; 107: Xamarin.GooglePlayServices.Stats => 0x5af5ecd7aad901e1 => 131
	i64 6591024623626361694, ; 108: System.Web.Services.dll => 0x5b7805f9751a1b5e => 147
	i64 6659513131007730089, ; 109: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 72
	i64 6876862101832370452, ; 110: System.Xml.Linq => 0x5f6f85a57d108914 => 48
	i64 6878582369430612696, ; 111: Xamarin.Google.Android.DataTransport.TransportRuntime.dll => 0x5f75a238802d2ad8 => 125
	i64 6894844156784520562, ; 112: System.Numerics.Vectors => 0x5faf683aead1ad72 => 45
	i64 6975328107116786489, ; 113: Xamarin.Firebase.Annotations => 0x60cd57f4e07e7339 => 109
	i64 7026608356547306326, ; 114: Syncfusion.Core.XForms.dll => 0x618387125bcb2356 => 30
	i64 7036436454368433159, ; 115: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 74
	i64 7103753931438454322, ; 116: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 71
	i64 7270811800166795866, ; 117: System.Linq => 0x64e71ccf51a90a5a => 154
	i64 7270951509819434961, ; 118: Syncfusion.SfAutoComplete.XForms => 0x64e79be001e0a7d1 => 33
	i64 7338192458477945005, ; 119: System.Reflection => 0x65d67f295d0740ad => 2
	i64 7363614467969488359, ; 120: Xamarin.AndroidX.Sqlite.Framework.dll => 0x6630d058323f95e7 => 97
	i64 7385250113861300937, ; 121: Xamarin.Firebase.Iid.Interop.dll => 0x667dadd98e1db2c9 => 113
	i64 7488575175965059935, ; 122: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 48
	i64 7489048572193775167, ; 123: System.ObjectModel => 0x67ee71ff6b419e3f => 155
	i64 7635363394907363464, ; 124: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 118
	i64 7637365915383206639, ; 125: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 108
	i64 7654504624184590948, ; 126: System.Net.Http => 0x6a3a4366801b8264 => 43
	i64 7735352534559001595, ; 127: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 136
	i64 7820441508502274321, ; 128: System.Data => 0x6c87ca1e14ff8111 => 141
	i64 7836164640616011524, ; 129: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 52
	i64 7842383726582361265, ; 130: Xamarin.AndroidX.Sqlite.dll => 0x6cd5be72d73eecb1 => 96
	i64 7888451308934344906, ; 131: OneSignalSDK.Xamarin.Core.dll => 0x6d7968abb0ff30ca => 22
	i64 7904570928025870493, ; 132: Xamarin.Firebase.Installations => 0x6db2ad60fadca09d => 114
	i64 7940488133782528123, ; 133: Xamarin.GooglePlayServices.CloudMessaging => 0x6e3247e31d4fe07b => 130
	i64 7969431548154767168, ; 134: Xamarin.Firebase.Installations.dll => 0x6e991bc4e98e6740 => 114
	i64 7974414903991570916, ; 135: Cinema => 0x6eaad01adbff91e4 => 10
	i64 8044118961405839122, ; 136: System.ComponentModel.Composition => 0x6fa2739369944712 => 146
	i64 8064050204834738623, ; 137: System.Collections.dll => 0x6fe942efa61731bf => 3
	i64 8083354569033831015, ; 138: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 75
	i64 8103644804370223335, ; 139: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 143
	i64 8113615946733131500, ; 140: System.Reflection.Extensions => 0x70995ab73cf916ec => 5
	i64 8167236081217502503, ; 141: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 17
	i64 8185542183669246576, ; 142: System.Collections => 0x7198e33f4794aa70 => 3
	i64 8205064624148743999, ; 143: OneSignal.Android.Binding => 0x71de3ecda982873f => 21
	i64 8290740647658429042, ; 144: System.Runtime.Extensions => 0x730ea0b15c929a72 => 4
	i64 8398329775253868912, ; 145: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 61
	i64 8400357532724379117, ; 146: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 88
	i64 8465511506719290632, ; 147: Xamarin.Firebase.Messaging.dll => 0x757b89dcf7fc3508 => 117
	i64 8517710342570482946, ; 148: Syncfusion.Buttons.XForms.Android => 0x7634fc6d84959d02 => 27
	i64 8601935802264776013, ; 149: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 101
	i64 8626175481042262068, ; 150: Java.Interop => 0x77b654e585b55834 => 17
	i64 8639588376636138208, ; 151: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 87
	i64 8684531736582871431, ; 152: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 145
	i64 8853378295825400934, ; 153: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 135
	i64 9099924959696254698, ; 154: Syncfusion.SfRotator.XForms.Android.dll => 0x7e496d899167f6ea => 37
	i64 9113372623695166316, ; 155: Syncfusion.SfRotator.XForms.Android => 0x7e79341dd51ebb6c => 37
	i64 9114191852432800567, ; 156: FFImageLoading.dll => 0x7e7c1d3363043b37 => 11
	i64 9238306115887712111, ; 157: FFImageLoading.Forms.dll => 0x80350e773bce476f => 12
	i64 9238909584418939062, ; 158: Xamarin.AndroidX.Sqlite.Framework => 0x80373351333e20b6 => 97
	i64 9293890220217345133, ; 159: Syncfusion.SfAutoComplete.XForms.Android.dll => 0x80fa87ea0588246d => 32
	i64 9312692141327339315, ; 160: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 106
	i64 9324707631942237306, ; 161: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 53
	i64 9584643793929893533, ; 162: System.IO.dll => 0x85037ebfbbd7f69d => 149
	i64 9659729154652888475, ; 163: System.Text.RegularExpressions => 0x860e407c9991dd9b => 153
	i64 9662334977499516867, ; 164: System.Numerics.dll => 0x8617827802b0cfc3 => 44
	i64 9678050649315576968, ; 165: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 63
	i64 9684590680804540597, ; 166: OneSignalSDK.Xamarin.Core => 0x866693e9bc69c0b5 => 22
	i64 9695067051349111183, ; 167: PanCardView.Droid.dll => 0x868bcc1dd541f18f => 25
	i64 9711637524876806384, ; 168: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 84
	i64 9754517241374622406, ; 169: Syncfusion.SfAutoComplete.XForms.Android => 0x875f01bfd78ec2c6 => 32
	i64 9774216967140627647, ; 170: Xamarin.Firebase.Datatransport.dll => 0x87a4fe8bac0354bf => 112
	i64 9796610708422913120, ; 171: Xamarin.Firebase.Iid.Interop => 0x87f48d88de55ec60 => 113
	i64 9808709177481450983, ; 172: Mono.Android.dll => 0x881f890734e555e7 => 18
	i64 9825649861376906464, ; 173: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 60
	i64 9834056768316610435, ; 174: System.Transactions.dll => 0x8879968718899783 => 142
	i64 9998632235833408227, ; 175: Mono.Security => 0x8ac2470b209ebae3 => 156
	i64 10038780035334861115, ; 176: System.Net.Http.dll => 0x8b50e941206af13b => 43
	i64 10226222362177979215, ; 177: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 137
	i64 10229024438826829339, ; 178: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 66
	i64 10269716227397343482, ; 179: Syncfusion.SfRotator.XForms.dll => 0x8e855c7f5e1558fa => 38
	i64 10321854143672141184, ; 180: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 134
	i64 10352330178246763130, ; 181: Xamarin.Firebase.Measurement.Connector => 0x8faadd72b7f4627a => 116
	i64 10360651442923773544, ; 182: System.Text.Encoding => 0x8fc86d98211c1e68 => 6
	i64 10376576884623852283, ; 183: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 100
	i64 10421511051509811956, ; 184: Xamarin.AndroidX.Room.Runtime.dll => 0x90a0a515f80ccaf4 => 93
	i64 10430153318873392755, ; 185: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 64
	i64 10566960649245365243, ; 186: System.Globalization.dll => 0x92a562b96dcd13fb => 7
	i64 10679925812255520825, ; 187: Xamarin.AndroidX.Work.Runtime.dll => 0x9436b7f10b03f839 => 107
	i64 10714184849103829812, ; 188: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 4
	i64 10785150219063592792, ; 189: System.Net.Primitives => 0x95ac8cfb68830758 => 151
	i64 10847732767863316357, ; 190: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 54
	i64 10849603794298325860, ; 191: Xamarin.AndroidX.Room.Common => 0x9691892ad0e1cb64 => 92
	i64 11023048688141570732, ; 192: System.Core => 0x98f9bc61168392ac => 41
	i64 11037814507248023548, ; 193: System.Xml => 0x992e31d0412bf7fc => 47
	i64 11162124722117608902, ; 194: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 105
	i64 11171845786728836392, ; 195: Xamarin.GooglePlayServices.CloudMessaging.dll => 0x9b0a5e8d536aad28 => 130
	i64 11336891506707244397, ; 196: Xamarin.Firebase.Datatransport => 0x9d54bac28a6da56d => 112
	i64 11340910727871153756, ; 197: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 65
	i64 11376351552967644903, ; 198: Xamarin.Firebase.Annotations.dll => 0x9de0eb76829996e7 => 109
	i64 11392833485892708388, ; 199: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 90
	i64 11529969570048099689, ; 200: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 105
	i64 11578238080964724296, ; 201: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 74
	i64 11580057168383206117, ; 202: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 50
	i64 11591352189662810718, ; 203: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 98
	i64 11597940890313164233, ; 204: netstandard => 0xa0f429ca8d1805c9 => 140
	i64 11606334278361545453, ; 205: Syncfusion.SfMaskedEdit.XForms.Android => 0xa111fb887e2dfaed => 34
	i64 11619874950061906932, ; 206: Syncfusion.SfTabView.XForms => 0xa14216b3cce65bf4 => 40
	i64 11672361001936329215, ; 207: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 71
	i64 11743665907891708234, ; 208: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 148
	i64 11855946309386773903, ; 209: Xamarin.Google.Dagger => 0xa488c85a571a258f => 127
	i64 11869220915266023700, ; 210: Syncfusion.SfAutoComplete.XForms.dll => 0xa4b7f1895f117114 => 33
	i64 11893008123000655976, ; 211: Cinema.Android.dll => 0xa50c73e0424a1068 => 0
	i64 11958013547207876529, ; 212: OneSignalSDK.Xamarin.dll => 0xa5f365f704a25fb1 => 23
	i64 12123043025855404482, ; 213: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 5
	i64 12137774235383566651, ; 214: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 103
	i64 12312508881223092658, ; 215: Syncfusion.SfMaskedEdit.XForms.Android.dll => 0xaaded197cf2509b2 => 34
	i64 12346958216201575315, ; 216: Xamarin.JavaX.Inject.dll => 0xab593514a5491b93 => 133
	i64 12451044538927396471, ; 217: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 70
	i64 12466513435562512481, ; 218: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 82
	i64 12487638416075308985, ; 219: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 67
	i64 12538491095302438457, ; 220: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 58
	i64 12550732019250633519, ; 221: System.IO.Compression => 0xae2d28465e8e1b2f => 144
	i64 12700543734426720211, ; 222: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 59
	i64 12708238894395270091, ; 223: System.IO => 0xb05cbbf17d3ba3cb => 149
	i64 12828192437253469131, ; 224: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 138
	i64 12963446364377008305, ; 225: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 8
	i64 13370592475155966277, ; 226: System.Runtime.Serialization => 0xb98de304062ea945 => 9
	i64 13391361154981494717, ; 227: Syncfusion.Buttons.XForms.Android.dll => 0xb9d7ac051da2ffbd => 27
	i64 13401370062847626945, ; 228: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 103
	i64 13404347523447273790, ; 229: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 61
	i64 13454009404024712428, ; 230: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 128
	i64 13465488254036897740, ; 231: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 136
	i64 13491513212026656886, ; 232: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 55
	i64 13572454107664307259, ; 233: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 91
	i64 13622732128915678507, ; 234: Syncfusion.Core.XForms.Android => 0xbd0daab1e651e52b => 29
	i64 13647894001087880694, ; 235: System.Data.dll => 0xbd670f48cb071df6 => 141
	i64 13828521679616088467, ; 236: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 135
	i64 13829530607229561650, ; 237: Xamarin.Firebase.Installations.InterOp => 0xbfec5cd0b64f6b32 => 115
	i64 13852575513600495870, ; 238: ImageCircle.Forms.Plugin.dll => 0xc03e3c09186e90fe => 16
	i64 13902543935539791585, ; 239: Syncfusion.SfMaskedEdit.XForms => 0xc0efc20cf01c46e1 => 35
	i64 13959074834287824816, ; 240: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 70
	i64 13967638549803255703, ; 241: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 120
	i64 13970307180132182141, ; 242: Syncfusion.Licensing => 0xc1e0805ccade287d => 31
	i64 13987974187833695008, ; 243: Xamarin.AndroidX.Lifecycle.Service.dll => 0xc21f446991291b20 => 79
	i64 14124974489674258913, ; 244: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 58
	i64 14125464355221830302, ; 245: System.Threading.dll => 0xc407bafdbc707a9e => 152
	i64 14172845254133543601, ; 246: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 85
	i64 14261073672896646636, ; 247: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 90
	i64 14327695147300244862, ; 248: System.Reflection.dll => 0xc6d632d338eb4d7e => 2
	i64 14343779804637125676, ; 249: PanCardView.Droid => 0xc70f57bc57d15c2c => 25
	i64 14454106681488828596, ; 250: PanCardView.dll => 0xc8974d7217bde8b4 => 24
	i64 14486659737292545672, ; 251: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 77
	i64 14524915121004231475, ; 252: Xamarin.JavaX.Inject => 0xc992dd58a4283b33 => 133
	i64 14538127318538747197, ; 253: Syncfusion.Licensing.dll => 0xc9c1cdc518e77d3d => 31
	i64 14644440854989303794, ; 254: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 83
	i64 14789919016435397935, ; 255: Xamarin.Firebase.Common.dll => 0xcd4058fc2f6d352f => 110
	i64 14792063746108907174, ; 256: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 128
	i64 14809388726477333247, ; 257: Xamarin.GooglePlayServices.Stats.dll => 0xcd8584954e5b22ff => 131
	i64 14852515768018889994, ; 258: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 65
	i64 14987728460634540364, ; 259: System.IO.Compression.dll => 0xcfff1ba06622494c => 144
	i64 14988210264188246988, ; 260: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 67
	i64 15076659072870671916, ; 261: System.ObjectModel.dll => 0xd13b0d8c1620662c => 155
	i64 15133485256822086103, ; 262: System.Linq.dll => 0xd204f0a9127dd9d7 => 154
	i64 15241747024500257992, ; 263: Syncfusion.SfMaskedEdit.XForms.dll => 0xd385902a1fb474c8 => 35
	i64 15370334346939861994, ; 264: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 64
	i64 15398511348637731642, ; 265: FFImageLoading.Forms.Platform.dll => 0xd5b2807c9d5f8b3a => 13
	i64 15526743539506359484, ; 266: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 6
	i64 15582737692548360875, ; 267: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 81
	i64 15609085926864131306, ; 268: System.dll => 0xd89e9cf3334914ea => 42
	i64 15777549416145007739, ; 269: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 95
	i64 15810740023422282496, ; 270: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 122
	i64 15817206913877585035, ; 271: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 148
	i64 15833835118871934951, ; 272: Cinema.dll => 0xdbbd15263c7777e7 => 10
	i64 15930129725311349754, ; 273: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 132
	i64 16154507427712707110, ; 274: System => 0xe03056ea4e39aa26 => 42
	i64 16423015068819898779, ; 275: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 138
	i64 16467346005009053642, ; 276: Xamarin.Google.Android.DataTransport.TransportApi => 0xe487c3f19e0337ca => 123
	i64 16565028646146589191, ; 277: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 146
	i64 16621146507174665210, ; 278: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 62
	i64 16677317093839702854, ; 279: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 88
	i64 16692709264874261820, ; 280: Cinema.Android => 0xe7a86aa277b3cd3c => 0
	i64 16822611501064131242, ; 281: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 143
	i64 16833383113903931215, ; 282: mscorlib => 0xe99c30c1484d7f4f => 19
	i64 16890310621557459193, ; 283: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 153
	i64 16980913776273025751, ; 284: Syncfusion.SfRotator.Android => 0xeba8531c5c4a6ad7 => 36
	i64 17024911836938395553, ; 285: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 51
	i64 17031351772568316411, ; 286: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 86
	i64 17037200463775726619, ; 287: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 73
	i64 17285063141349522879, ; 288: Rg.Plugins.Popup => 0xefe0e158cc55fdbf => 26
	i64 17434242208926550937, ; 289: Xamarin.Google.Android.DataTransport.TransportRuntime => 0xf1f2deeb1f304b99 => 125
	i64 17544493274320527064, ; 290: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 56
	i64 17627500474728259406, ; 291: System.Globalization => 0xf4a176498a351f4e => 7
	i64 17643123953373031521, ; 292: FFImageLoading => 0xf4d8f7c220fc2c61 => 11
	i64 17677828421478984182, ; 293: Xamarin.Firebase.Installations.InterOp.dll => 0xf5544349c68f29f6 => 115
	i64 17685921127322830888, ; 294: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 150
	i64 17704177640604968747, ; 295: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 82
	i64 17710060891934109755, ; 296: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 80
	i64 17827832363535584534, ; 297: Xamarin.Forms.PancakeView.dll => 0xf7692f1427c04d16 => 119
	i64 17865949717230441556, ; 298: Xamarin.AndroidX.Room.Runtime => 0xf7f09a9c2682d454 => 93
	i64 17882897186074144999, ; 299: FormsViewGroup => 0xf82cd03e3ac830e7 => 15
	i64 17891337867145587222, ; 300: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 134
	i64 17892495832318972303, ; 301: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 122
	i64 17928294245072900555, ; 302: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 145
	i64 17945795017270165205, ; 303: Xamarin.Google.Android.DataTransport.TransportApi.dll => 0xf90c457cc05cfed5 => 123
	i64 17947624217716767869, ; 304: FFImageLoading.Platform => 0xf912c522ab34bc7d => 14
	i64 17986907704309214542, ; 305: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 129
	i64 18025913125965088385, ; 306: System.Threading => 0xfa28e87b91334681 => 152
	i64 18116111925905154859, ; 307: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 55
	i64 18121036031235206392, ; 308: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 86
	i64 18129453464017766560, ; 309: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 139
	i64 18305135509493619199, ; 310: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 87
	i64 18337470502355292274, ; 311: Xamarin.Firebase.Messaging => 0xfe7bc8440c175072 => 117
	i64 18380184030268848184, ; 312: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 104
	i64 18409051266390776985 ; 313: Syncfusion.SfTabView.XForms.Android.dll => 0xff7a1697692d5c99 => 39
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [314 x i32] [
	i32 13, i32 69, i32 28, i32 18, i32 59, i32 94, i32 26, i32 95, ; 0..7
	i32 16, i32 78, i32 8, i32 72, i32 68, i32 142, i32 121, i32 156, ; 8..15
	i32 126, i32 54, i32 9, i32 111, i32 151, i32 52, i32 81, i32 73, ; 16..23
	i32 20, i32 53, i32 94, i32 124, i32 50, i32 80, i32 14, i32 137, ; 24..31
	i32 30, i32 20, i32 85, i32 57, i32 68, i32 147, i32 76, i32 29, ; 32..39
	i32 63, i32 102, i32 46, i32 49, i32 47, i32 19, i32 39, i32 89, ; 40..47
	i32 98, i32 12, i32 118, i32 126, i32 75, i32 51, i32 45, i32 107, ; 48..55
	i32 110, i32 129, i32 23, i32 100, i32 99, i32 44, i32 46, i32 140, ; 56..63
	i32 91, i32 69, i32 24, i32 28, i32 36, i32 132, i32 92, i32 124, ; 64..71
	i32 127, i32 139, i32 104, i32 111, i32 56, i32 49, i32 99, i32 40, ; 72..79
	i32 1, i32 1, i32 120, i32 108, i32 83, i32 84, i32 119, i32 102, ; 80..87
	i32 101, i32 150, i32 62, i32 41, i32 96, i32 106, i32 60, i32 79, ; 88..95
	i32 89, i32 77, i32 121, i32 15, i32 116, i32 21, i32 78, i32 76, ; 96..103
	i32 38, i32 57, i32 66, i32 131, i32 147, i32 72, i32 48, i32 125, ; 104..111
	i32 45, i32 109, i32 30, i32 74, i32 71, i32 154, i32 33, i32 2, ; 112..119
	i32 97, i32 113, i32 48, i32 155, i32 118, i32 108, i32 43, i32 136, ; 120..127
	i32 141, i32 52, i32 96, i32 22, i32 114, i32 130, i32 114, i32 10, ; 128..135
	i32 146, i32 3, i32 75, i32 143, i32 5, i32 17, i32 3, i32 21, ; 136..143
	i32 4, i32 61, i32 88, i32 117, i32 27, i32 101, i32 17, i32 87, ; 144..151
	i32 145, i32 135, i32 37, i32 37, i32 11, i32 12, i32 97, i32 32, ; 152..159
	i32 106, i32 53, i32 149, i32 153, i32 44, i32 63, i32 22, i32 25, ; 160..167
	i32 84, i32 32, i32 112, i32 113, i32 18, i32 60, i32 142, i32 156, ; 168..175
	i32 43, i32 137, i32 66, i32 38, i32 134, i32 116, i32 6, i32 100, ; 176..183
	i32 93, i32 64, i32 7, i32 107, i32 4, i32 151, i32 54, i32 92, ; 184..191
	i32 41, i32 47, i32 105, i32 130, i32 112, i32 65, i32 109, i32 90, ; 192..199
	i32 105, i32 74, i32 50, i32 98, i32 140, i32 34, i32 40, i32 71, ; 200..207
	i32 148, i32 127, i32 33, i32 0, i32 23, i32 5, i32 103, i32 34, ; 208..215
	i32 133, i32 70, i32 82, i32 67, i32 58, i32 144, i32 59, i32 149, ; 216..223
	i32 138, i32 8, i32 9, i32 27, i32 103, i32 61, i32 128, i32 136, ; 224..231
	i32 55, i32 91, i32 29, i32 141, i32 135, i32 115, i32 16, i32 35, ; 232..239
	i32 70, i32 120, i32 31, i32 79, i32 58, i32 152, i32 85, i32 90, ; 240..247
	i32 2, i32 25, i32 24, i32 77, i32 133, i32 31, i32 83, i32 110, ; 248..255
	i32 128, i32 131, i32 65, i32 144, i32 67, i32 155, i32 154, i32 35, ; 256..263
	i32 64, i32 13, i32 6, i32 81, i32 42, i32 95, i32 122, i32 148, ; 264..271
	i32 10, i32 132, i32 42, i32 138, i32 123, i32 146, i32 62, i32 88, ; 272..279
	i32 0, i32 143, i32 19, i32 153, i32 36, i32 51, i32 86, i32 73, ; 280..287
	i32 26, i32 125, i32 56, i32 7, i32 11, i32 115, i32 150, i32 82, ; 288..295
	i32 80, i32 119, i32 93, i32 15, i32 134, i32 122, i32 145, i32 123, ; 296..303
	i32 14, i32 129, i32 152, i32 55, i32 86, i32 139, i32 87, i32 117, ; 304..311
	i32 104, i32 39 ; 312..313
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
