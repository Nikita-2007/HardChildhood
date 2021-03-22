import mouse, keyboard
import pyautogui as a
from PySide2 import QtCore, QtWidgets
from modules.Form import Ui_Form
from time import sleep

class Main(Ui_Form, QtWidgets.QWidget):
    """Код автокликера"""
    def __init__(self):
        super().__init__()
        self.click_x = 0
        self.click_y = 0
        self.tempo = 100
        self.setupUi(self)
        self.installEventFilter(self)
        self.show()
        #Сигналы-слоты
        self.timer = QtCore.QTimer(self)
        self.timer.setInterval(self.tempo)
        self.timer.timeout.connect(self.auto_click)
        self.click_status = False
        self.Startstop.clicked.connect(self.button_click)
        keyboard.hook(self.print_pressed_case)

    def button_click(self):
        """Автокликер-Переключатель"""
        self.click_status = not self.click_status
        if self.click_status:
            self.timer.start()
            self.Startstop.setText("стоп/СТАРТ")
        else:
            self.timer.stop()
            self.Startstop.setText("СТОП/старт")

    def auto_click(self):
        """Автокликек-Кликер"""
        #a.click()
        for i in range(100):
            mouse.click()
        sleep(0.01)

    def mousePressEvent(self, e):
        """Автокликер-Позиция курсора(Qt)"""
        self.posX.setText(str(e.x()))
        self.posY.setText(str(e.y()))

    def print_pressed_case(self, e):
        """Автокликер-Горячие клавиши(Ketboard)"""
        print(e.event_type, e.name)
        if e.event_type == "up":
            self.button_click()