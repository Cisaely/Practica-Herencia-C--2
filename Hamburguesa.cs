using System;

namespace ChimiMiBarriga
{
    public class Hamburguesa
    {
        private string _nombre;
        private string _carne;
        private double _precioBase;
        private string _tipoPan;

        // Adicionales (Máximo 4 para la clase base)
        private string _adicional1Nombre;
        private double _adicional1Precio;

        private string _adicional2Nombre;
        private double _adicional2Precio;

        private string _adicional3Nombre;
        private double _adicional3Precio;

        private string _adicional4Nombre;
        private double _adicional4Precio;

        public Hamburguesa(string nombre, string carne, double precio, string tipoPan)
        {
            this._nombre = nombre;
            this._carne = carne;
            this._precioBase = precio;
            this._tipoPan = tipoPan;
        }

        public void AgregarAdicional1(string nombre, double precio)
        {
            this._adicional1Nombre = nombre;
            this._adicional1Precio = precio;
        }

        public void AgregarAdicional2(string nombre, double precio)
        {
            this._adicional2Nombre = nombre;
            this._adicional2Precio = precio;
        }

        public void AgregarAdicional3(string nombre, double precio)
        {
            this._adicional3Nombre = nombre;
            this._adicional3Precio = precio;
        }

        public void AgregarAdicional4(string nombre, double precio)
        {
            this._adicional4Nombre = nombre;
            this._adicional4Precio = precio;
        }

        public virtual double ItemizarHamburguesa()
        {
            double precioTotal = _precioBase;
            Console.WriteLine($"{_nombre} en {_tipoPan} con {_carne}, precio base: {_precioBase:F2}");

            if (!string.IsNullOrEmpty(_adicional1Nombre))
            {
                precioTotal += _adicional1Precio;
                Console.WriteLine($"Agregado: {_adicional1Nombre} por un precio de: {_adicional1Precio:F2}");
            }
            if (!string.IsNullOrEmpty(_adicional2Nombre))
            {
                precioTotal += _adicional2Precio;
                Console.WriteLine($"Agregado: {_adicional2Nombre} por un precio de: {_adicional2Precio:F2}");
            }
            if (!string.IsNullOrEmpty(_adicional3Nombre))
            {
                precioTotal += _adicional3Precio;
                Console.WriteLine($"Agregado: {_adicional3Nombre} por un precio de: {_adicional3Precio:F2}");
            }
            if (!string.IsNullOrEmpty(_adicional4Nombre))
            {
                precioTotal += _adicional4Precio;
                Console.WriteLine($"Agregado: {_adicional4Nombre} por un precio de: {_adicional4Precio:F2}");
            }

            return precioTotal;
        }
    }
}
