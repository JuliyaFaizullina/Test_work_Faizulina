# Test_work_Faizulina
# Задача:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

## Пример:
* ["hello", "2", ";-)"] -> ["2", ";-)"]

* ["1234", "1567", "-2", "computer secience"] -> ["-2"]

* ["Russia", "Denmark", "Kazan"] -> []

### Алгоритм решения:
1. Создаем два строковых массива:
> - Первый строковый массив будет содержать следующие символы : ["hello", "2", ";-)"], как было отображено в одном из примеров;
> - Второй строковый массив будет равен по длине первому массиву;

2. Объявляем переменную count (счетчик), присваиваем ей первоначальное значение, равное 0. Она понадобится нам для проверки выполнения условия в дальнейшем цикле;
3. Объявляем метод с циклом и условием для его выполнения. Цикл стандартного типа 
>> for (int i = 0; i < mass1.Length; i++)

Условие if должно осуществлять проверку условия **<=3**:
-  если условие выполняется, элемент первого массива заносится во второй массив;
- в противном случае осуществляется переход к проверке следующего элемента первого массива;
4. Проверка будет осуществляться до тех пор, пока счетчик count не будет равен количеству элементов массива;

5. Полученный результат, а именно второй массив,  выводится на экран.

### Графическое представление алгоритма решения можно увидеть в следующем файле:

### Код программы на языке C# находится в следующем файле:

Program.cs