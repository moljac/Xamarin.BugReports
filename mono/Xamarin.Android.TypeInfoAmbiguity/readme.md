# System.Reflection.TypeInfo and Custom.TypeInfo ambiguous in Xamarin.Android #

During porting of SharpSerializer type ambiguity compile error detected in Xamarin.Android
project.

Xamarin.iOS, WinForms and other compile OK. 


Seems that underlying mono is different from Xamarin.iOS.

There is bug in bugzilla something like: "mono allows access to non public types....".

There is no System.Reflection.TypeInfo in the docs for both Android and iOS:

*	[http://androidapi.xamarin.com/?link=N%3aSystem.Reflection](http://androidapi.xamarin.com/?link=N%3aSystem.Reflection)
*	[http://iosapi.xamarin.com/?link=N%3aSystem.Reflection](http://iosapi.xamarin.com/?link=N%3aSystem.Reflection)

Found in:

	Assembly mscorlib
		C:\Program Files\Reference Assemblies\Microsoft\Framework\MonoAndroid\v1.0\mscorlib.dll



## Environment ##

### Visual Studio 2010 ###

Error:

	Error	1	
	'TypeInfo' is an ambiguous reference between 'SomeNamespace.TypeInfo' and 'System.Reflection.TypeInfo'	
	git[github.com]\Xamarin.BugReports\mono\Xamarin.Android.TypeInfoAmbiguity\TypeInfoAmbiguity.Android\TypeInfoConsumer.cs	14	17	
	TypeInfoAmbiguity.Android

System:

	Xamarin.Android 4.7.02 

### Xamarin Studio ###


#### Windows ####

Error:

	git[github.com]\Xamarin.BugReports\mono\Xamarin.Android.TypeInfoAmbiguity\TypeInfoAmbiguity.Android\TypeInfoConsumer.cs(17,17): 
	Error CS0104: 'TypeInfo' is an ambiguous reference between 'SomeNamespace.TypeInfo' and 'System.Reflection.TypeInfo' (CS0104) 
	(TypeInfoAmbiguity.Android)

System:

	Xamarin Studio
	Version 4.0.3 (build 13)
	Installation UUID: 44e4f747-b02b-430b-bd63-3e33a4f2653c
	Runtime:
		Microsoft .NET 4.0.30319.18034
		GTK 2.24.13
		GTK# (2.12.0.0)

	Xamarin.Android
	Version: 4.7.2 (Business Edition)
	Android SDK: C:\Program Files\Android\android-sdk
		Supported Android versions:
			1.6   (API level 4)
			2.1   (API level 7)
			2.2   (API level 8)
			2.3   (API level 10)
			3.1   (API level 12)
			3.2   (API level 13)
			4.0   (API level 14)
			4.0.3 (API level 15)
			4.1   (API level 16)
			4.2   (API level 17)
	Java SDK: C:\Program Files\Java\jdk1.6.0_39

	Build Information
	Release ID: 400030013
	fae7c2bde0e8d51943fbd6afa22d7d2bb7a1192f
	Build date: 2013-03-21 15:53:00Z
	Xamarin addins: 906a1edff23bcfd0ab7518463620a8ee506eaea2

	Operating System
	Windows 6.0.6002.131072


#### MacOSX ####
