//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


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
