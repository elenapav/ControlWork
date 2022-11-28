**Задача**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк,    
длина которых меньше, либо равна 3 символам.

---
**Описание решения задачи**   
1. Вводим размер массива n
2. Вводим значения элементов строкового массива array размером n - заполняем массив
3. Создаем метод PrintArray для печати массива(исходного и нового, у которого длина строки <=3)
4. Создаем метод NewStringArray, который возвращает новый массив со строками, длина которых меньше или равна 3:
 - считает сколько раз встречаются строки, длина которых меньше или равна 3 (счётчик size)
 - записывает эти строки в строку temp через запятую
 - создает новый строковый массив newArray размером size и заполняет его элементами из строки temp
(элементы разделяются запятой)
5. Передаем в метод NewStringArray исходный массив и печатаем новый массив с помощью метода PrintArray
