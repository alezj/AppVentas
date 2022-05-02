using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas
{
    public class HorasEmpleado : Empleados
    {
        public float Horas { get; set; }

        public decimal ValorHoras { get; set; }
        public override decimal GetValueToPay()
        {
            return(decimal)Horas * ValorHoras;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Horas.................: {$"{Horas:N2}",15}" +
                $"\n\t Valar de hora.........: {$"{ValorHoras:C2}",15}" +
                $"\n\t Value to pay..........: {$"{GetValueToPay():C2}",15}";
        }
    }
}
