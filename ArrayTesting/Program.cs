using System.Text;

static void Main(string[] args)
{

}


IList<string> checking = new List<string>()
{
        "New York",
        "London",
        "Mumbai",
        "Chicago",
        "New York",
};

foreach (string city in checking)
{
    Console.WriteLine($"City: {city}");
}

int number = 7;
if (number % 2 == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
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

int[] numberarrays = { 1, 2, 3, 4, 5 };
string[] values = { "eahee", "Tahir" };

var numbers = new List<int>();
numbers.Add(2);
numbers.Add(3);
numbers.Add(5);
numbers.Add(7);
Console.WriteLine("LIST 1: " + numbers.Sum());

List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < numberList.Count; i++)
    Console.WriteLine(numberList[i]);

string strMyValue = "Hello Visitor";
// create a new string instance instead of changing the old one
strMyValue += "How Are";
strMyValue += "You ??";
Console.WriteLine(strMyValue);

StringBuilder sbValue = new StringBuilder("");
sbValue.Append("Hello Visitor");
sbValue.Append("How Are You ??");
string concatenable = sbValue.ToString();
Console.WriteLine(concatenable);

var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

for (int i = 0; i < bigCities.Count; i++)
    Console.WriteLine(bigCities[i]);

var list = new List<int>()
{
    2,
    3,
    4,
    5,
};

for (int i = 0; i < list.Count; i++)
    Console.WriteLine(list[i]);

Random random = new Random();
int n = random.Next();
Console.WriteLine(n);

string[] stringarr;
stringarr = new string[3] { "Element 1", "Element 2", "Element 3" };
Console.WriteLine(stringarr[0]);
Console.WriteLine(stringarr[1]);
Console.WriteLine(stringarr[2]);

String[] abc = new String[] { "Geeks", "GFG", "Noida" };

Console.WriteLine(abc[0]);
Console.WriteLine(abc[1]);
Console.WriteLine(abc[2]);

static int CalculateonlyAddNumbers(int[] numbers)
{
    int sum = 0;
    
    foreach(int number in numbers)
    {
        if (number % 2 != 0)
        {
            sum += number;
        }
    }
    return sum;
}

List<int> list2 = new List<int>()
{
    1,3,3,4,4,5,6
};

int SumofOdd = CalculateonlyAddNumbers(list2.ToArray());
Console.WriteLine(SumofOdd);

Console.ReadLine();