// See https://aka.ms/new-console-template for more information

int[] numbers = new int[6];
Random rnd = new Random();

for (int i = 0; i <= 5; i++)
{
    int verify = rnd.Next(1, 61);

    while (Array.Exists(numbers, x => x == verify))
        verify = rnd.Next(1, 61);

    numbers[i] = verify;
}

Array.Sort(numbers);
Console.WriteLine("The numbers to become a millionaire are: ");
Console.WriteLine();
foreach (int item in numbers)
{
    Console.Write(" " + item + " ");
}
Console.WriteLine();
Console.WriteLine();