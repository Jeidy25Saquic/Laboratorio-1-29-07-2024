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
       Producto producto = new Producto(nombreProducto, precio, stock);
        do
        {
            try
            {
                Console.WriteLine(" Tienda");
                Console.WriteLine("1. Ingresar producto");
                Console.WriteLine("2.Mostrar pRODUCTO ");
           
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
                        nombreProducto = Console.ReadLine();
                        Console.WriteLine("Precio");
                        precio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Stock: ");
                        stock = Convert.ToInt32(Console.ReadLine());
                       


                        break;
                    case 2:
                        Console.WriteLine("Ingres el nombre del producto que busca ");
                        string nombre=Console.ReadLine();
                        producto.Consultar(nombre);
                        break;
                    case 3:
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