internal class Program
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user : " + X);
        }
    }

    class DataGeneric
    {
        public static void PrintData<T>(T Y)
        {
            Console.WriteLine("Data yang tersimpan adalah : " + Y);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Hermawan");
        DataGeneric.PrintData<string>("1302213080");
    }
}