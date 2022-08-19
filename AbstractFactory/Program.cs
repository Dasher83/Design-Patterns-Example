using AbstractFactory;
using AbstractFactory.Models.Factories;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Client: Testing client code with the ArtDeco furniture factory...");
Client client = new Client();
client.ClientMethod(new ArtDecoFurnitureFactory());
Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Client: Testing client code with the Modern furniture factory...");
client.ClientMethod(new ModernFurnitureFactory());
Console.ResetColor();
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Client: Testing client code with the Victorian furniture factory...");
client.ClientMethod(new VictorianFurnitureFactory());
Console.ResetColor();
Console.WriteLine();
