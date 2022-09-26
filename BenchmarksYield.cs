using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class BenchmarksYield
{
    [Benchmark]
    [Arguments(1_000_000)]
    [Arguments(1_000)]
    public void MineirarSemYield(int count)
    {
        var minerios = Minerio.Mineirar(count);

        foreach (var minerio in minerios)
        {
            if (minerio.Nome == "Ouro")
            {
                Console.WriteLine($"Achamos 🥇, estamos ricos!");
                break;
            }
        }
    }

    [Benchmark]
    [Arguments(1_000_000)]
    [Arguments(1_000)]
    public void MineirarComYield(int count)
    {
        var mineriosComYield = Minerio.MineirarComYield(count);

        foreach (var minerio in mineriosComYield)
        {
            if (minerio.Nome == "Ouro")
            {
                Console.WriteLine($"Achamos 🥇, estamos ricos!");
                break;
            }
        }
    }
}
