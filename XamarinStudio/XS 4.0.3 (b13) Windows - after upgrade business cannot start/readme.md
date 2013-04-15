# XS 4 Windows cannot start #

## Environment ##

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

## Problem ##

1.	paid licences
2. 	download XamarinInstaller  
3.	Install OK, no errors
4. 	Unable to start XS
3.  XS log from:    
	"%USERPROFILE%\AppData\Local\XamarinStudio-4.0\Logs\"   
	[./Ide.2013-04-13__21-06-06.log](./Ide.2013-04-13__21-06-06.log)
		
	FATAL ERROR [2013-04-13 21:06:23Z]: Xamarin Studio failed to start. Some of the assemblies required to run Xamarin Studio (for example gtk-sharp)may not be properly installed in the GAC.
	System.IO.FileNotFoundException: Could not load file or assembly 'glib-sharp, Version=2.12.0.0, Culture=neutral, PublicKeyToken=35e10195dab3c99f' or one of its dependencies. The system cannot find the file specified.
	File name: 'glib-sharp, Version=2.12.0.0, Culture=neutral, PublicKeyToken=35e10195dab3c99f'
	   at MonoDevelop.Ide.IdeStartup.Run(MonoDevelopOptions options)
	   at MonoDevelop.Ide.IdeStartup.Main(String[] args)

	WRN: Assembly binding logging is turned OFF.
	To enable assembly bind failure logging, set the registry value [HKLM\Software\Microsoft\Fusion!EnableLog] (DWORD) to 1.
	Note: There is some performance penalty associated with assembly bind failure logging.
	To turn this feature off, remove the registry value [HKLM\Software\Microsoft\Fusion!EnableLog].
		
4.	XS installation log from:   
	explorer "%USERPROFILE%\AppData\Local\Xamarin\Universal"   
	[InstallLog.635013526717301586.txt](InstallLog.635013526717301586.txt)  
	
	[2013-04-12 06:37:54.839] [Debug] Detecting software item 'GTK#'
	[2013-04-12 06:37:54.842] [Info] Checking whether GTK# needs installation/updating
	[2013-04-12 06:37:54.846] [Debug] Attempting to read registry subkey 'SOFTWARE\Wow6432Node\Novell\GtkSharp\Version', value ''
	[2013-04-12 06:37:54.849] [Debug] Attempting to read registry subkey 'SOFTWARE\Novell\GtkSharp\Version', value ''
	[2013-04-12 06:37:54.853] [Debug] Attempting to read registry subkey 'SOFTWARE\Wow6432Node\Xamarin\GtkSharp\Version', value ''
	[2013-04-12 06:37:54.856] [Debug] Attempting to read registry subkey 'SOFTWARE\Xamarin\GtkSharp\Version', value ''
	[2013-04-12 06:37:54.861] [Debug] Attempting to read registry subkey 'SOFTWARE\Wow6432Node\Xamarin\GtkSharp\InstallFolder', value ''
	[2013-04-12 06:37:54.866] [Debug] Attempting to read registry subkey 'SOFTWARE\Xamarin\GtkSharp\InstallFolder', value ''
	[2013-04-12 06:37:54.870] [Info] Previous GTK# is older.
	[2013-04-12 06:37:54.874] [Info] GTK# 2.12.20 needs to be installed.
	[2013-04-12 06:37:54.878] [Info] Status: successful
	[2013-04-12 06:37:54.882] [Info] Software item 'GTK#': not up to date
	[2013-04-12 06:37:54.887] [Info] Component 'GTK#' v. 2.12.19 present but requires update to v. 2.12.20

	
	
## Solution ##

1.	download installer for ghtsharp 2.12.20
2.	reinstall/repair  
	I was asked to repair!!
