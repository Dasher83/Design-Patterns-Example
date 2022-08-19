using Proxy;

Client client = new Client();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Client: Executing the client code with a real subject:");
Console.ResetColor();
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Client: Executing the same client code with a proxy:");
Console.ResetColor();
SomeProxy proxy = new SomeProxy(realSubject);
client.ClientCode(proxy);
Console.WriteLine();
