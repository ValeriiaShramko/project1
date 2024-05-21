Console.WriteLine("Введіть чотири числа:");

int num1, num2, num3, num4;

num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());
num4 = Convert.ToInt32(Console.ReadLine());

int number = num1 * 1000 + num2 * 100 + num3 * 10 + num4;

Console.WriteLine(number);

/* Console.WriteLine("Введіть шестизначне число");

int number = Convert.ToInt32(Console.ReadLine());

int num1 = number % 10;
int num2 = number % 100 / 10;
int num3 = number % 1000 / 100;
int num4 = number % 10000 / 1000;
int num5 = number % 100000 / 10000;
int num6 = number / 100000;

Console.WriteLine($"{num1}{num2}{num3}{num4}{num5}{num6}"); */

/* Console.WriteLine("Enter three numbers");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2 + num3;
Console.WriteLine($"Result: {sum}");
const int count = 3;
int average = sum / count;
Console.WriteLine($"Average: {average}"); */

/* Console.WriteLine("Enter the cost of the laptop");
decimal cost = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the number of laptops");
int count = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the discount percentage");
decimal discount = Convert.ToDecimal(Console.ReadLine());

decimal totalCost = cost * count;
decimal discountAmount = totalCost * (discount / 100);
decimal orderaAmount = totalCost - discountAmount;

Console.WriteLine($"Order amount: {orderaAmount}"); */

/* const decimal rate = 100;
const decimal interest = 5;

Console.WriteLine("Enter the total amount of the manager's trades during the month");
decimal totalAmount = Convert.ToDecimal(Console.ReadLine());

decimal amountOfInterest = totalAmount / 100 * interest;
decimal finalSalary = rate + amountOfInterest;

Console.WriteLine($"Final salary of the manager: {finalSalary}"); */


