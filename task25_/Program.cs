// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result *= num1;
    }
    return result;
}

if (numberB > 0)
{
int result = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} -> {result}");
}
else Console.WriteLine("Требуется ввести натуральное число.");