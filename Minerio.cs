public class Minerio
{
    public long Codigo { get; set; }
    public string Nome { get; set; }    

    public static IEnumerable<Minerio> Mineirar(int quantidade)
    {
        int cont = 1;

        var minerios = new List<Minerio>(quantidade);

        do
        {
            minerios.Add(new Minerio()
            {
                Codigo = cont,
                Nome = cont == 569_754 ? "Ouro" : "Ferro"
            });

            cont++;
        }
        while (cont <= quantidade);

        return minerios;
    }

    public static IEnumerable<Minerio> MineirarComYield(int quantidade)
    {
        int cont = 1;

        while (true)
        {
            yield return new Minerio()
            {
                Codigo = cont,
                Nome = cont == 569_754 ? "Ouro" : "Ferro"
            };

            cont++;

            if (cont > quantidade)
            {
                yield break;
            }
        }
    }
}