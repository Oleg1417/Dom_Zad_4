//                                      Задача 25: 
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//                              в натуральную степень B.

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень числа:");
int pow = int.Parse(Console.ReadLine()!);

IntPow(number, pow);

int IntPow(int number, int pow)
{
    int num = Convert.ToInt32(Math.Pow(number, pow));
    Console.WriteLine($"Число {number} возведенное в степень {pow} равно: {num}");
    return num;
}


//                                      Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
int Numb = int.Parse(Console.ReadLine()!);

SumNumber(Numb);

int SumNumber(int Numb)
{
    int end = 0;
    int rez = 0;
    do
    {
        end = Numb % 10;
        Numb = Numb / 10;
        rez = rez + end;
    }
    while (Numb > 0);
    Console.WriteLine($"Cумма цифр в числе равна: {rez}");
    return rez;
}

//                                      Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = NewArray(8, 0, 500);
Console.WriteLine($"[{String.Join(" ", array)}]");

int[] NewArray(int size, int min, int max)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(min, max + 1);
    }
    return mas;
}
