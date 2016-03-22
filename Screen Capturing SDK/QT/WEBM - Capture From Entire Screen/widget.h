//*******************************************************************
//       ByteScout Screen Capturing SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
