using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas
{
  public  class BaseComicionEmpleado : ComicionEmpleado
    {
        public decimal Base  { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Base..................: {$"{Base:C2}",15}";
        }
    }
}
