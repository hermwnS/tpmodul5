internal class Program
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T X)
        {
            Console.WriteLine("Halo user : " + X);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Hermawan");
    }
}