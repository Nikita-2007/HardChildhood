print("Введите время прихода первого человека:")
h1, m1 = map(int, input().split(':'))
print("Введите время прихода второго человека:")
h2, m2 = map(int, input().split(':'))
mini = min((h1 * 60 + m1), (h2 * 60 + m2))
maxi = max((h1 * 60 + m1), (h2 * 60 + m2))
if (mini < 15):
    mini += 1440
if (maxi - mini <= 15):
    print("Встреча состоится")
else:
    print("Встреча не состоится")
