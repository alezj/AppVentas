using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas
{
    public abstract class  Empleados : IPay
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public String LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"\n {ID} - {FirstName} {LastName}, " +
                $"Brith {BirthDate}, " +
                $"Hiring {HiringDate}," +
                $"Is Active: {IsActive}";
        }

    }

}
