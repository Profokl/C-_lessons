Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
string str = N.ToString();
int[] array = new int[str.Length];
int count = 0;
while (count<str.Length)
{
    array[count] = Convert.ToInt32(str[count].ToString());
    count++;
}
Console.WriteLine();
if(str.Length>2)
{
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}
