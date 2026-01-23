
// Sum of infinite numbers until 0 is found
List<int> numbers = [7, 4, 22, -8, 6, 0];
int sum = 0;
foreach (int number in numbers)
{
    if (number == 0)
    {
        Console.WriteLine("Finished");
        break;
    }
    sum += number;
    Console.WriteLine(sum);
}

