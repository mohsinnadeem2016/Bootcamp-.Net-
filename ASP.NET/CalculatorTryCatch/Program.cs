int num1 = 10; int num2 = 10;

Console.WriteLine("Calculator with Try Catch\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.Toint32(Console.ReadLine());

Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.Tot32(Console.ReadLine());

Console.WriteLine("Choose an option floatrom the floatollowing list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;

}
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
