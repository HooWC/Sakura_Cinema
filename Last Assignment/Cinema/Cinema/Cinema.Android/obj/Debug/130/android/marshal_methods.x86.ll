; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [314 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 78
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 128
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 20
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 118
	i32 66706743, ; 4: Syncfusion.SfMaskedEdit.XForms.Android.dll => 0x3f9dd37 => 34
	i32 80722984, ; 5: Syncfusion.SfRotator.XForms.Android => 0x4cfbc28 => 37
	i32 99762151, ; 6: Syncfusion.Buttons.XForms.dll => 0x5f23fe7 => 28
	i32 101534019, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 95
	i32 103834273, ; 8: Xamarin.Firebase.Annotations.dll => 0x63062a1 => 109
	i32 120558881, ; 9: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 95
	i32 134690465, ; 10: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 137
	i32 165246403, ; 11: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 59
	i32 182336117, ; 12: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 99
	i32 209399409, ; 13: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 57
	i32 220171995, ; 14: System.Diagnostics.Debug => 0xd1f8edb => 150
	i32 230216969, ; 15: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 73
	i32 231814094, ; 16: System.Globalization => 0xdd133ce => 7
	i32 232815796, ; 17: System.Web.Services => 0xde07cb4 => 147
	i32 261689757, ; 18: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 62
	i32 266277096, ; 19: OneSignal.Android.Binding => 0xfdf10e8 => 21
	i32 278686392, ; 20: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 77
	i32 280482487, ; 21: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 71
	i32 307891448, ; 22: Xamarin.AndroidX.Work.Runtime.dll => 0x125a0cf8 => 107
	i32 318968648, ; 23: Xamarin.AndroidX.Activity.dll => 0x13031348 => 49
	i32 321597661, ; 24: System.Numerics => 0x132b30dd => 44
	i32 333836683, ; 25: OneSignalSDK.Xamarin.Core.dll => 0x13e5f18b => 22
	i32 342366114, ; 26: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 75
	i32 377964854, ; 27: Syncfusion.SfAutoComplete.XForms => 0x16874936 => 33
	i32 423914325, ; 28: Syncfusion.SfRotator.Android.dll => 0x19446b55 => 36
	i32 441335492, ; 29: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 61
	i32 442521989, ; 30: Xamarin.Essentials => 0x1a605985 => 108
	i32 442565967, ; 31: System.Collections => 0x1a61054f => 3
	i32 450948140, ; 32: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 70
	i32 465846621, ; 33: mscorlib => 0x1bc4415d => 19
	i32 469710990, ; 34: System.dll => 0x1bff388e => 42
	i32 476646585, ; 35: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 71
	i32 484505379, ; 36: PanCardView => 0x1ce0f723 => 24
	i32 485140951, ; 37: Xamarin.Google.Android.DataTransport.TransportRuntime => 0x1ceaa9d7 => 125
	i32 486930444, ; 38: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 83
	i32 495452658, ; 39: Xamarin.Google.Android.DataTransport.TransportRuntime.dll => 0x1d8801f2 => 125
	i32 498788369, ; 40: System.ObjectModel => 0x1dbae811 => 155
	i32 507148113, ; 41: Xamarin.Google.Android.DataTransport.TransportApi.dll => 0x1e3a7751 => 123
	i32 520798577, ; 42: FFImageLoading.Platform => 0x1f0ac171 => 14
	i32 526420162, ; 43: System.Transactions.dll => 0x1f6088c2 => 142
	i32 527452488, ; 44: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 137
	i32 542030372, ; 45: Xamarin.GooglePlayServices.Stats => 0x204eba24 => 131
	i32 545304856, ; 46: System.Runtime.Extensions => 0x2080b118 => 4
	i32 605376203, ; 47: System.IO.Compression.FileSystem => 0x24154ecb => 145
	i32 627609679, ; 48: Xamarin.AndroidX.CustomView => 0x2568904f => 66
	i32 631472481, ; 49: Cinema.Android.dll => 0x25a38161 => 0
	i32 663517072, ; 50: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 104
	i32 666292255, ; 51: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 54
	i32 690569205, ; 52: System.Xml.Linq.dll => 0x29293ff5 => 48
	i32 700284507, ; 53: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 134
	i32 715243097, ; 54: Syncfusion.SfTabView.XForms.Android.dll => 0x2aa1be59 => 39
	i32 719061231, ; 55: Syncfusion.Core.XForms.dll => 0x2adc00ef => 30
	i32 720511267, ; 56: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 138
	i32 775507847, ; 57: System.IO.Compression => 0x2e394f87 => 144
	i32 809851609, ; 58: System.Drawing.Common.dll => 0x30455ad9 => 8
	i32 836755697, ; 59: Xamarin.AndroidX.Lifecycle.Service => 0x31dfe0f1 => 79
	i32 843511501, ; 60: Xamarin.AndroidX.Print => 0x3246f6cd => 90
	i32 846667644, ; 61: Xamarin.Firebase.Installations.dll => 0x32771f7c => 114
	i32 864956750, ; 62: Syncfusion.SfMaskedEdit.XForms => 0x338e314e => 35
	i32 877678880, ; 63: System.Globalization.dll => 0x34505120 => 7
	i32 882434999, ; 64: Xamarin.Firebase.Installations.InterOp.dll => 0x3498e3b7 => 115
	i32 902159924, ; 65: Rg.Plugins.Popup => 0x35c5de34 => 26
	i32 928116545, ; 66: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 128
	i32 946305544, ; 67: Syncfusion.SfTabView.XForms.Android => 0x38677a08 => 39
	i32 955402788, ; 68: Newtonsoft.Json => 0x38f24a24 => 20
	i32 956575887, ; 69: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 138
	i32 967690846, ; 70: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 75
	i32 974778368, ; 71: FormsViewGroup.dll => 0x3a19f000 => 15
	i32 992768348, ; 72: System.Collections.dll => 0x3b2c715c => 3
	i32 996733531, ; 73: Xamarin.Google.Android.DataTransport.TransportBackendCct => 0x3b68f25b => 124
	i32 1012816738, ; 74: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 94
	i32 1035644815, ; 75: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 53
	i32 1036359102, ; 76: Xamarin.GooglePlayServices.CloudMessaging.dll => 0x3dc595be => 130
	i32 1042160112, ; 77: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 121
	i32 1052210849, ; 78: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 80
	i32 1084122840, ; 79: Xamarin.Kotlin.StdLib => 0x409e66d8 => 136
	i32 1098259244, ; 80: System => 0x41761b2c => 42
	i32 1141947663, ; 81: Xamarin.Firebase.Measurement.Connector.dll => 0x4410bd0f => 116
	i32 1175144683, ; 82: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 102
	i32 1178241025, ; 83: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 87
	i32 1204270330, ; 84: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 54
	i32 1264511973, ; 85: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 98
	i32 1267360935, ; 86: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 103
	i32 1293217323, ; 87: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 68
	i32 1324164729, ; 88: System.Linq => 0x4eed2679 => 154
	i32 1333047053, ; 89: Xamarin.Firebase.Common => 0x4f74af0d => 110
	i32 1364015309, ; 90: System.IO => 0x514d38cd => 149
	i32 1365406463, ; 91: System.ServiceModel.Internals.dll => 0x516272ff => 139
	i32 1376866003, ; 92: Xamarin.AndroidX.SavedState => 0x52114ed3 => 94
	i32 1379779777, ; 93: System.Resources.ResourceManager => 0x523dc4c1 => 1
	i32 1379897097, ; 94: Xamarin.JavaX.Inject => 0x523f8f09 => 133
	i32 1395857551, ; 95: Xamarin.AndroidX.Media.dll => 0x5333188f => 84
	i32 1406073936, ; 96: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 63
	i32 1457743152, ; 97: System.Runtime.Extensions.dll => 0x56e36530 => 4
	i32 1458393339, ; 98: Syncfusion.SfRotator.XForms.Android.dll => 0x56ed50fb => 37
	i32 1460219004, ; 99: Xamarin.Forms.Xaml => 0x57092c7c => 122
	i32 1462112819, ; 100: System.IO.Compression.dll => 0x57261233 => 144
	i32 1469204771, ; 101: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 52
	i32 1489278563, ; 102: Syncfusion.SfAutoComplete.XForms.dll => 0x58c49663 => 33
	i32 1516315406, ; 103: Syncfusion.Core.XForms.Android.dll => 0x5a61230e => 29
	i32 1530772511, ; 104: FFImageLoading.Forms.Platform => 0x5b3dbc1f => 13
	i32 1531040989, ; 105: Xamarin.Firebase.Iid.Interop.dll => 0x5b41d4dd => 113
	i32 1543031311, ; 106: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 153
	i32 1550322496, ; 107: System.Reflection.Extensions.dll => 0x5c680b40 => 5
	i32 1582372066, ; 108: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 67
	i32 1592978981, ; 109: System.Runtime.Serialization.dll => 0x5ef2ee25 => 9
	i32 1622152042, ; 110: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 82
	i32 1624863272, ; 111: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 106
	i32 1634619362, ; 112: Xamarin.AndroidX.Room.Common => 0x616e4fe2 => 92
	i32 1636350590, ; 113: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 65
	i32 1639515021, ; 114: System.Net.Http.dll => 0x61b9038d => 43
	i32 1639986890, ; 115: System.Text.RegularExpressions => 0x61c036ca => 153
	i32 1657153582, ; 116: System.Runtime => 0x62c6282e => 46
	i32 1658241508, ; 117: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 100
	i32 1658251792, ; 118: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 126
	i32 1670060433, ; 119: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 62
	i32 1677501392, ; 120: System.Net.Primitives.dll => 0x63fca3d0 => 151
	i32 1698840827, ; 121: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 135
	i32 1701541528, ; 122: System.Diagnostics.Debug.dll => 0x656b7698 => 150
	i32 1726116996, ; 123: System.Reflection.dll => 0x66e27484 => 2
	i32 1729485958, ; 124: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 58
	i32 1736948048, ; 125: Xamarin.AndroidX.Sqlite.dll => 0x6787b950 => 96
	i32 1758026047, ; 126: Xamarin.AndroidX.Room.Runtime.dll => 0x68c9593f => 93
	i32 1765942094, ; 127: System.Reflection.Extensions => 0x6942234e => 5
	i32 1766324549, ; 128: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 99
	i32 1776026572, ; 129: System.Core.dll => 0x69dc03cc => 41
	i32 1788241197, ; 130: Xamarin.AndroidX.Fragment => 0x6a96652d => 70
	i32 1793089559, ; 131: FFImageLoading.Forms.dll => 0x6ae06017 => 12
	i32 1796983048, ; 132: Syncfusion.SfTabView.XForms.dll => 0x6b1bc908 => 40
	i32 1808609942, ; 133: Xamarin.AndroidX.Loader => 0x6bcd3296 => 82
	i32 1813058853, ; 134: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 136
	i32 1813201214, ; 135: Xamarin.Google.Android.Material => 0x6c13413e => 126
	i32 1818569960, ; 136: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 88
	i32 1840964413, ; 137: FFImageLoading.Forms => 0x6dbae33d => 12
	i32 1867746548, ; 138: Xamarin.Essentials.dll => 0x6f538cf4 => 108
	i32 1878053835, ; 139: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 122
	i32 1885316902, ; 140: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 55
	i32 1900610850, ; 141: System.Resources.ResourceManager.dll => 0x71490522 => 1
	i32 1908813208, ; 142: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 129
	i32 1919157823, ; 143: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 85
	i32 1933215285, ; 144: Xamarin.Firebase.Messaging.dll => 0x733a8635 => 117
	i32 1983156543, ; 145: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 135
	i32 2019465201, ; 146: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 80
	i32 2055257422, ; 147: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 76
	i32 2071563619, ; 148: Syncfusion.Buttons.XForms.Android => 0x7b798d63 => 27
	i32 2079903147, ; 149: System.Runtime.dll => 0x7bf8cdab => 46
	i32 2090596640, ; 150: System.Numerics.Vectors => 0x7c9bf920 => 45
	i32 2094676648, ; 151: Syncfusion.SfRotator.XForms.dll => 0x7cda3aa8 => 38
	i32 2097448633, ; 152: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 72
	i32 2113902067, ; 153: Xamarin.Forms.PancakeView.dll => 0x7dff95f3 => 119
	i32 2124230737, ; 154: Xamarin.Google.Android.DataTransport.TransportBackendCct.dll => 0x7e9d3051 => 124
	i32 2126786730, ; 155: Xamarin.Forms.Platform.Android => 0x7ec430aa => 120
	i32 2174878672, ; 156: Xamarin.Firebase.Annotations => 0x81a203d0 => 109
	i32 2192674484, ; 157: Syncfusion.SfMaskedEdit.XForms.dll => 0x82b18eb4 => 35
	i32 2193016926, ; 158: System.ObjectModel.dll => 0x82b6c85e => 155
	i32 2201231467, ; 159: System.Net.Http => 0x8334206b => 43
	i32 2217644978, ; 160: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 102
	i32 2244775296, ; 161: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 83
	i32 2256548716, ; 162: Xamarin.AndroidX.MultiDex => 0x8680336c => 85
	i32 2261435625, ; 163: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 74
	i32 2279703579, ; 164: Xamarin.AndroidX.Sqlite.Framework.dll => 0x87e1841b => 97
	i32 2279755925, ; 165: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 91
	i32 2315684594, ; 166: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 50
	i32 2340826669, ; 167: FFImageLoading.dll => 0x8b862e2d => 11
	i32 2343171156, ; 168: Syncfusion.Core.XForms => 0x8ba9f454 => 30
	i32 2353062107, ; 169: System.Net.Primitives => 0x8c40e0db => 151
	i32 2354730003, ; 170: Syncfusion.Licensing => 0x8c5a5413 => 31
	i32 2397082276, ; 171: Xamarin.Forms.PancakeView => 0x8ee092a4 => 119
	i32 2409053734, ; 172: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 89
	i32 2454642406, ; 173: System.Text.Encoding.dll => 0x924edee6 => 6
	i32 2460200098, ; 174: OneSignalSDK.Xamarin.Core => 0x92a3aca2 => 22
	i32 2465532216, ; 175: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 61
	i32 2471215200, ; 176: ImageCircle.Forms.Plugin => 0x934bc060 => 16
	i32 2471841756, ; 177: netstandard.dll => 0x93554fdc => 140
	i32 2475788418, ; 178: Java.Interop.dll => 0x93918882 => 17
	i32 2483661569, ; 179: Xamarin.Firebase.Measurement.Connector => 0x9409ab01 => 116
	i32 2483742551, ; 180: Xamarin.Firebase.Messaging => 0x940ae757 => 117
	i32 2486410006, ; 181: Xamarin.GooglePlayServices.CloudMessaging => 0x94339b16 => 130
	i32 2501346920, ; 182: System.Data.DataSetExtensions => 0x95178668 => 143
	i32 2505896520, ; 183: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 78
	i32 2581819634, ; 184: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 103
	i32 2593964533, ; 185: Xamarin.Google.Dagger => 0x9a9cc1f5 => 127
	i32 2620871830, ; 186: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 65
	i32 2623491480, ; 187: Xamarin.Firebase.Installations.InterOp => 0x9c5f4d98 => 115
	i32 2624644809, ; 188: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 69
	i32 2633051222, ; 189: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 77
	i32 2635217119, ; 190: Syncfusion.SfAutoComplete.XForms.Android => 0x9d1238df => 32
	i32 2635300604, ; 191: Syncfusion.Buttons.XForms => 0x9d137efc => 28
	i32 2647358571, ; 192: Syncfusion.SfAutoComplete.XForms.Android.dll => 0x9dcb7c6b => 32
	i32 2649652215, ; 193: Cinema.Android => 0x9dee7bf7 => 0
	i32 2693849962, ; 194: System.IO.dll => 0xa090e36a => 149
	i32 2701096212, ; 195: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 100
	i32 2715334215, ; 196: System.Threading.Tasks.dll => 0xa1d8b647 => 148
	i32 2732626843, ; 197: Xamarin.AndroidX.Activity => 0xa2e0939b => 49
	i32 2737747696, ; 198: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 52
	i32 2739926663, ; 199: Xamarin.AndroidX.Sqlite.Framework => 0xa34ff687 => 97
	i32 2766581644, ; 200: Xamarin.Forms.Core => 0xa4e6af8c => 118
	i32 2770495804, ; 201: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 134
	i32 2772412848, ; 202: Xamarin.Google.Dagger.dll => 0xa53fa9b0 => 127
	i32 2778768386, ; 203: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 105
	i32 2804607052, ; 204: Xamarin.Firebase.Components.dll => 0xa72ae84c => 111
	i32 2810250172, ; 205: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 63
	i32 2819470561, ; 206: System.Xml.dll => 0xa80db4e1 => 47
	i32 2842369275, ; 207: FFImageLoading.Forms.Platform.dll => 0xa96b1cfb => 13
	i32 2853208004, ; 208: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 105
	i32 2855708567, ; 209: Xamarin.AndroidX.Transition => 0xaa36a797 => 101
	i32 2861816565, ; 210: Rg.Plugins.Popup.dll => 0xaa93daf5 => 26
	i32 2868557005, ; 211: Syncfusion.Licensing.dll => 0xaafab4cd => 31
	i32 2873222696, ; 212: FFImageLoading => 0xab41e628 => 11
	i32 2874148507, ; 213: Syncfusion.Core.XForms.Android => 0xab50069b => 29
	i32 2883826422, ; 214: Xamarin.Firebase.Installations => 0xabe3b2f6 => 114
	i32 2885205685, ; 215: Syncfusion.SfTabView.XForms => 0xabf8beb5 => 40
	i32 2901442782, ; 216: System.Reflection => 0xacf080de => 2
	i32 2903344695, ; 217: System.ComponentModel.Composition => 0xad0d8637 => 146
	i32 2905242038, ; 218: mscorlib.dll => 0xad2a79b6 => 19
	i32 2914202368, ; 219: Xamarin.Firebase.Iid.Interop => 0xadb33300 => 113
	i32 2916838712, ; 220: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 106
	i32 2919462931, ; 221: System.Numerics.Vectors.dll => 0xae037813 => 45
	i32 2921128767, ; 222: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 51
	i32 2953735189, ; 223: Xamarin.AndroidX.Lifecycle.Service.dll => 0xb00e6c15 => 79
	i32 2978675010, ; 224: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 68
	i32 3016983068, ; 225: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 98
	i32 3017678341, ; 226: Syncfusion.SfMaskedEdit.XForms.Android => 0xb3de1e05 => 34
	i32 3024354802, ; 227: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 73
	i32 3044182254, ; 228: FormsViewGroup => 0xb57288ee => 15
	i32 3057625584, ; 229: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 86
	i32 3058099980, ; 230: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 132
	i32 3071899978, ; 231: Xamarin.Firebase.Common.dll => 0xb719794a => 110
	i32 3075834255, ; 232: System.Threading.Tasks => 0xb755818f => 148
	i32 3079937701, ; 233: PanCardView.dll => 0xb7941ea5 => 24
	i32 3101692150, ; 234: Cinema => 0xb8e010f6 => 10
	i32 3106737866, ; 235: Xamarin.Firebase.Datatransport.dll => 0xb92d0eca => 112
	i32 3108538180, ; 236: PanCardView.Droid => 0xb9488744 => 25
	i32 3111772706, ; 237: System.Runtime.Serialization => 0xb979e222 => 9
	i32 3144132135, ; 238: Xamarin.AndroidX.Sqlite => 0xbb67a627 => 96
	i32 3149941735, ; 239: Syncfusion.SfRotator.Android => 0xbbc04be7 => 36
	i32 3155362983, ; 240: Xamarin.Google.Android.DataTransport.TransportApi => 0xbc1304a7 => 123
	i32 3204380047, ; 241: System.Data.dll => 0xbefef58f => 141
	i32 3211777861, ; 242: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 67
	i32 3220365878, ; 243: System.Threading => 0xbff2e236 => 152
	i32 3230466174, ; 244: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 129
	i32 3247949154, ; 245: Mono.Security => 0xc197c562 => 156
	i32 3258312781, ; 246: Xamarin.AndroidX.CardView => 0xc235e84d => 58
	i32 3258802011, ; 247: OneSignal.Android.Binding.dll => 0xc23d5f5b => 21
	i32 3267021929, ; 248: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 56
	i32 3299363146, ; 249: System.Text.Encoding => 0xc4a8494a => 6
	i32 3317135071, ; 250: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 66
	i32 3317144872, ; 251: System.Data => 0xc5b79d28 => 141
	i32 3331531814, ; 252: Xamarin.GooglePlayServices.Stats.dll => 0xc6932426 => 131
	i32 3340431453, ; 253: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 55
	i32 3346324047, ; 254: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 87
	i32 3353484488, ; 255: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 72
	i32 3362522851, ; 256: Xamarin.AndroidX.Core => 0xc86c06e3 => 64
	i32 3366347497, ; 257: Java.Interop => 0xc8a662e9 => 17
	i32 3374999561, ; 258: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 91
	i32 3404865022, ; 259: System.ServiceModel.Internals => 0xcaf21dfe => 139
	i32 3429136800, ; 260: System.Xml => 0xcc6479a0 => 47
	i32 3430777524, ; 261: netstandard => 0xcc7d82b4 => 140
	i32 3434749838, ; 262: Syncfusion.Buttons.XForms.Android.dll => 0xccba1f8e => 27
	i32 3441283291, ; 263: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 69
	i32 3476120550, ; 264: Mono.Android => 0xcf3163e6 => 18
	i32 3483112796, ; 265: ImageCircle.Forms.Plugin.dll => 0xcf9c155c => 16
	i32 3486566296, ; 266: System.Transactions => 0xcfd0c798 => 142
	i32 3493954962, ; 267: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 60
	i32 3501239056, ; 268: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 56
	i32 3509114376, ; 269: System.Xml.Linq => 0xd128d608 => 48
	i32 3536029504, ; 270: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 120
	i32 3544827059, ; 271: OneSignalSDK.Xamarin.dll => 0xd349c4b3 => 23
	i32 3567349600, ; 272: System.ComponentModel.Composition.dll => 0xd4a16f60 => 146
	i32 3608519521, ; 273: System.Linq.dll => 0xd715a361 => 154
	i32 3612947231, ; 274: Xamarin.AndroidX.Work.Runtime => 0xd759331f => 107
	i32 3618140916, ; 275: Xamarin.AndroidX.Preference => 0xd7a872f4 => 89
	i32 3623276856, ; 276: PanCardView.Droid.dll => 0xd7f6d138 => 25
	i32 3627220390, ; 277: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 90
	i32 3632359727, ; 278: Xamarin.Forms.Platform => 0xd881692f => 121
	i32 3633644679, ; 279: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 51
	i32 3641597786, ; 280: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 76
	i32 3672681054, ; 281: Mono.Android.dll => 0xdae8aa5e => 18
	i32 3676310014, ; 282: System.Web.Services.dll => 0xdb2009fe => 147
	i32 3682565725, ; 283: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 57
	i32 3684561358, ; 284: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 60
	i32 3689375977, ; 285: System.Drawing.Common => 0xdbe768e9 => 8
	i32 3718780102, ; 286: Xamarin.AndroidX.Annotation => 0xdda814c6 => 50
	i32 3724971120, ; 287: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 86
	i32 3735092365, ; 288: Xamarin.AndroidX.Room.Common.dll => 0xdea0fc8d => 92
	i32 3758932259, ; 289: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 74
	i32 3786282454, ; 290: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 59
	i32 3822602673, ; 291: Xamarin.AndroidX.Media => 0xe3d849b1 => 84
	i32 3829621856, ; 292: System.Numerics.dll => 0xe4436460 => 44
	i32 3885922214, ; 293: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 101
	i32 3896760992, ; 294: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 64
	i32 3920810846, ; 295: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 145
	i32 3921031405, ; 296: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 104
	i32 3931092270, ; 297: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 88
	i32 3934056515, ; 298: Xamarin.JavaX.Inject.dll => 0xea7cf043 => 133
	i32 3945713374, ; 299: System.Data.DataSetExtensions.dll => 0xeb2ecede => 143
	i32 3955647286, ; 300: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 53
	i32 3970018735, ; 301: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 132
	i32 4073602200, ; 302: System.Threading.dll => 0xf2ce3c98 => 152
	i32 4105002889, ; 303: Mono.Security.dll => 0xf4ad5f89 => 156
	i32 4108064750, ; 304: Syncfusion.SfRotator.XForms => 0xf4dc17ee => 38
	i32 4137181845, ; 305: Xamarin.AndroidX.Room.Runtime => 0xf6986295 => 93
	i32 4151237749, ; 306: System.Core => 0xf76edc75 => 41
	i32 4182413190, ; 307: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 81
	i32 4184283386, ; 308: FFImageLoading.Platform.dll => 0xf96718fa => 14
	i32 4233681054, ; 309: OneSignalSDK.Xamarin => 0xfc58d89e => 23
	i32 4269159614, ; 310: Xamarin.Firebase.Datatransport => 0xfe7634be => 112
	i32 4282755629, ; 311: Cinema.dll => 0xff45aa2d => 10
	i32 4284549794, ; 312: Xamarin.Firebase.Components => 0xff610aa2 => 111
	i32 4292120959 ; 313: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 81
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [314 x i32] [
	i32 78, i32 128, i32 20, i32 118, i32 34, i32 37, i32 28, i32 95, ; 0..7
	i32 109, i32 95, i32 137, i32 59, i32 99, i32 57, i32 150, i32 73, ; 8..15
	i32 7, i32 147, i32 62, i32 21, i32 77, i32 71, i32 107, i32 49, ; 16..23
	i32 44, i32 22, i32 75, i32 33, i32 36, i32 61, i32 108, i32 3, ; 24..31
	i32 70, i32 19, i32 42, i32 71, i32 24, i32 125, i32 83, i32 125, ; 32..39
	i32 155, i32 123, i32 14, i32 142, i32 137, i32 131, i32 4, i32 145, ; 40..47
	i32 66, i32 0, i32 104, i32 54, i32 48, i32 134, i32 39, i32 30, ; 48..55
	i32 138, i32 144, i32 8, i32 79, i32 90, i32 114, i32 35, i32 7, ; 56..63
	i32 115, i32 26, i32 128, i32 39, i32 20, i32 138, i32 75, i32 15, ; 64..71
	i32 3, i32 124, i32 94, i32 53, i32 130, i32 121, i32 80, i32 136, ; 72..79
	i32 42, i32 116, i32 102, i32 87, i32 54, i32 98, i32 103, i32 68, ; 80..87
	i32 154, i32 110, i32 149, i32 139, i32 94, i32 1, i32 133, i32 84, ; 88..95
	i32 63, i32 4, i32 37, i32 122, i32 144, i32 52, i32 33, i32 29, ; 96..103
	i32 13, i32 113, i32 153, i32 5, i32 67, i32 9, i32 82, i32 106, ; 104..111
	i32 92, i32 65, i32 43, i32 153, i32 46, i32 100, i32 126, i32 62, ; 112..119
	i32 151, i32 135, i32 150, i32 2, i32 58, i32 96, i32 93, i32 5, ; 120..127
	i32 99, i32 41, i32 70, i32 12, i32 40, i32 82, i32 136, i32 126, ; 128..135
	i32 88, i32 12, i32 108, i32 122, i32 55, i32 1, i32 129, i32 85, ; 136..143
	i32 117, i32 135, i32 80, i32 76, i32 27, i32 46, i32 45, i32 38, ; 144..151
	i32 72, i32 119, i32 124, i32 120, i32 109, i32 35, i32 155, i32 43, ; 152..159
	i32 102, i32 83, i32 85, i32 74, i32 97, i32 91, i32 50, i32 11, ; 160..167
	i32 30, i32 151, i32 31, i32 119, i32 89, i32 6, i32 22, i32 61, ; 168..175
	i32 16, i32 140, i32 17, i32 116, i32 117, i32 130, i32 143, i32 78, ; 176..183
	i32 103, i32 127, i32 65, i32 115, i32 69, i32 77, i32 32, i32 28, ; 184..191
	i32 32, i32 0, i32 149, i32 100, i32 148, i32 49, i32 52, i32 97, ; 192..199
	i32 118, i32 134, i32 127, i32 105, i32 111, i32 63, i32 47, i32 13, ; 200..207
	i32 105, i32 101, i32 26, i32 31, i32 11, i32 29, i32 114, i32 40, ; 208..215
	i32 2, i32 146, i32 19, i32 113, i32 106, i32 45, i32 51, i32 79, ; 216..223
	i32 68, i32 98, i32 34, i32 73, i32 15, i32 86, i32 132, i32 110, ; 224..231
	i32 148, i32 24, i32 10, i32 112, i32 25, i32 9, i32 96, i32 36, ; 232..239
	i32 123, i32 141, i32 67, i32 152, i32 129, i32 156, i32 58, i32 21, ; 240..247
	i32 56, i32 6, i32 66, i32 141, i32 131, i32 55, i32 87, i32 72, ; 248..255
	i32 64, i32 17, i32 91, i32 139, i32 47, i32 140, i32 27, i32 69, ; 256..263
	i32 18, i32 16, i32 142, i32 60, i32 56, i32 48, i32 120, i32 23, ; 264..271
	i32 146, i32 154, i32 107, i32 89, i32 25, i32 90, i32 121, i32 51, ; 272..279
	i32 76, i32 18, i32 147, i32 57, i32 60, i32 8, i32 50, i32 86, ; 280..287
	i32 92, i32 74, i32 59, i32 84, i32 44, i32 101, i32 64, i32 145, ; 288..295
	i32 104, i32 88, i32 133, i32 143, i32 53, i32 132, i32 152, i32 156, ; 296..303
	i32 38, i32 93, i32 41, i32 81, i32 14, i32 23, i32 112, i32 10, ; 304..311
	i32 111, i32 81 ; 312..313
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ a200af12c1e846626b8caebd926ac14c185f71ec"}
!llvm.linker.options = !{}
