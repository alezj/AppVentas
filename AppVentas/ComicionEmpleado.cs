using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas
{
    public class ComicionEmpleado : Empleados
    {
        public float PorcentajeComocion  { get; set; }

        public decimal Ventas { get; set; }
        public override decimal GetValueToPay()
        {
            return Ventas * (decimal)PorcentajeComocion;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Porsentaje de comicion: {$"{PorcentajeComocion:P2}",15}" +
                $"\n\t Ventas................: {$"{Ventas:C2}",15}" +
                $"\n\t Value to pay..........: {$"{GetValueToPay():C2}",15}";
        }
    }
}
