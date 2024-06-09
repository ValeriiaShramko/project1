/*
try
{
    Console.WriteLine("Enter the beginning of the range:");
    int inPutNum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end of the range:");
    int InPutNum2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("All numbers in the range:");

    var num1 = inPutNum1;
    var num2 = InPutNum2;

    while (num1 <= num2)
    {
        Console.Write(num1 + " ");
        num1++;
    }
    Console.WriteLine("\nAll numbers in the range in descending order:");

    num1 = inPutNum1;
    num2 = InPutNum2;

    while (num2 >= num1)
    {
        Console.Write(num2 + " ");
        num2--;
    }

    Console.WriteLine("\nAll numbers are multiples of 7:");

    for (num1 = inPutNum1, num2 = InPutNum2; num1 <= num2; num1++)
    {
        if (num1 % 7 == 0)
        {
            Console.Write(num1 + " ");
        }
    }

    Console.WriteLine("\nAmount of numbers that are multiples of 5:");

    var countOfMultiples = 0;

    for (num1 = inPutNum1, num2 = InPutNum2; num1 <= num2; num1++)
    {
        if (num1 % 5 == 0)
        {
            countOfMultiples++;
        }

    }
    Console.WriteLine(countOfMultiples);
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
try
{
    Console.WriteLine("Enter the beginning of the range:");
    int inPutNum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end of the range:");
    int InPutNum2 = Convert.ToInt32(Console.ReadLine());
    var num1 = inPutNum1;
    var num2 = InPutNum2;

    var sumEven = 0;
    var countEven = 0;

    for (; num1 <= num2; num1++)
    {
        if (num1 % 2 == 0)
        {
            sumEven += num1;
            countEven++;
        }
    }
    Console.WriteLine($"Sum of even numbers: {sumEven}");
    Console.WriteLine($"Arithmetic average of even numbers: {sumEven / countEven}");

    var sumOdd = 0;
    var countOdd = 0;

    for (num1 = inPutNum1; num1 <= num2; num1++)
    {
        if (num1 % 2 != 0)
        {
            sumOdd += num1;
            countOdd++;
        }
    }
    Console.WriteLine($"Sum of odd numbers: {sumOdd}");
    Console.WriteLine($"Arithmetic average of odd numbers: {sumOdd / countOdd}");

    var sumMultiples9 = 0;
    var countMultiples9 = 0;

    for (num1 = inPutNum1; num1 <= num2; num1++)
    {
        if (num1 % 9 == 0)
        {
            sumMultiples9 += num1;
            countMultiples9++;
        }
    }
    Console.WriteLine($"Sum of numbers that are multiples of 9: {sumMultiples9}");
    Console.WriteLine($"Arithmetic average of multiples of 9 numbers: {sumMultiples9 / countMultiples9}");
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
try
{
    int count = 0;

    for (int number = 100; number <= 999; number++)
    {
        int hundredths = number / 100;
        int tens = (number / 10) % 10;
        int ones = number % 10;

        if (hundredths == tens || hundredths == ones || tens == ones)
        {
            count++;
        }
    }

    Console.WriteLine($"Кількість чисел: {count}");
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

try
{
    Console.WriteLine("Enter the beginning of the range:");
    int inPutNum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end of the range:");
    int InPutNum2 = Convert.ToInt32(Console.ReadLine());

    var num1 = inPutNum1;
    var num2 = InPutNum2;

    for (; num1 <= num2; num1++)
    {
        for (var num = 1; num <= num1; num++)
        {
            if (num1 % num == 0)
            {
                if (num != 1 && num != num1)
                {
                    break;
                }
                else if (num == num1)
                {
                    Console.WriteLine($"{num1}");
                }
            }
        }
    }
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
