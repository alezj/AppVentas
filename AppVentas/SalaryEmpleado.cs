namespace AppVentas
{
    public class SalaryEmpleado : Empleados
    {
        public decimal salary { get; set; }
        public override decimal GetValueToPay()
        {
            return salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Value to pay:.......... {$"{GetValueToPay():C2}",15}";
        }
    }
}
