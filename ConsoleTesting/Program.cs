using Perfolizer.Mathematics.Functions;

static void Main(string[] args)
{
 }

List<int> Any = new List<int>()
        {
            1, 3, 3, 4,5,5,5
        };

bool anyGreaterThan5 = Any.Any(item => item > 5);

if (anyGreaterThan5)
{
    Console.WriteLine("There is at least one element greater than 5.");
}
else
{
    Console.WriteLine("There are no elements greater than 5.");
}

bool existsGreaterThan5 = Any.Exists(item => item > 5);

if (existsGreaterThan5)
{
    Console.WriteLine("There is at least one element greater than 5.");
}
else
{
    Console.WriteLine("There are no elements greater than 5.");
}

static int CalculateSumOfOddNumbers(int[] numberarrays)
{
    int sum = 0;

    foreach (int number in numberarrays)
    {
        if (number % 2 != 0)
        {
            sum += number;
        }
    }

    return sum;
}

var array = new List<int>()
{ 1,2,3,4,5,6,8,10 };

int sumOfOddNumbers = CalculateSumOfOddNumbers(array.ToArray());
Console.WriteLine($"Sum of odd numbers in the array: {sumOfOddNumbers}");

Console.ReadLine();
