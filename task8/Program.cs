// принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());
int m = 1;
for (int i = m; i <= N; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }