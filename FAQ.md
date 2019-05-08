# All SDK

### Can I get temporary demo license key?

No demo key is required to try SDK and play with it. Download free trial version of 1 or more SDK from [download page](https://bytescout.com/download/web-installer)

### I bought a license but my license key is not working

Make sure that you have 

- removed *demo* version
- downloaded **full** version from your licensing dashboard. 
- updated your application's code with your license name and license key
- recompiled your application

Can't find link to full version download? Please check your email box for order confirmation email where you may find link to your licensing dashboard.

# Barcode Generator SDK


# Barcode Reader SDK

### How can I increase speed of decoding?

#### If you have large input file (10+ pages) then first do this:

1. Changed your code to process page by page instead of the whole document:
```
sample code is here
```
2. ...

#### Still slow? Then try to do this:

1. Set barcode type to decode only to ones that you need:
```
```
2. If you process PDF documents then try to decrease rendering resolution to `200` or `150` dpi

```
reader.PDFResolution = 150
```





# Spreadsheet SDK

# PDF Extractor SDK

# PDF Renderer SDK

# PDF To HTML SDK

# PDF (Generator) SDK

# Document Parser SDK

# Invoice Parser SDK

# Screen Capturing SDK

# Text Recognition SDK
