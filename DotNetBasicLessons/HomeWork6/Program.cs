/*try
{
    Console.WriteLine("Enter the profit for each month separately:");

    int[] profit = new int[6];

    for (int i = 0; i < profit.Length; i++)
    {
        profit[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"The company's profit for 6 months: {profit.Sum()}");
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
    Console.WriteLine("Enter the profit for each month separately:");

    int[] profit = new int[12];

    for (int i = 0; i < profit.Length; i++)
    {

        profit[i] = Convert.ToInt32(Console.ReadLine());

    }

    var min = profit.Min();
    var max = profit.Max();

    for (int i = 0; i < profit.Length; i++)
    {
        if (profit[i] == min)
        {
            Console.WriteLine($"The profit was minimal in month: {i + 1}, minimal profit: {min}");
        }

        if (profit[i] == max)
        {
            Console.WriteLine($"The profit was maximal in month: {i + 1}, maximal profit: {max}");
        }
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
*/

try
{
    const int arrSize = 4;
    var matrix = new int[arrSize, arrSize];
    var rnd = new Random();
    int sum = 0;

    for (int i = 0; i < arrSize; i++)
    {

        for (int j = 0; j < arrSize; j++)
            matrix[i, j] = rnd.Next(1, 100);
    }

    for (int i = 0; i < arrSize; i++)
    {

        for (int j = 0; j < arrSize; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine("\n");
    }
    for (int i = 0; i < arrSize; i++)
    {
        sum += matrix[i, i];
    }
    Console.WriteLine($"The sum of the numbers of the main diagonal of the matrix: {sum}");
    var arrayDiagonale = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        var item = matrix[arrSize - i - 1, i];
        arrayDiagonale[i] = item;
    }
    var min = arrayDiagonale.Min();
    var max = arrayDiagonale.Max();
    Console.WriteLine($"The minimum value of the side diagonal of the matrix: {min}");
    Console.WriteLine($"The maximum value of the side diagonal of the matrix: {max}");

    Console.WriteLine("Enter the column number: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Numbers from {column} column: ");
    for (int i = 0; i < arrSize; i++)
    {
        var item = matrix[i, column - 1];
        Console.Write($"{item} \t");
    }
    Console.WriteLine("\n");
    Console.WriteLine("Enter the row number: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Numbers from {row} row: ");
    for (int i = 0; i < arrSize; i++)
    {
        var item = matrix[row - 1, i];
        Console.Write($"{item} \t");
    }
    Console.WriteLine("\n");

    Console.WriteLine("Enter the column number: ");
    int column1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the column number: ");
    int column2 = Convert.ToInt32(Console.ReadLine());
    var columnArray = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        var item = matrix[i, column1 - 1];
        columnArray[i] = item;
    }
    for (int i = 0; i < arrSize; i++)
    {
        var item = matrix[i, column2 - 1];
        matrix[i, column1 - 1] = item;
        matrix[i, column2 - 1] = columnArray[i];
    }

    for (int i = 0; i < arrSize; i++)
    {

        for (int j = 0; j < arrSize; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine("\n");
    }


    Console.WriteLine("Enter the row number: ");
    int row1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the row number: ");
    int row2 = Convert.ToInt32(Console.ReadLine());
    var rowArray = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        var item = matrix[row1 - 1, i];
        rowArray[i] = item;
    }
    for (int i = 0; i < arrSize; i++)
    {
        var item = matrix[row2 - 1, i];
        matrix[row1 - 1, i] = item;
        matrix[row2 - 1, i] = rowArray[i];
    }

    for (int i = 0; i < arrSize; i++)
    {

        for (int j = 0; j < arrSize; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine("\n");
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
