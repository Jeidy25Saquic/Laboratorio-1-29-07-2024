using Segundo_Ejercicio;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{


    static void Main(string[] args)
    {


        bool continuar = true;
        int opcion = 0, precio=0, stock=0;
        string nombreProducto="";
        Producto producto = new Producto();


        do
        {
            try
            {
                Console.WriteLine(" Tienda");
                Console.WriteLine("1. Ingresar producto");
                Console.WriteLine("2.Mostrar producto ");
                Console.WriteLine("3. Vender Producto");
                Console.WriteLine("4. Restablecer");

                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Valor no esta en el rango...")
                        ; Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:
                        
                        Console.WriteLine("Nombre del poroducto");
                        nombreProducto = Console.ReadLine().ToLower();
                        Console.WriteLine("Precio");
                        precio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Stock: ");
                        stock = Convert.ToInt32(Console.ReadLine());
                        producto = new Producto(nombreProducto, precio,stock); ;

                        break;
                    case 2:
                        Console.WriteLine("Ingres el nombre del producto que busca ");
                        string nombre=Console.ReadLine();
                        producto.Consultar(nombre);
                        break;
                    case 3:

                        Console.WriteLine("Ingres el nombre del producto que busca ");
                        string NombreProducto = Console.ReadLine().ToLower();
                        Console.WriteLine("Ingres la cantidad ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        producto.VentaProducto(NombreProducto,cantidad);
                        break;
                    case 4:

                        
                        break;


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error... " + ex.Message);

            }


        } while (continuar == true);


    }
}