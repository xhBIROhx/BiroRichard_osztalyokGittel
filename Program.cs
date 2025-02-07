namespace OOPgyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1 = new("A Kis Herceg", "Antonie de Saint-Exupery", 1943, 96, 2500);
            Konyv konyv2 = new("konyv2", "en");
        
            System.Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

            konyv1.Kedvezmeny(20);
            konyv1.Arnoveles(1000);

            System.Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));
        }
    }
}