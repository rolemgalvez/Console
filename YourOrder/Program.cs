// Welcome User 
Console.WriteLine("==========");
Console.WriteLine("YOUR ORDER");
Console.WriteLine("==========");

// Ask user order
Console.WriteLine();
Console.Write("Thank for waiting. What is your order: ");
string order = Console.ReadLine();
Console.WriteLine();

// Response to the order
Console.WriteLine("Your order is " + order + ".");
Console.WriteLine();
Console.WriteLine("Ow! We don't sell that here.");
Console.WriteLine("Try again next time.");
Console.ReadLine();