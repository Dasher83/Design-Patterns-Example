using Flyweight.DTOs;
using Flyweight.Factories;
using Flyweight.Models;
using Flyweight.Utils;

static void AddCarToPoliceDatabase(CarTypeFactory factory, CarTypeDTO carTypeDTO, CarDistinctions carDistinctions)
{
    Console.ForegroundColor = RandomConsoleColorPicker.Pick;
    Console.WriteLine("\nClient: Adding a car to database.");
    CarType carType = factory.GetCarType(carTypeDTO: carTypeDTO);
    Car car = new Car(carType, carDistinctions);
    car.PrintInfo();
    Console.ResetColor();
    Console.WriteLine();
}

var factory = new CarTypeFactory(
    keyGenerator: new CarTypeKeyGenerator(),
    new CarType(company:"Chevrolet", model:"Camaro2018", color:"pink"),
    new CarType(company:"Mercedes Benz", model:"C300", color:"black"),
    new CarType(company:"Mercedes Benz", model:"C500", color:"red"),
    new CarType(company:"BMW", model:"M5", color:"red"),
    new CarType(company:"BMW", model:"X6", color:"white")
);
factory.ListCarTypeFlyweights();
CarTypeDTO carTypeDTO = new CarTypeDTO(company: "BMW", model: "M5", color: "red");
CarDistinctions carDistinctions = new CarDistinctions(owner: "James Doe", number: "CL234IR");
AddCarToPoliceDatabase(factory, carTypeDTO, carDistinctions);
carTypeDTO = new CarTypeDTO(company: "BMW", model: "X1", color: "red");
carDistinctions = new CarDistinctions(owner: "James Doe", number: "CL234IR");
AddCarToPoliceDatabase(factory, carTypeDTO, carDistinctions);
factory.ListCarTypeFlyweights();
Console.WriteLine();
Console.ResetColor();
