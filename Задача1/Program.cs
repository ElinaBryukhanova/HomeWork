// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());
if (99 < N & N < 1000) {
    int number = N / 10 - N / 100 * 10;
    Console.WriteLine($"Вторая цифра числа {number}");
}
else {
    Console.WriteLine("Введено некорректное число");
}
