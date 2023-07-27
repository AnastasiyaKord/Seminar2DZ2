
// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number == 1){Console.WriteLine("Понедельник");}
if (number == 2){Console.WriteLine("Вторник");}
if (number == 3){Console.WriteLine("Среда");}
if (number == 4){Console.WriteLine("Четверг");}
if (number == 5){Console.WriteLine("Пятница");}
if (number == 6){Console.Write("Суббота! ");
Console.WriteLine("Ура! Это выходной!");}
if (number == 7){Console.Write("Воскресение! ");
Console.WriteLine("Ура! Это выходной!");}
if (number < 1 || number > 7)
Console.WriteLine($"Нет такого дня недели");