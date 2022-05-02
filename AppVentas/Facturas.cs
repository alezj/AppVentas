namespace AppVentas
{
    public class Facturas : IPay
    {
        public int IDFactura { get; set; }

        public string DescripcionFactura { get; set; }

        public float Catidad { get; set; }

        public decimal Precios { get; set; }

        public decimal GetValueToPay()
        {
            return Precios * (decimal)Catidad;
        }

        public override string ToString()
        {
            return $"{IDFactura} - {DescripcionFactura}" +
                $"\n\tCantidad..........:{$"{Catidad:N2}",18}" +
                $"\n\tPrecio............:{$"{Precios:C2}",18}" +
                $"\n\tValor.............:{$"{GetValueToPay():C2}",18}";
        }
    }
}
