using System;

namespace AppVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("~~~~~~~~~~~");
            Empleados empleados1 = new SalaryEmpleado()

            {
                ID = 1,
                FirstName = "Juan",
                LastName = "Pablo",
                BirthDate = new Date (1990, 5 , 23),
                HiringDate = new Date (2021, 1, 15),
                IsActive = true,
                salary = 145300.50M

            };
            Console.WriteLine(empleados1);

            Empleados empleados2 = new ComicionEmpleado()

            {
                ID = 2,
                FirstName = "Patricia",
                LastName = "Gutiere",
                BirthDate = new Date(1994, 5, 23),
                HiringDate = new Date(2021, 5, 30),
                IsActive = true,
                Ventas = 320000000M,
                PorcentajeComocion = 0.03F

            };
            Console.WriteLine(empleados2);


            //try
            //{
            //    Console.WriteLine(new Date(2022, 12, 7));
            //    Console.WriteLine(new Date(1974, 9, 23));
            //    Console.WriteLine(new Date(1985, 11, 45));
            //}
            //catch (Exception Error )
            //{
            //    Console.WriteLine(Error.Message);

            //}


        }
    }
}
