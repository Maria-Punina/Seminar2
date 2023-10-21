// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(99 < number && number < 1000)
{
   int lastnumber = number /10 % 10;
  
     Console.WriteLine(lastnumber);
}
else
{
   Console.WriteLine("Введитие число меньше 1000, но больше 99");
}