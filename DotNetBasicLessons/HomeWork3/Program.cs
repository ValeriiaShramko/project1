Console.WriteLine("Enter five student grades on a five-point system");

int grade1 = Convert.ToInt32(Console.ReadLine());
int grade2 = Convert.ToInt32(Console.ReadLine());
int grade3 = Convert.ToInt32(Console.ReadLine());

    int grade4 = Convert.ToInt32(Console.ReadLine());
int grade5 = Convert.ToInt32(Console.ReadLine());

int average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

if (average >= 4 && average <= 5)
{
    Console.WriteLine("the student is admitted to the exam!");
}
else
{
    Console.WriteLine("The student is not allowed to take the exam!");
}

/*
Console.WriteLine("Please enter a number:");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    number *= 3;
}

else
{
    number /= 2;
}

Console.WriteLine($"Result: {number}");
*/
/*
Console.WriteLine("Enter a number");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter one of the characters: +, -, *, / ");
var sign = Convert.ToChar(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Enter a number");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

const char signPlus = '+';
const char signMines = '-';
const char signMultiplication = '*';
const char signDivision = '/';
decimal result = 0; ;

if (sign == signPlus)
{
    result = num1 + num2;
}
else if (sign == signMines)
{
    result = num1 - num2;
}
else if (sign == signMultiplication)
{
    result = num1 * num2;

}
else if (sign == signDivision)
{
    result = num1 / num2;
}
else
{
    Console.WriteLine("Error");
}

Console.WriteLine($"Result: {result}");
*/

/*
Console.WriteLine("Enter the total amount of the first manager's transactions");
decimal manager1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the total amount of the second manager's transactions");
decimal manager2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the total amount of the third manager's transactions");
decimal manager3 = Convert.ToDecimal(Console.ReadLine());
decimal rate = 200;
decimal interestM1, interestM2, interestM3;

if (manager1 < 500)
{
    interestM1 = 3;
}
else if (manager1 >= 500 || manager1 <= 1000)
{
    interestM1 = 5;
}
else if (manager1 > 1000)
{
    interestM1 = 8;
}
else
{
    interestM1 = 0;
}

var salaryM1 = manager1 * (interestM1 / 100) + rate;

if (manager2 < 500)
{
    interestM2 = 3;
}
else if (manager2 >= 500 || manager2 <= 1000)
{
    interestM2 = 5;
}
else if (manager1 > 1000)
{
    interestM2 = 8;
}
else
{
    interestM2 = 0;
}

var salaryM2 = manager2 * (interestM2 / 100) + rate;

if (manager3 < 500)
{
    interestM3 = 3;
}
else if (manager3 >= 500 || manager3 <= 1000)
{
    interestM3 = 5;
}
else if (manager3 > 1000)
{
    interestM3 = 8;
}
else
{
    interestM3 = 0;
}

var salaryM3 = manager3 * (interestM3 / 100) + rate;

if (salaryM1 > salaryM2 && salaryM1 > salaryM3)
{
    salaryM1 += 200;
    Console.WriteLine($"The first manager receives a bonus!");
}
else if (salaryM2 > salaryM1 && salaryM2 > salaryM3)
{
    salaryM2 += 200;
    Console.WriteLine($"The second manager receives a bonus!");
}
else if (salaryM3 > salaryM2 && salaryM3 > salaryM2)
{
    salaryM3 += 200;
    Console.WriteLine($"The third manager receives a bonus!");
}
Console.WriteLine($"Salary of the first manager: {salaryM1}");
Console.WriteLine($"Salary of the second manager: {salaryM2}");
Console.WriteLine($"Salary of the third manager: {salaryM3}");
*/
