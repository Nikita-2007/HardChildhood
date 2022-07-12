def title_case(title, minor_words=''):
    arrt = list(title.lower().split())
    arrm = list(minor_words.lower().split())

    for i in range(len(arrt)):
        if arrt[i] in arrm:
            arrt[i] = arrt[i].lower()
        else:
            arrt[i] = arrt[i].capitalize()
    title = ' '.join(arrt)
    title = title[0:1].upper() + title[1:len(title)]
    return title

#для локального запуска
print(title_case('the quick brown fox'))
