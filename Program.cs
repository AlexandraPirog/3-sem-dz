//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int[] point = new int[5];
System.Console.WriteLine("Введите пятизначное число: ");
Convert.ToInt32(Console.ReadLine());
if (point[0]==point[4] && point[1]==point[3])
{
    System.Console.WriteLine("число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}



