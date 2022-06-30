//Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!" ask the user whether they would like to continue.
//while (true)
//{
//    Console.WriteLine("Hello World! Would you like to continue? y/n.");
//    string restartValue = Console.ReadLine().ToLower();
//    if (restartValue == "y")
//        continue;
//    else
//        Console.WriteLine("Goodbye!");
//    break;
//}

//Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. After that loop finishes, use another loop to output all the numbers from 0 to that number.
while (true)
{
    Console.WriteLine("Please enter a number: ");
    int input = int.Parse(Console.ReadLine());
    for (int i = 0; i < input; i++)
    {
        Console.Write(i+ "\n");
    }

    for (int j = input; j > 0; j--)
    {
        Console.Write(j + "\n");
    }

    while (true)
    {
        Console.WriteLine("Would you like to restart? y/n.");
        string restartValue = Console.ReadLine().ToLower();
        if (restartValue == "y")
            break;
        else
            Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
}

