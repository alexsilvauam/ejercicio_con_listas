using System;
using System.Collections.Generic;

namespace Ejercicios_Listas
{
    public class Ejercicios_1_2_3
    {
        public static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Gestión de Inventario");
                Console.WriteLine("2. Gestión de Cuenta Bancaria");
                Console.WriteLine("3. Diccionario Inglés-Español");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        GestionInventario();
                        break;
                    case 2:
                        GestionCuentaBancaria();
                        break;
                    case 3:
                        List<Tuple<string, string>> diccionario = CrearDiccionario();
                        Traducir(diccionario);
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        // Ejercicio 1: Gestión de Inventario
        public static void GestionInventario()
        {
            List<Producto> inventario = new List<Producto>();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú de Inventario:");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Modificar producto");
                Console.WriteLine("4. Consultar producto");
                Console.WriteLine("5. Mostrar todos los productos");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarProducto(inventario);
                        break;
                    case 2:
                        EliminarProducto(inventario);
                        break;
                    case 3:
                        ModificarProducto(inventario);
                        break;
                    case 4:
                        ConsultarProducto(inventario);
                        break;
                    case 5:
                        MostrarProductos(inventario);
                        break;
                    case 6:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void AgregarProducto(List<Producto> inventario)
        {
            Console.Write("Ingrese el código del producto: ");
            string codigo = Console.ReadLine();
            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Producto producto = new Producto()
            {
                Codigo = codigo,
                Nombre = nombre,
                Cantidad = cantidad,
                Precio = precio
            };

            inventario.Add(producto);
            Console.WriteLine("Producto agregado correctamente.");

            Console.ReadKey();
            Console.Clear();
        }

        public static void EliminarProducto(List<Producto> inventario)
        {
            Console.Write("Ingrese el código del producto a eliminar: ");
            string codigo = Console.ReadLine();

            Producto producto = inventario.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                inventario.Remove(producto);
                Console.WriteLine("Producto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void ModificarProducto(List<Producto> inventario)
        {
            Console.Write("Ingrese el código del producto a modificar: ");
            string codigo = Console.ReadLine();

            Producto producto = inventario.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                Console.Write("Ingrese el nuevo nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la nueva cantidad del producto: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nuevo precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                producto.Nombre = nombre;
                producto.Cantidad = cantidad;
                producto.Precio = precio;

                Console.WriteLine("Producto modificado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void ConsultarProducto(List<Producto> inventario)
        {
            Console.Write("Ingrese el código del producto a consultar: ");
            string codigo = Console.ReadLine();

            Producto producto = inventario.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                Console.WriteLine($"Código: {producto.Codigo}");
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Cantidad: {producto.Cantidad}");
                Console.WriteLine($"Precio: {producto.Precio}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarProductos(List<Producto> inventario)
        {
            foreach (Producto producto in inventario)
            {
                Console.WriteLine($"Código: {producto.Codigo}");
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Cantidad: {producto.Cantidad}");
                Console.WriteLine($"Precio: {producto.Precio}");
                Console.WriteLine("-------------------------");
            }

            Console.ReadKey();
            Console.Clear();
        }

        // Ejercicio 2: Gestión de Cuenta Bancaria
        public static void GestionCuentaBancaria()
        {
            decimal saldo = 0;
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú de Cuenta Bancaria:");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ConsultarSaldo(saldo);
                        break;
                    case 2:
                        DepositarDinero(ref saldo);
                        break;
                    case 3:
                        RetirarDinero(ref saldo);
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ConsultarSaldo(decimal saldo)
        {
            Console.WriteLine($"Saldo actual: {saldo}");

            Console.ReadKey();
            Console.Clear();
        }

        public static void DepositarDinero(ref decimal saldo)
        {
            Console.Write("Ingrese la cantidad a depositar: ");
            decimal deposito = decimal.Parse(Console.ReadLine());
            saldo += deposito;
            Console.WriteLine("Depósito realizado.");

            Console.ReadKey();
            Console.Clear();
        }

        public static void RetirarDinero(ref decimal saldo)
        {
            Console.Write("Ingrese la cantidad a retirar: ");
            decimal retiro = decimal.Parse(Console.ReadLine());
            if (retiro <= saldo)
            {
                saldo -= retiro;
                Console.WriteLine("Retiro realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        // Ejercicio 3: Diccionario Inglés-Español        
        public static List<Tuple<string, string>> CrearDiccionario()
        {
            List<Tuple<string, string>> diccionario = new List<Tuple<string, string>>();
            Console.ReadKey();
            Console.Clear();
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese la palabra {i + 1} en inglés: ");
                string pal1 = Console.ReadLine();
                Console.Write($"Ingrese la palabra {i + 1} en español: ");
                string pal2 = Console.ReadLine();
                diccionario.Add(new Tuple<string, string>(pal1, pal2));
            }
            return diccionario;
        }

        public static void Traducir(List<Tuple<string, string>> diccionario)
        {
            Console.Write("Ingrese la palabra a traducir: ");
            string clave = Console.ReadLine();
            bool encontrado = false;

            foreach (var duo in diccionario)
            {
                if (duo.Item1.Equals(clave, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"La traducción de la palabra {clave} es: {duo.Item2}.");
                    encontrado = true;
                    break;
                }
                else 
                if (duo.Item2.Equals(clave, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"La traducción de la palabra {clave} es: {duo.Item1}.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"La palabra {clave} no se encontró.");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }

    public class Producto
    {
        public string Codigo;
        public string Nombre;
        public int Cantidad;
        public decimal Precio;
    }
}
