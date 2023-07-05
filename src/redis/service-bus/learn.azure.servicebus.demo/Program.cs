// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Service Bus Demo!");

Console.WriteLine("Press 1 for Queues.");
Console.WriteLine("Press 2 for Topics.");
var input = Console.ReadLine();

if (input == "1")
{
    QueuesDemo();
}

if (input == "2")
{
    TopicsDemo();
}

void QueuesDemo()
{
    Console.WriteLine("Press S for sending messages.");
    Console.WriteLine("Press R for recieveing messages.");
    var input = Console.ReadLine();

    if (input == "S")
    {

    }

    if (input == "R")
    {

    }
}

void TopicsDemo()
{
    Console.WriteLine("Press S for sending messages.");
    Console.WriteLine("Press R for recieveing messages.");
    var input = Console.ReadLine();

    if (input == "S")
    {

    }

    if (input == "R")
    {

    }
}
