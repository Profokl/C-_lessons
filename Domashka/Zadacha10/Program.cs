//БЕЗ МЕТОДА

// Console.WriteLine("Введите трехзначное число:");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = a / 10;
// int result1 = result % 10;
// Console.WriteLine(result1);

// С МЕТОДОМ
int Second (int arg)
{
   int result = arg / 10;
   int result1 = result % 10; 
   return result1;
}

Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());

Second (a);
Console.WriteLine(Second(a));