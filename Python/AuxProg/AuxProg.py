from modules.Main import Main
from PySide2 import QtWidgets
import sys

if __name__ == '__main__':
    app = QtWidgets.QApplication(sys.argv)
    main = Main()

    sys.exit(app.exec_())