import pyautogui as a

print(a.position())  # Позиция курсора
print(a.size())  # Разиер экрана
a.PAUSE = 0.5
a.move(-200, 300) #Смена позиции курсора(относительная)
a.move(-200, 300, duration=2.5) #Медленая смена позиции курсора(относительная)
a.moveTo(500, 500) #Смена позиции курсора(абсалютная)
a.moveTo(100, 100, duration=2.5)  #Медленая смена позиции курсора(абсалютная)
a.click() #клик ЛКМ
a.moveTo(700, 1050, duration=2.5)
a.click(button="right")
a.moveTo(750, 950, duration=2.5)
a.click()