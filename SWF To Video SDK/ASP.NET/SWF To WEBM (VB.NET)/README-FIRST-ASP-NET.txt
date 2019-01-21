To use SWF To Video SDK on Web Server you may need to do the following adjustments to the server.

Confirmed: SDK works on virtual Windows 2003, 2008, 2012 servers with these adjustments.

1) Windows Server 2003 or later: 
If you are using WMV format then install Windows Media Player from "Desktop Experience"

2) Update flash player for Internet Explorer to the latest version. To update do the following
 - run Internet Explorer
 - open adobe.com
 - click on Update Flash Player
 - follow the instruction and install the latest flash player plugin for Internet Explorer
 
NOTE: on x64 Windows you should run Internet Explorer for x86 (not x64 version)

3) To convert interactive flash movies you should enable "allow interact with desktop" option

IMPORTANT: this may cause security breaches so pleaase be careful!

Recommended way:
- create new IIS user 
- use it to run web application to convert swf to video only
- set it to x86 mode only
- set it to "allow desktop interaction"

4) For Windows 2008, 2012 or later: 

If you are on Windows Server 2008 or higher and you have set "allow desktop interaction" already but still having the issue please try the following solution as suggested by Microsoft specialists:

Windows Server 2008, 2012 no longer allows interactive services, by default, which makes the Interactive Services Detection service unnecessary.
http://social.technet.microsoft.com/Forums/en-US/winserver8gen/thread/6fb5693a-a256-41f7-a1df-d30101d9f8b6

if you must run a the application that installs an interactive service on Windows Server 2012, you may sacrifice server stability for compatibility by changing the following registry value from the default of "1" into "0":
"NoInteractiveServices" in "HKLM\SYSTEM\CurrentControlSet\Control\Windows"

After doing so and rebooting, the Interactive Services Detection Service will start.

5) for x64 windows: you should set IIS to run your web application in x86 mode
6) for x64 Windows: you should compile your ASP.NET web application for x86 platform instead of AnyCPU


POSSIBLE ISSUES:
1) Flash movie with dynamic XML data shows "Can not load XML data". 
Solution: To check this issue try to run Internet Explorer on the server machine and open that flash movie (or URL to flash movie in Internet Explorer)

2) if you suspect the issue is caused by flash movie not properly running you may need to run it in Flash Player Debug version 
Solution: You should download "Windows Flash Player 11.7 ActiveX control content debugger (for IE)" from this page
http://www.adobe.com/support/flashplayer/downloads.html
Install, follow the instruction and try to open that flash movie in Internet Explorer again and flash player will display debug error messages from flash if needed

3) If your flash movie is designed to run on machines with sound card then you may experience issues related to the lack of audio devices.
Solution: if you are able to recompile flash movie then add the additional check for sound devices presented/installed

4) If your XML or external is loaded from different domain/subdomain then data can be restricted by cross-domain policies in the latest flash versions
Solution: make and upload cross-domain policy domain XML file to the domain(s) with the source data 
See 
http://kb2.adobe.com/cps/142/tn_14213.html
http://www.adobe.com/devnet/adobe-media-server/articles/cross-domain-xml-for-streaming.html
http://www.adobe.com/devnet/articles/crossdomain_policy_file_spec.html

5) if you are getting 503 error while converting to video then try to increase the default timeout for the conversion page like this:


If you are converting as the response to the click then try to increase the request timeout for this request by modifying the execution timeout in the config file like this:

<location path="somefile.aspx">
<system.web>
<httpRuntime executionTimeout="180"/>
</system.web>
</location>


--
Updated June 10, 2015