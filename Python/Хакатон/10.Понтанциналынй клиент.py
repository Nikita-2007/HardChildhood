import sys
import math
X1, Y1, R, X2, Y2 = map(int, input().split(','))
if math.sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2)) <= R:
    print(0)
else:
    print(1)