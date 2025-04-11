using Dominio;
namespace Obligatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema unS = Sistema.Instancia;
            int opcion = 0;
            // menu
            string[] opciones = { "Lista 1", "Lista2 2", "Lista 3", "Lista 4" };
            // solicita numeros hasta que se ponga 0
            do
            {
                Menu(opciones);
                opcion = PedirNumero("Opcion");
                switch (opcion)
                {
                    case 1:
                        // Listado de todos los clientes
                        Console.WriteLine("Listado1");
                        break;
                    case 2:
                        // Listar vuelos
                        Console.WriteLine("Listado2");

                        break;
                    case 3:
                        // Alta cliente ocasionales
                        Console.WriteLine("Listado3");

                        break;
                    case 4:
                        //Filtro pasajes
                        Console.WriteLine("Listado4");

                        break;
                }
                if (opcion != 0)
                {
                    Console.Write("Cualquier tecla para seguir...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        static public void Menu(string[] opciones)
        {
            Console.Clear();
            int numero = 1;
            Console.WriteLine("Ingresa una de las siguientes opciones (0 para finalizar)");
            foreach (string opcion in opciones)
            {
                Console.WriteLine(numero + " - " + opcion);
                numero++;
            }
        }

        static public int PedirNumero(string mensaje = "Ingrese número.")
        {
            int numero;
            bool exito;
            do
            {
                exito = int.TryParse(Console.ReadLine(), out numero);
                if (!exito)
                {
                    MensajeError("Debe escribir solo numeros.");
                }
            } while (!exito);

            return numero;
        }
        static public void MensajeError(string mensaje)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"---Error----> {mensaje}");
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
