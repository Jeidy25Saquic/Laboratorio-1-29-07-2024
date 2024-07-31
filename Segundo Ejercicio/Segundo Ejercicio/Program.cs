using Segundo_Ejercicio;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{


    static void Main(string[] args)
    {


        bool continuar = true;
        int opcion = 0, stock=0;
        double precio = 0;
        string nombreProducto="";
        int cantidad = 0;
        Producto producto = new Producto();
  

        do
        {
            try
            {
                Console.WriteLine(" Tienda");
                Console.WriteLine("1. Ingresar producto");
                Console.WriteLine("2. Mostrar producto ");
                Console.WriteLine("3. Vender Producto");
                Console.WriteLine("4. Restablecer stock");


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
                         
                        Console.Write("Nombre del poroducto:");
                        nombreProducto = Console.ReadLine().ToLower();
                        Console.Write("Precio: ");
                        precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Stock: ");
                        stock = Convert.ToInt32(Console.ReadLine());
                        producto = new Producto(nombreProducto, precio,stock); ;

                        break;
                    case 2:
                        Console.WriteLine("Ingres el nombre del producto que busca ");
                        string nombre=Console.ReadLine();
                        producto.Consultar(nombre);
                        break;
                    case 3:

                        Console.Write("Ingres el nombre del producto que busca: ");
                         nombreProducto = Console.ReadLine().ToLower();
                        Console.Write("Ingres la cantidad: ");
                        cantidad = Convert.ToInt32(Console.ReadLine());
                        producto.VentaProducto(nombreProducto,cantidad);
                        break;
                    case 4:
                        Console.Write("Ingres el nombre del producto: ");
                        nombreProducto = Console.ReadLine().ToLower();
                        Console.Write("Ingres la cantidad: ");
                         cantidad = Convert.ToInt32(Console.ReadLine());
                        producto.RestablecerProducto(nombreProducto, cantidad);


                        break;

                        case 5:
                        Console.Write("Ingres el nombre del producto: ");
                        nombreProducto = Console.ReadLine().ToLower();
                        Console.Write("Ingres la cantidad: ");
                         double precioNuevo = Convert.ToDouble(Console.ReadLine());
                        producto.RestablecerPrecio(nombreProducto, precioNuevo);
                        break;
                        case 6:
                        continuar = false;
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