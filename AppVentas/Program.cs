using System;

namespace AppVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("~~~~~~~~~~~");
            try
            {
                Console.WriteLine(new Date(2022, 12, 7));
                Console.WriteLine(new Date(1974, 9, 23));
                Console.WriteLine(new Date(1985, 11, 45));
            }
            catch (Exception Error )
            {
                Console.WriteLine(Error.Message);
        
            }
        }
    }
}
