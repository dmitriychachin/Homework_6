/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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

//Копирование массива
int[] Copyarray(int[] array)
{
    int copyLenght = array.Length;
    int [] copyArray = new int [copyLenght];
    for (int i = 0; i < copyLenght; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

//Распечатывание массива
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

Console.WriteLine();
int lenght = GetNumber("Введите количество объектов массива:");
int[] firstArray = GetArray(lenght);
Console.WriteLine("Созданный массив");
printArray(firstArray);
int[] copyArray = Copyarray(firstArray);
Console.WriteLine();
Console.WriteLine("Скопированный массив");
printArray(copyArray);