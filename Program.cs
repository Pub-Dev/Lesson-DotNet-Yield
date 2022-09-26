using BenchmarkDotNet.Running;

var minerios = Minerio.Mineirar(1_000_000);

foreach (var minerio in minerios)
{
    if (minerio.Nome == "Ouro")
    {
        Console.WriteLine($"Achamos 🥇, estamos ricos!");
        break;
    }
}

var mineriosComYield = Minerio.MineirarComYield(1_000_000);

foreach (var minerio in mineriosComYield)
{
    if (minerio.Nome == "Ouro")
    {
        Console.WriteLine($"Achamos 🥇, estamos ricos!");
        break;
    }
}

// var summary = BenchmarkRunner.Run<BenchmarksYield>();
