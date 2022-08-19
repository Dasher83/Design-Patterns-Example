using Prototype;

Person original = new Person(
    age: 42, birthDate: Convert.ToDateTime("1977-01-01"),
    name: "Jack Daniels", idInfo: new IdInfo(666));

Person shallowClone = original.ShallowCopy();
Person deepClone = original.DeepCopy();

Console.WriteLine("Original values of instances: original, shallowClone, deepClone");
Console.WriteLine("Original instance values: ");
Display.DisplayState(original);
Console.WriteLine("Shallow clone instance values:");
Display.DisplayState(shallowClone);
Console.WriteLine("Deep clone instance values:");
Display.DisplayState(deepClone);

// Change the value of p1 properties and display the values of p1,
// p2 and p3.
original.Age = 32;
original.BirthDate = Convert.ToDateTime("1900-01-01");
original.Name = "Frank";
original.IdInfo.IdNumber = 7878;

Console.WriteLine();
Console.WriteLine("New values of instances: original, shallowClone, deepClone");
Console.WriteLine("Original instance values: ");
Display.DisplayState(original);
Console.WriteLine("Shallow clone instance values (reference values have changed):");
Display.DisplayState(shallowClone);
Console.WriteLine("Deep clone instance values (everything was kept the same):");
Display.DisplayState(deepClone);
