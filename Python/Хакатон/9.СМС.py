arr = list(input().split(','))
arre = ['1', '2' ,'3', '4']
if arr[3] == 'М':
    arre[0] = 'Уважаемый '
else:
    arre[0] = 'Уважаемая '
arre[1] = arr[0]
arre[2] = ' на вашем счете (карта VISA' + str(arr[1][-4:]) + ') осталось '
arre[3] = arr[2]
print(''.join(arre), 'руб.')
