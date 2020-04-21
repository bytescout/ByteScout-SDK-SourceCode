## How to create side by side manifest in VB6 with Multiple ByteScout SDK

### Write code in VB6 to create side by side manifest with this step-by-step tutorial

On this page you will learn from code samples for programming in VB6.Writing of the code to create side by side manifest in VB6 can be done by developers of any level using Multiple ByteScout SDK. Multiple ByteScout SDK is the set of few ByteScout SDK libraries that is used in apps performing multi-step workflows like searching for keywords or phrases inside existing documents with highlighting of results, or adding e-signature to existing document pdf based on the analysis of visual content in another document. It can create side by side manifest in VB6.

Fast application programming interfaces of Multiple ByteScout SDK for VB6 plus the instruction and the code below will help you quickly learn how to create side by side manifest. This VB6 sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test VB6 sample code examples whether they respond your needs and requirements for the project.

Our website provides trial version of Multiple ByteScout SDK for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=Multiple%20ByteScout%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=Multiple%20ByteScout%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****HowTo.txt:**
    
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