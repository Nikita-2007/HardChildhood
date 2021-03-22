# -*- coding: utf-8 -*-

################################################################################
## Form generated from reading UI file 'designerjOjEFF.ui'
##
## Created by: Qt User Interface Compiler version 5.15.2
##
## WARNING! All changes made in this file will be lost when recompiling UI file!
################################################################################

from PySide2.QtCore import *
from PySide2.QtGui import *
from PySide2.QtWidgets import *


class Ui_Form(object):
    def setupUi(self, Form):
        if not Form.objectName():
            Form.setObjectName(u"Form")
        Form.resize(362, 173)
        Form.setStyleSheet(u"")
        self.Startstop = QPushButton(Form)
        self.Startstop.setObjectName(u"Startstop")
        self.Startstop.setGeometry(QRect(30, 80, 131, 41))
        icon = QIcon()
        icon.addFile(u"images\icon.jpg", QSize(), QIcon.Normal, QIcon.Off)
        Form.setWindowIcon(icon)
        self.Startstop.setStyleSheet(u".QGraphicsView {background-color: qlineargradient(spread:pad, x1:0, y1:1, x2:0, y2:0,"
                                     u"stop:0 rgba(0, 0, 0, 255), stop:0.05 rgba(14, 8, 73, 255), stop:0.36 rgba(28, 17, 145, 255),"
                                     u"stop:0.6 rgba(126, 14, 81, 255), stop:0.75 rgba(234, 11, 11, 255), stop:0.79 rgba(244, 70, 5, 255),"
                                     u"stop:0.86 rgba(255, 136, 0, 255), stop:0.935 rgba(239, 236, 55, 255))"
                                     u"")
        self.label = QLabel(Form)
        self.label.setObjectName(u"label")
        self.label.setGeometry(QRect(190, 70, 161, 20))
        self.label.setStyleSheet(u".QGraphicsView {\n"
"	\n"
"	background-color: qradialgradient(spread:repeat, cx:0.5, cy:0.5, radius:0.077, fx:0.5, fy:0.5, stop:0 rgba(0, 169, 255, 147), stop:0.497326 rgba(0, 0, 0, 147), stop:1 rgba(0, 169, 255, 147))\n"
"}")
        self.posX = QLabel(Form)
        self.posX.setObjectName(u"posX")
        self.posX.setGeometry(QRect(260, 103, 41, 31))
        self.label_4 = QLabel(Form)
        self.label_4.setObjectName(u"label_4")
        self.label_4.setGeometry(QRect(230, 133, 31, 31))
        self.label_5 = QLabel(Form)
        self.label_5.setObjectName(u"label_5")
        self.label_5.setGeometry(QRect(230, 103, 31, 31))
        self.posY = QLabel(Form)
        self.posY.setObjectName(u"posY")
        self.posY.setGeometry(QRect(260, 140, 41, 20))
        self.label_2 = QLabel(Form)
        self.label_2.setObjectName(u"label_2")
        self.label_2.setGeometry(QRect(30, 10, 331, 51))
        self.graphicsView = QGraphicsView(Form)
        self.graphicsView.setObjectName(u"graphicsView")
        self.graphicsView.setGeometry(QRect(0, -20, 371, 192))
        self.graphicsView.setStyleSheet(u".QGraphicsView {\n"
"	\n"
"	background-color: qradialgradient(spread:repeat, cx:0.5, cy:0.5, radius:0.077, fx:0.5, fy:0.5, stop:0 rgba(0, 169, 255, 147), stop:0.497326 rgba(0, 0, 0, 147), stop:1 rgba(0, 169, 255, 147))\n"
"}")
        self.graphicsView_2 = QGraphicsView(Form)
        self.graphicsView_2.setObjectName(u"graphicsView_2")
        self.graphicsView_2.setGeometry(QRect(0, -20, 411, 192))
        self.graphicsView_2.setStyleSheet(u".QGraphicsView {\n"
"	\n"
"	background-color: rgb(255, 255, 255)\n"
"}")
        self.graphicsView_2.raise_()
        self.graphicsView.raise_()
        self.Startstop.raise_()
        self.posX.raise_()
        self.label_4.raise_()
        self.label_5.raise_()
        self.posY.raise_()
        self.label_2.raise_()
        self.label.raise_()
        #self.setWindowFlag(Qt.WindowStaysOnTopHint)
        self.retranslateUi(Form)

        QMetaObject.connectSlotsByName(Form)
    # setupUi

    def retranslateUi(self, Form):
        Form.setWindowTitle(QCoreApplication.translate("Form", u"AuxProg", None))
        self.Startstop.setText(QCoreApplication.translate("Form", u"\u0421\u0442\u0430\u0440\u0442/\u0421\u0442\u043e\u043f", None))
        self.label.setText(QCoreApplication.translate("Form", u"<html><head/><body><p><span style=\" font-size:12pt;\">\u041a\u043e\u043e\u0440\u0434\u0438\u043d\u0430\u0442\u044b \u043a\u0443\u0440\u0441\u043e\u0440\u0430:</span></p></body></html>", None))
        self.posX.setText(QCoreApplication.translate("Form", u"<html><head/><body><p><span style=\" font-size:12pt;\">0</span></p></body></html>", None))
        self.label_4.setText(QCoreApplication.translate("Form", u"<html><head/><body><p><span style=\" font-size:12pt;\">Y:</span></p></body></html>", None))
        self.label_5.setText(QCoreApplication.translate("Form", u"<html><head/><body><p><span style=\" font-size:12pt;\">X:</span></p></body></html>", None))
        self.posY.setText(QCoreApplication.translate("Form", u"<html><head/><body><p><span style=\" font-size:12pt;\">0</span></p></body></html>", None))
        self.label_2.setText(QCoreApplication.translate("Form", u"<html><head/><body><p><span style=\" font-size:36pt;\">АВТОКЛИКЕР</span></p></body></html>", None))
    # retranslateUi

