#-------------------------------------------------
#
# Project created by QtCreator 2014-11-14T17:41:30
#
#-------------------------------------------------

QT       += core gui
QT       += axcontainer
#CONFIG   += qaxcontainer //Decomment if you have issue in compiling
greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = activeX
TEMPLATE = app


SOURCES += main.cpp\
        widget.cpp

HEADERS  += widget.h

FORMS    += widget.ui
