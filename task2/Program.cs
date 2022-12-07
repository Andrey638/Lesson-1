//выбор наибольшего числа
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine(number1);
}
if (number2 > number1)
{
    Console.WriteLine(number2);   
}
if (number1 == number2)
{
    Console.WriteLine("числа равны");
}
