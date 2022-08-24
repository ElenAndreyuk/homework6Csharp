// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько чисел будете вводить?");
int M = Convert.ToInt32(Console.ReadLine());
int []array = new int [M];
int count = 0;
Console.WriteLine("Вводите числа");
for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int j = 0; j < M; j++)
{
    if (array[j] > 0) count++;
}
Console.WriteLine($"{count} чисел больше нуля");

