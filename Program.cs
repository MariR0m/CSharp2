// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

 if (number < 100 || number > 999)
 {
    Console.WriteLine("Ошибка. Введено не трехзначное число.");
 }

int a = (number / 10) % 10;
 
System.Console.Write("Вторая цифра введенного числа: " + a);
