Console.Clear();

// семинар 1 

// 1 Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

// int sqrt = number * number;
// number *= number;
int sqrt1 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine("Число в квадрате: " + sqrt1);
