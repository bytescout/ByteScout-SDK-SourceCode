## How to capture video from entire screen in QT in C++ (unmanaged) using ByteScout Screen Capturing SDK

### This code in C++ (unmanaged) shows how to capture video from entire screen in QT with this how to tutorial

These sample source codes on this page below are demonstrating how to capture video from entire screen in QT in C++ (unmanaged). ByteScout Screen Capturing SDK can capture video from entire screen in QT. It can be used from C++ (unmanaged). ByteScout Screen Capturing SDK is the screen video recording SDK helps in quick implementation of screen video recording. WMV, AVI, WebM output options are available with adjustable quality, video size, framerate and video and audio codec. Includes special features like live multiple blacking out of selected areas, recording from web cam as main source and as overlay, optional watermarks for output video.

This rich sample source code in C++ (unmanaged) for ByteScout Screen Capturing SDK includes the number of functions and options you should do calling the API to capture video from entire screen in QT. Follow the instructions from the scratch to work and copy the C++ (unmanaged) code. Implementing C++ (unmanaged) application typically includes multiple stages of the software development so even if the functionality works please test it with your data and the production environment.

ByteScout Screen Capturing SDK free trial version is available on our website. C++ (unmanaged) and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Screen%20Capturing%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Screen%20Capturing%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=fujkvtWUVCw](https://www.youtube.com/watch?v=fujkvtWUVCw)




<!-- code block begin -->

##### ****main.cpp:**
    
```
#include "widget.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    Widget w;
   // w.show(); Decomment if you need custom the GUI

    return a.exec();
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****widget.cpp:**
    
```
#include "widget.h"
#include "ui_widget.h"
#include <QDebug>
#include <windows.h>
#include <iostream>

using namespace std;

Widget::Widget(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Widget)
{
    ui->setupUi(this);
    //Decomment if you need to use QAxWidget
    //com = new QAxWidget;
    //Comment if you need QAxWidget
    com = new QAxObject;
    com->setControl("BytescoutScreenCapturing.Capturer");
    QString error = com->property("LastError").toString();
    if (error.compare("No errors.")!=0) // or empty string
    {
        cout <<"Screen Capturer is not installed properly. " <<
               error.toStdString() << endl;
        exit(1);
    }
    com->setProperty("RegistrationName","demo");
    com->setProperty("RegistrationKey","demo");
    com->setProperty("CapturingType",3);//catScreen: Capture all screen

    /************************************************************************************
     * The code you sent me used the webcam too.
     * Decomment if you need show webcam streaming
     *************************************************************************************
     *************************************************************************************/

    //com->setProperty("CurrentWebCam",0);
    //com->setProperty("CaptureTransparentControls",true);
    // Set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10, 10)
    //com->dynamicCall("SetWebCamVideoRectangle(int,int,int,int)",10, 10, 160, 120);
    // Enable webcam overlaying capture device
    //com->setProperty("AddWebCamVideo",true);

    //com->setProperty("OutputWidth",640);
    //com->setProperty("OutputHeight",480);
    /**************************************************************************************
    //End webcam property
    /***************************************************************************************
    */


    // Set output file name
    com->setProperty("OutputFileName", "Output.wmv");
    com->dynamicCall("Run()");


//' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
//' using Thread.Sleep(1) inside the checking loop, so you have the loop like
//' Do 
//' Thread.Sleep(1) 
//' While StopButtonNotClicked

    error = com->property("LastError").toString();
    if (error.compare("No errors.")!=0)
    {
        cout <<"Capture failed. " <<
               error.toStdString() << endl;
        exit(1);
    }

    //Testing purposes:
    //Register for 10 seconds and after stop the process
    //You can stop the registration as you prefer: Input, keyboard and so on..

   Sleep(10000); //Usefull for testing purposes: Register for 10 seconds
   com->dynamicCall("Stop()");  //End registration
   qDebug()<<"End Registration";

}

Widget::~Widget()
{
    delete ui;
}

```

<!-- code block end -->    

<!-- code block begin -->

##### ****widget.h:**
    
```
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include <QKeyEvent>
#include <QAxWidget>
#include <QAxObject>
#include <QEvent>
namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT
    
public:
    explicit Widget(QWidget *parent = 0);
    ~Widget();
    
private:
    Ui::Widget *ui;
    //You can switch to QAxWidget
    //QAxWidget * com;
    QAxObject * com;
};

#endif // WIDGET_H

```

<!-- code block end -->