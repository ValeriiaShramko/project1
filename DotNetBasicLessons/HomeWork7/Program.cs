/*
int NumberDegree(int number, int degree)
{
    var numberDegree = 1;
    for (var i = 0; i < degree; i++)
    {
        numberDegree *= number;
    }
    return numberDegree;
}

try
{
    Console.WriteLine("Enter the basis of the degree:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the degree indicator:");
    int degree1 = Convert.ToInt32(Console.ReadLine());

    var numberDegree1 = NumberDegree(number1, degree1);
    Console.WriteLine($"Degree of number: {numberDegree1}");
}
catch (FormatException ex)
{
    Console.WriteLine("Incorrect data format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
}
*/
/*
int RangeSum(int start, int end)
{
    var sum = 0;
    for (var i = 0; i < (end - start + 1); i++)
    {
        sum += start + i;
    }
    return sum;
}
try
{
    Console.WriteLine("Enter the start of the range:");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end of the range:");
    int end = Convert.ToInt32(Console.ReadLine());

    var sum = RangeSum(start, end);
    Console.WriteLine($"The sum of numbers from the range: {sum}");
}
catch (FormatException ex)
{
    Console.WriteLine("Incorrect data format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
}
*/
/*
void FindPerfectNumbers(int start, int end)
{
    
    var rangeSize = end - start + 1;
    for (var i = 1; i < rangeSize; i++)
    {
        var checkNumber = start + i;

        var dividerSum = 0;
        for (var d = 1; d < checkNumber; d++)
        {
            if (checkNumber % d == 0)
            {
                dividerSum += d;
            }
        }
        if (dividerSum == checkNumber)
        {
            Console.WriteLine(checkNumber);
        }
    }
   
}

try
{
    Console.WriteLine("Enter the start of the range:");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end of the range:");
    int end = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Perfect numbers: ");
    FindPerfectNumbers(start, end);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Don't divide by zero.");
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Incorrect data format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
}
*/
/*
string GetCard(string[] cards, int number)
{
    return cards[number - 1];
}
try
{
    string[] cards = {
            "Ace of Spades", "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Spades", "Queen of Spades", "King of Spades",
            "Ace of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs",
            "Ace of Hearts", "Six of Hearts", "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts",
            "Ace of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds"
        };

    Console.WriteLine("Enter the card number:");
    var cardNumber = Convert.ToInt32(Console.ReadLine());

    var chosenCard = GetCard(cards, cardNumber);
    Console.WriteLine($"You have chosen the following card: {chosenCard}");
}
catch (FormatException ex)
{
    Console.WriteLine("Incorrect data format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
}
*/

bool IsHappyNumber(int number)
{

    if (number < 100000 || number > 999999)
    {
        throw new Exception("Inncorect number to check! Must be six-digit number!");
    }

    int digit1 = number / 100000;
    int digit2 = (number / 10000) % 10;
    int digit3 = (number / 1000) % 10;

    int digit4 = (number / 100) % 10;
    int digit5 = (number / 10) % 10;
    int digit6 = number % 10;

    int firstPart = digit1 + digit2 + digit3;

    int secondPart = digit4 + digit5 + digit6;

    return firstPart == secondPart;
}

try
{
    Console.WriteLine("Enter a six-digit number:");
    var number = Convert.ToInt32(Console.ReadLine());

    var isHappay = IsHappyNumber(number);

    if (isHappay)
    {
        Console.WriteLine($"The number {number} is Happy!");
    }
    else
    {
        Console.WriteLine($"The number {number} is not happy.");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Incorrect data format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
}



