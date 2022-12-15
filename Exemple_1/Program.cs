/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

/*
1. метод приема числа из консоли
2. метод скаладывания чисел
*/

//функция получения числа с консоли
int GetNumber(string message)
{
int result = 0;
bool isCorrect = false;


while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 0)
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите корректное число");
}
}

return result;
}

//функция получения числа с консоли
int GetNumber1(string message)
{
int result = 0;
bool isCorrect = false;


while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите корректное число");
}
}

return result;
}

//Создание массива
int[] GetArray(int length)
{
int [] array = new int [length];
for (int i = 0; i < length; i++)
{
array[i] = GetNumber1("Введите число массива");
}
return array;
}

//метод нахождения суммы чисел больше нуля
int PositiveNumberSumm(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)sum += arr[i];
        else;
    }
    return sum;
}

int length = GetNumber("Введите количество цифр в массиве");
int[] arrStart = GetArray(length);
int sum = PositiveNumberSumm(arrStart);

Console.WriteLine($"Сумма всех положительных чисел равна {sum}");