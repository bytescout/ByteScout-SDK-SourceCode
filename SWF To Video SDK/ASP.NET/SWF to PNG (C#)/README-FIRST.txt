Interact with desktop permission may be required to run Screen Capturing SDK or SWF To Video SDK from service or to convert interactive ("live") flash movies with SWF To Video SDK

You may set this "Allow to interact with desktop" checkbox for the user that is used to run the service/app 
For IIS asp.net apps this user name is typically IIS_... user name

Important note for Windows Server 2008 or later

Newest Windows has disabled interactive services 

New Windows versions are no longer allowing to run interactive services by default to prevent services from accessing the desktop (to provide more security)

If you must run a Screen Capturing SDK or SWF To Video SDK from an interactive service then you may sacrifice server stability for compatibility by changing the following registry value from the default of "1" to "0".

HKLM\SYSTEM\CurrentControlSet\Control\Windows 
NoInteractiveServices

Then reboot so Windows will pick the new value from the registry and the Interactive Services Detection Service will start.

To make this change manually please do the following 

Start the registry editor (regedit.exe) in As Administrator mode
Locate the following Registry key: HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Windows on the left side
double-click the NoInteractiveServices entry on the right side and change its value from 1 to 0
Then click OK and close the registry editor
Restart the computer