## Задание
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых не более 3 символов.
## Описание решения
Алгоритм реализован в методе filterShortStrings главного класса. 

В первом цикле определяется число строк, длина которых не превышает заданное значение max_len. Это число записывается в переменную count.

Далее создается массив result под count элементов.

Во втором цикле те строки, длина которых не превышает max_len, копируются в массив result.
