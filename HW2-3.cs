﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1) 
 {
    System.Console.Write("В неделе нет такого дня");
 }

else if (number == 6 || number == 7)
   {
     System.Console.Write("Данный день является выходным.");
  }
else 
     System.Console.Write("Данный день не является выходным.");
 
