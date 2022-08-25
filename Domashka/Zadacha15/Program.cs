// ПРОСТОЕ РЕШЕНИЕ

// Console.WriteLine("Введите номер дня недели:");
// int week = Convert.ToInt32(Console.ReadLine());

// if (week < 6)
// {
//     Console.WriteLine("будний день");
// }
// else
// {
//     Console.WriteLine("выходной день");
// }
// if (week>7)
// {
//     Console.WriteLine ("нет такого дня недели");
// }

//АЛЬТЕРНАТИВНОЕ РЕШЕНИЕ

Console.WriteLine("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());

int Week(int week)
{
    if (week > 7)
    {
        Console.WriteLine("нет такого дня недели");
        return(0);
    }
    if (week < 6)
    {
        Console.WriteLine("будний день");
        return(0);
    }
    else
    {
        Console.WriteLine("выходной день");
        return (0);
    }
    
}

Week(day);




