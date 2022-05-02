using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
            //Console.WriteLine(empleados1);

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
            //Console.WriteLine(empleados2);

            Empleados empleados3 = new HorasEmpleado()

            {
                ID = 3,
                FirstName = "Carlos",
                LastName = "peres",
                BirthDate = new Date(1992, 8, 13),
                HiringDate = new Date(2020, 5, 30),
                IsActive = true,
                Horas = 123.5F,
                ValorHoras = 62.56M

            };
           // Console.WriteLine(empleados3);

            Empleados empleados4 = new BaseComicionEmpleado()

            {
                ID = 4,
                FirstName = "Elsa",
                LastName = "lami",
                BirthDate = new Date(1993, 10, 13),
                HiringDate = new Date(2019, 12, 30),
                IsActive = true,
                Base = 800.00M,
                Ventas = 100000000M,
                PorcentajeComocion = 0.015F

            };
            //  Console.WriteLine(empleados4);

            ICollection<Empleados> listaemplados = new List<Empleados>()
            {
                empleados1,empleados2,empleados3,empleados4
            };

            decimal lineapay = 0;

            foreach(Empleados empleados in listaemplados)
            {
                Console.WriteLine(empleados);
                lineapay += empleados.GetValueToPay();
            }
            Console.WriteLine("                     ===========================");
            Console.WriteLine($"Total                            {$"{lineapay:C2}",15}");

            Facturas facturas1 = new Facturas()
            {
                DescripcionFactura = "Iphone 13",
                IDFactura = 1,
                Precios = 54000M,
                Catidad = 3
            };
            Facturas facturas2 = new Facturas()
            {
                DescripcionFactura = "IPosta Preum",
                IDFactura = 2,
                Precios = 450M,
                Catidad = 17.5F
            };

            Console.WriteLine(facturas1);
            Console.WriteLine(facturas2);
        }
    }
}
