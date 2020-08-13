## How to create side by side manifest in VB6 and ByteScout Robotic Process Automation ByteScout Robotic Process Automation is components and tools for quick RPA (Robotic Process Automation) implementation.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Robotic%20Process%20Automation%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Robotic%20Process%20Automation%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=gEjuZ0zgtHo](https://www.youtube.com/watch?v=gEjuZ0zgtHo)




<!-- code block begin -->

##### **HowTo.txt:**
    
```
For Visual Basic 6 and other programming languages where ByteScout is used via COM / ActiveX interface.

Windows provides a feature called "Side by side manifest"  for .exe and .dll applications. The idea is that you may link to .NET / ActiveX dll libraries without installing or registering them on the computer for global access. 

While it still recommended to install ActiveX / COM version using `InstallAsActiveX.bat` included into `/Redistributable/` folder you may also generate `.manifest` file that will tell Windows to load dlls from the same folder instead of global ones.

The Manifest Generator tool from https://github.com/wqweto/UMMM (comes with open source code for Visual Basic 6) can generate manifest file for COM / ActiveX and .NET dlls (like ByteScout SDK) 

Also see this discussion: https://stackoverflow.com/questions/465882/generate-manifest-files-for-registration-free-com

Dynamic manifest generation will also help to avoid manual update in case some of dlls (from ByteScout or from another vendor) will add new classes or declarations.

See `/src/Readme.md` for more details and the detailed instruction.

```

<!-- code block end -->