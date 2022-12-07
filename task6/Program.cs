// является ли число чётным
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("even");
}
if (number % 2 > 0)
{
    Console.WriteLine("no even");
}
