# System.Reflection.TypeInfo and Custom.TypeInfo ambiguous in Xamarin.Android #

During porting of SharpSerializer type ambiguity compile error detected **only**
in Xamarin.Android project in Visual Studio and Xamarin Studio 
when  runtime (default) is .net.

	using System.Reflection;
	using Custom;
	
	void f(TypeInfo ti)
	
	
Compile Error:

* 	Xamarin.Android (XS Windows, default runtime .net)
* 	Xamarin.Android (VS Windows)

Compile OK:

* 	Xamarin.Android (MacOSX)
*   

Mono rutime (MacOSX), no errors.

Xamarin.iOS, WinForms and other compile OK. 


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

Error:

	None

System:


	Xamarin Studio
	Version 4.0.3 (build 13)
	Installation UUID: 5b505d87-0c37-46e6-9287-fc026b1a0db0
	Runtime:
		Mono 2.10.11 (mono-2-10/2baeee2)
		GTK 2.24.14
		GTK# (2.12.0.0)
		Package version: 210110000
	
	Apple Developer Tools
	Xcode 4.6.1 (2067)
	Build 4H512
	
	Xamarin.iOS
	Version: 6.2.1.201 (Business Edition)
	Hash: ed9807c
	Branch: 
	Build date: 2013-19-03 13:42:59-0400
	
	Xamarin.Mac
	Xamarin.Mac: Not Installed
	
	Xamarin.Android
	Version: 4.6.2 (Starter Edition)
	Android SDK: /Users/mc/Library/Developer/Xamarin/android-sdk-mac_x86
		Supported Android versions:
			2.1 (API level 7)
			2.2 (API level 8)
			2.3 (API level 10)
			3.1 (API level 12)
			4.0 (API level 14)
	Java SDK: /usr
	
	Build Information
	Release ID: 400030013
	Git revision: fae7c2bde0e8d51943fbd6afa22d7d2bb7a1192f
	Build date: 2013-03-21 19:16:39+0000
	Xamarin addins: 906a1edff23bcfd0ab7518463620a8ee506eaea2
	
	Operating System
	Mac OS X 10.8.3
	Darwin Miljenkos-MacBook-Pro.local 12.3.0 Darwin Kernel Version 12.3.0
	    Sun Jan  6 22:37:10 PST 2013
	    root:xnu-2050.22.13~1/RELEASE_X86_64 x86_64


