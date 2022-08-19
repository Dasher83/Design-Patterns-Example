using Adapter;

RoundHole roundHole = new RoundHole(5);
RoundPeg roundPeg = new RoundPeg(5);
Console.WriteLine(roundHole.Fits(roundPeg)); // Should print True

SquarePeg smallSquarePeg = new SquarePeg(5);
SquarePeg largeSquarePeg = new SquarePeg(10);
/*roundHole.Fits(smallSquaredPeg);*/ // this won't compile (incompatible types)

SquarePegAdapter smallSquarePegAdapter = new SquarePegAdapter(smallSquarePeg);
SquarePegAdapter largeSquarePegAdapter = new SquarePegAdapter(largeSquarePeg);
Console.WriteLine(roundHole.Fits(smallSquarePegAdapter)); // Should print True
Console.WriteLine(roundHole.Fits(largeSquarePegAdapter)); // Should print False