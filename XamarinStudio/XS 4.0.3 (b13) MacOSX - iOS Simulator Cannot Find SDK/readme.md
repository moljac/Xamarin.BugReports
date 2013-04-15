# XS 4.0.3 (b13) MacOSX - iOS Simulator Cannot Find SDK #

## Environment ##

Xamarin Studio
Version 4.0.3 (build 13)
Installation UUID: 5b505d87-0c37-46e6-9287-fc026b1a0db0
Runtime:
	Mono 3.0.8 (master/2edeeb6)
	GTK 2.24.18
	GTK# (2.12.0.0)
	Package version: 300080000

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


    

## Problem ##

1. Start debugging MonoTouch project
2. error iOS Simulator cannot find SDK
   [Screen Shot 2013-04-09 at 1.16.48 PM.png](Screen Shot 2013-04-09 at 1.16.48 PM.png)
   
## Solution ##

1. delete folders in MonoTouch app  
	1. obj/   
	2. bin/   