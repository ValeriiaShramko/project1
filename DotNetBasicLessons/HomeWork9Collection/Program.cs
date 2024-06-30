try
{
    List<string> toDoList = new List<string>();

    toDoList.Add("Do homework");
    toDoList.Add("Сook dinner");
    toDoList.Add("Walk with dog");

    foreach (var task in toDoList)
    {
        Console.WriteLine($"{toDoList.IndexOf(task) + 1}. {task}");
    }

    Console.WriteLine("\nEnter number of task:");
    int numberOfTask = Convert.ToInt32(Console.ReadLine());

    int indexOfTask = numberOfTask - 1;

    Console.WriteLine("\nEnter new task:");
    var newTask = Console.ReadLine();


    if (string.IsNullOrEmpty(newTask))
        throw new Exception("Task wasn't added!");

    toDoList[indexOfTask] = newTask;

    Console.WriteLine("\nChanged the to-do list:");

    foreach (var task in toDoList)
    {
        Console.WriteLine($"{toDoList.IndexOf(task) + 1}. {task}");
    }

    Console.WriteLine("\nEnter number of task to delete:");
    int numberOfTaskToDelete = Convert.ToInt32(Console.ReadLine());


    int indexOfTaskToDelete = numberOfTaskToDelete - 1;

    toDoList.RemoveAt(indexOfTaskToDelete);

    Console.WriteLine("\nChanged the to-do list:");

    foreach (var task in toDoList)
    {
        Console.WriteLine($"{toDoList.IndexOf(task) + 1}. {task}");
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
