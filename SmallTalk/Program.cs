// Welcome User
Console.WriteLine("Welcome to Small Talk");
Console.WriteLine("Given by Somebody");
Console.WriteLine("-----------------------");

// Ask user first name
Console.WriteLine();
Console.WriteLine("I have something to tell you.");
Console.Write("Before that, tell me your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine();

// Ask user last name
Console.Write("How about your last name: ");
string lastName = Console.ReadLine();
Console.WriteLine();

// Tell user something
Console.WriteLine("Okay " + firstName + " " + lastName + ".");
Console.WriteLine("Here's the thing, nobody will save you. So better do the work!");
Console.WriteLine();

// Say goodbye to user
Console.WriteLine("Hope it helps.");
Console.WriteLine("Until next time, Adios!");
Console.ReadLine();