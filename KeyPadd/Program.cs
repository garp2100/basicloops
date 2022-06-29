//door keypad entry exercise using while loop
//int tries = 0;
//while (true)
//{
//    Console.WriteLine("Please enter keypad code to open door: ");
//    int input = int.Parse(Console.ReadLine());
//    if (input == 13579)
//    {
//        Console.WriteLine("Door unlocked");
//        break;
//    }
//    else if (++tries < 5) //postfix increment
//    {
//        Console.WriteLine("you got the wrong code");
//        Console.WriteLine("Please try again");
//    }
//    else
//    {
//        Console.WriteLine("too many tries, please try again later");
//        break;
//    }
//}

//door keypad entry exercise using do while loop
int tries = 0;
do
{
    Console.WriteLine("Please enter keypad code to open door: ");
    int input = int.Parse(Console.ReadLine());
    if (input == 13579)
    {
        Console.WriteLine("Door unlocked");
        break;
    }
    else if (++tries < 5) //postfix increment
    {
        Console.WriteLine("you got the wrong code");
        Console.WriteLine("Please try again");
    }
    else
    {
        Console.WriteLine("too many tries, please try again later");
        break;
    }
}
while (tries < 5);
