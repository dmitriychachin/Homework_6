/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//функция получения числа с консоли
int GetNumber(string message)
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

//Проверка на наличие пересичений или пересичений бесконечное количество
double lineCross(double k1, double k2, double b1, double b2)
{
    int oneCross = 0;

    if (k1 / k2 == 1 && k1 != k2)
    {
        Console.WriteLine("Пряммые паролельны и не имеют точек пересечения.");
    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые имеют бесконечное количество пересичений");
    }
    else oneCross = 1;

    return oneCross;
}

//Нахождении x
double crossX(double k1, double k2, double b1, double b2)
{
    double crossX = 0;

    crossX = (b2 - b1) / (k1 -k2);

    return crossX;
}

//Нахождение Y
double crossY(double k1, double b1, double crossX)
{
    double crossY = k1 * crossX + b1;

    return crossY;
}

double k1 = GetNumber("Введите значение k1:");
double k2 = GetNumber("Введите значение k2:");
double b1 = GetNumber("Введите значение b1:");
double b2 = GetNumber("Введите значение b2:");
double resultX = 0;
double resultY = 0;

double lineCros = lineCross(k1, k2, b1, b2);

if (lineCros == 1)
{
    resultX = crossX(k1, k2, b1, b2);
    resultY = crossY(k1, b1, resultX);
    
    Console.WriteLine($"Точка пересичения прямых равна ({resultX}:{resultY})");
}
else ;
