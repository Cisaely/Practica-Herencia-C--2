using System;

namespace ChimiMiBarriga
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== BIENVENIDO A CHIMI MIBARRIGA DEL SR. BILLY NAVAJA ===");
                Console.WriteLine("Por favor, seleccione el tipo de hamburguesa:");
                Console.WriteLine("1. Clásica (Pan Blanco, Res, hasta 4 adicionales)");
                Console.WriteLine("2. Saludable (Pan Integral, hasta 6 adicionales)");
                Console.WriteLine("3. Premium (Papas y Bebida incluidos, no permite adicionales)");
                Console.WriteLine("0. Salir");
                Console.Write("\nSelección: ");

                string input = Console.ReadLine();
                if (input == "0") break;

                Hamburguesa miPedido = null;

                switch (input)
                {
                    case "1":
                        miPedido = new Hamburguesa("Clásica", "Res", 50.00, "Pan Blanco");
                        ConfigurarHamburguesa(miPedido, 4);
                        break;
                    case "2":
                        miPedido = new HamburguesaSaludable("Pavo", 60.00);
                        ConfigurarHamburguesa(miPedido, 6);
                        break;
                    case "3":
                        miPedido = new HamburguesaPremium();
                        Console.WriteLine("\n[INFO] La Hamburguesa Premium ya incluye Papas y Bebida.");
                        break;
                    default:
                        Console.WriteLine("Selección inválida. Presione una tecla para reintentar...");
                        Console.ReadKey();
                        continue;
                }

                // Mostrar resultado final usando el método polimórfico
                Console.WriteLine("\n------- TU RECIBO -------");
                double total = miPedido.ItemizarHamburguesa();
                Console.WriteLine("-------------------------");
                Console.WriteLine($"TOTAL FINAL: ${total:F2}");
                Console.WriteLine("\nPresione cualquier tecla para realizar otro pedido...");
                Console.ReadKey();
            }
        }

        static void ConfigurarHamburguesa(Hamburguesa h, int limite)
        {
            Console.WriteLine("\n--- Configurando Adicionales ---");
            Console.WriteLine("Disponibles: 1. Lechuga ($5), 2. Tomate ($5), 3. Bacon ($15), 4. Queso ($10), 5. Huevo ($10)");
            Console.WriteLine("Escriba el número del ingrediente (o 'fin' para terminar):");

            for (int i = 1; i <= limite; i++)
            {
                Console.Write($"Ingrediente {i}/{limite}: ");
                string adj = Console.ReadLine().ToLower();
                if (adj == "fin") break;

                string nombre = "";
                double precio = 0;

                switch (adj)
                {
                    case "1": nombre = "Lechuga"; precio = 5.00; break;
                    case "2": nombre = "Tomate"; precio = 5.00; break;
                    case "3": nombre = "Bacon"; precio = 15.00; break;
                    case "4": nombre = "Queso"; precio = 10.00; break;
                    case "5": nombre = "Huevo"; precio = 10.00; break;
                    default:
                        Console.WriteLine("Número inválido, saltando...");
                        continue;
                }

                // Aquí aplicamos la lógica de herencia:
                // Los adicionales 1-4 están en la clase base.
                // Los 5-6 están en la clase Saludable.
                if (i == 1) h.AgregarAdicional1(nombre, precio);
                else if (i == 2) h.AgregarAdicional2(nombre, precio);
                else if (i == 3) h.AgregarAdicional3(nombre, precio);
                else if (i == 4) h.AgregarAdicional4(nombre, precio);
                else if (i == 5 && h is HamburguesaSaludable hs5) hs5.AgregarAdicional5(nombre, precio);
                else if (i == 6 && h is HamburguesaSaludable hs6) hs6.AgregarAdicional6(nombre, precio);
            }
        }
    }
}
Console.ReadLine();
