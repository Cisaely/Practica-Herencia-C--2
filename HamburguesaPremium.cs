using System;

namespace ChimiMiBarriga
{
    public class HamburguesaPremium : Hamburguesa
    {
        public HamburguesaPremium() 
            : base("Hamburguesa Premium", "Pechuga y Jamón", 30.0, "Pan Brioche")
        {
            // Agregamos automáticamente los adicionales fijos en la creación
            base.AgregarAdicional1("Papas Fritas", 10.0);
            base.AgregarAdicional2("Bebida", 15.0);
        }

        // Sobrescribimos para prevenir que el usuario agregue otros accesorios
        public new void AgregarAdicional1(string nombre, double precio)
        {
            Console.WriteLine("Acción no permitida: No se pueden agregar ingredientes extras a la Hamburguesa Premium.");
        }

        public new void AgregarAdicional2(string nombre, double precio)
        {
            Console.WriteLine("Acción no permitida: No se pueden agregar ingredientes extras a la Hamburguesa Premium.");
        }

        public new void AgregarAdicional3(string nombre, double precio)
        {
            Console.WriteLine("Acción no permitida: No se pueden agregar ingredientes extras a la Hamburguesa Premium.");
        }

        public new void AgregarAdicional4(string nombre, double precio)
        {
            Console.WriteLine("Acción no permitida: No se pueden agregar ingredientes extras a la Hamburguesa Premium.");
        }
    }
}
