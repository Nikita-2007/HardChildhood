﻿/* Дан довольно большой текст состоящий из слов разделённых пробелами. Определите, какое слово в этом тексте встречается чаще остальных.
Если таких слов несколько выведите их все в лексикографическом порядке.
Формат ввода
Число слов в тексте 1≤n≤10000 затем, с новой строки перечислены слова разделённые пробелами. Слова состоят из строчных латинских символов [a-z]. Размер слова 5 символов.
Формат вывода
Слово или список слов отсортированных в лексикографическом порядке и разделённых пробелом.
Пример 1
Ввод	Вывод
2
twfsk twfsk
twfsk 
Пример 2
Ввод	Вывод
6
xylbi nidzt xylbi nidzt zlobi binki
nidzt xylbi 
Примечания
Нужно выбрать правильную структуру данных для подсчёта слов.
*/

#include <iostream>
#include <string>
#include <map>
#include <vector>
#include <algorithm>

bool compare(const std::string& a, const std::string& b) {
    if (a > b)
        return true;
    else if (a < b)
        return false;
    else if (a == b) {
        if (a.length() > b.length())
            return false;
        else if (a.length() < b.length())
            return true;
        else if (a.length() == b.length()) {
            if (a.find('0') >= b.find('0'))
                return false;
            else
                return true;
        }
    }
}

int main() {
    int n, t = 0; // число слов, максимальное кол-во повторений
    std::string s; // набор слов
    std::map<std::string, int> m; // словарь <слово, кол-во>
    std::vector<std::string> v; // максимально повторяющиеся слова

    // запонляем словарь словами и их количеством
    std::cin >> n;
    for (int i = 0; i < n; i++) {
        std::cin >> s;
        m[s]++;
    }

    // заполняем вектор словами которых больше 1
    for (const auto& i : m)
        if (t < i.second) {
            t = i.second;
            v.clear();
            v.push_back(i.first);
        } else if (t == i.second)
            v.push_back(i.first);

    // сортировка вектора
    std::sort(v.begin(), v.end(), compare);

    // вывод максимально повторяющихся слов
    for (std::string &i : v)
        std::cout << i << " ";

    return 0;
}