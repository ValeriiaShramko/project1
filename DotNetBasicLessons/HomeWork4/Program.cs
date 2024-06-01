/*namespace HomeWork4;

enum MathActions
{
    Plus = '+',
    Minus = '-',
    Multiply = '*',
    Divide = '/',
    Modulus = '%'
}

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter one of the characters: +, -, *, /, %");
            var mathActions = (MathActions)Convert.ToChar(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter a number");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            switch (mathActions)
            {
                case MathActions.Plus:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case MathActions.Minus:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case MathActions.Multiply:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case MathActions.Divide:
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                case MathActions.Modulus:
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;
                default:
                    throw new Exception("The operation is not supported");
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
    }
}
*/
namespace HomeWork4;

enum Pizza
{
    Мargaritaus = 1111,
    FourCheeses = 2222,
    Meaty = 3333,
    Hawaiian = 4444
}

enum Drinks
{
    Cola = 5555,
    Fanta = 6666,
    Coffee = 7777
}
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Pizza:");
            Console.WriteLine($"{Pizza.Мargaritaus} - {(int)Pizza.Мargaritaus} - 5$");
            Console.WriteLine($"{Pizza.FourCheeses} - {(int)Pizza.FourCheeses} - 7$");
            Console.WriteLine($"{Pizza.Meaty} - {(int)Pizza.Meaty} - 10$");
            Console.WriteLine($"{Pizza.Hawaiian} - {(int)Pizza.Hawaiian} - 8$");

            Console.WriteLine("Enter the product code:");
            var pizza = (Pizza)Convert.ToInt32(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter the number of product units");
            var pizzaCount = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Drinks:");
            Console.WriteLine($"{Drinks.Cola} - {(int)Drinks.Cola} - 1$");
            Console.WriteLine($"{Drinks.Fanta} - {(int)Drinks.Fanta} - 2$");
            Console.WriteLine($"{Drinks.Coffee} - {(int)Drinks.Coffee} - 3$");

            Console.WriteLine("Enter the product code:");
            var drinks = (Drinks)Convert.ToInt32(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter the number of product units");
            var drinksCount = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

            var pizzaPrice = 0;

            switch (pizza)
            {
                case Pizza.Мargaritaus:
                    pizzaPrice = 5;
                    break;
                case Pizza.FourCheeses:
                    pizzaPrice = 7;
                    break;
                case Pizza.Meaty:
                    pizzaPrice = 10;
                    break;
                case Pizza.Hawaiian:
                    pizzaPrice = 8;
                    break;
                default:
                    throw new Exception("Pizza code not found");

            }
            var drinksPrice = 0;

            switch (drinks)
            {
                case Drinks.Cola:
                    drinksPrice = 1;
                    break;
                case Drinks.Fanta:
                    drinksPrice = 2;
                    break;
                case Drinks.Coffee:
                    drinksPrice = 3;
                    break;
                default:
                    throw new Exception("Drinks code not found");

            }

            int freePizza = pizzaCount / 5;

            var pizzaSum = pizzaPrice * (pizzaCount - freePizza);
            var drinksSum = drinksPrice > 2 && drinksCount > 3 ? drinksPrice * drinksCount * 0.85 : drinksPrice * drinksCount;
            var totalSum = pizzaSum + drinksSum;
            var totalPrice = totalSum > 50 ? totalSum * 0.8 : totalSum;
            totalPrice = Math.Round(totalPrice, 2);

            Console.WriteLine($"{pizza} - {pizzaCount} - {pizzaSum}$");
            Console.WriteLine($"{drinks} - {drinksCount} - {drinksSum}$");
            Console.WriteLine($"Total price: {totalPrice}$");
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
    }
}