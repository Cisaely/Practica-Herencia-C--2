using System;

namespace ChimiMiBarriga
{
    public class HamburguesaSaludable : Hamburguesa
    {
        private string _adicional5Nombre;
        private double _adicional5Precio;

        private string _adicional6Nombre;
        private double _adicional6Precio;

        public HamburguesaSaludable(string carne, double precio) 
            : base("Hamburguesa Saludable", carne, precio, "Pan Integral")
        {
        }

        public void AgregarAdicional5(string nombre, double precio)
        {
            this._adicional5Nombre = nombre;
            this._adicional5Precio = precio;
        }

        public void AgregarAdicional6(string nombre, double precio)
        {
            this._adicional6Nombre = nombre;
            this._adicional6Precio = precio;
        }

        public override double ItemizarHamburguesa()
        {
            // Primero llamamos al método base para obtener el total parcial
            // y mostrar los 4 primeros ingredientes.
            double precioParcial = base.ItemizarHamburguesa();

            if (!string.IsNullOrEmpty(_adicional5Nombre))
            {
                precioParcial += _adicional5Precio;
                Console.WriteLine($"Agregado: {_adicional5Nombre} por un precio de: {_adicional5Precio:F2}");
            }
            if (!string.IsNullOrEmpty(_adicional6Nombre))
            {
                precioParcial += _adicional6Precio;
                Console.WriteLine($"Agregado: {_adicional6Nombre} por un precio de: {_adicional6Precio:F2}");
            }

            return precioParcial;
        }
    }
}
