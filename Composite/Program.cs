using CompositePattern.Interfaces;
using CompositePattern.Models;

//Creating Leaf Objects
IComponent hardDisk = new Leaf("Hard Disk", 2000);
IComponent ram = new Leaf("RAM", 3000);
IComponent cpu = new Leaf("CPU", 2000);
IComponent mouse = new Leaf("Mouse", 2000);
IComponent keyboard = new Leaf("Keyboard", 2000);

//Creating composite objects
Composite motherBoard = new Composite("Motherboard");
Composite cabinet = new Composite("Cabinet");
Composite peripherals = new Composite("Peripherals");
Composite computer = new Composite("Computer");

//Constructing tree-like structure 
motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);

cabinet.AddComponent(motherBoard);
cabinet.AddComponent(hardDisk);

peripherals.AddComponent(mouse);
peripherals.AddComponent(keyboard);

computer.AddComponent(cabinet);
computer.AddComponent(peripherals);

double computerPrice = computer.Price;
Console.WriteLine($"The price of the whole computer is {computerPrice}");
