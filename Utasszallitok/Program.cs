namespace Utasszallitok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4

            List<Repulo> Repulok = new();
            foreach (var sor in File.ReadAllLines("utasszallitok.txt").Skip(1))
            {
                Repulok.Add(new Repulo(sor));
            }
            Console.WriteLine($"4.Feladat: \t Adatsorok száma: {Repulok.Count()}");

            //5

            int db = 0;
            foreach (var b in Repulok)
            {
                if (b.Tipus.StartsWith("Boeing"))
                {
                    db++;
                }
            }
            Console.WriteLine($"5.Feladat \t Boeing Típusok száma: {db}");

        }
    }
}
