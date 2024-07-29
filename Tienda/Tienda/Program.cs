class Program
{
    static List<string> productos = new List<string>();
    static List<double>  precios = new List<double>();

    static void Main(string[] args)
    {
        
        bool continuar = true;
        int opcion = 0;
        do
        {
            try
            {
                Console.WriteLine(" Tienda");
                Console.WriteLine("1. Ingresar producto");
                Console.WriteLine("2.Conteo de productos");
                Console.WriteLine("3. total de la compra");
                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Valor no esta en el rango...")
                        ; Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } 
                switch(opcion)
                {
                    case 1:
                        IngresarProducto();
                        break;
                    case 2:
                        ConteoProductos();
                        break;

                        
                }

                
            }catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error... "+ ex.Message);

            }


        } while (continuar==true);
       



    }


    static void IngresarProducto()
    {
        try
        {
            string nomnreProducto;
            double precioProducto = 0;
            Console.WriteLine("Ingrese el nombre dek Producto");
            nomnreProducto = Console.ReadLine();
            productos.Add(nomnreProducto);
            Console.WriteLine("Ingrse el precio del producto");
            precioProducto = Convert.ToDouble(Console.ReadLine());
            precios.Add(precioProducto);
        }
        catch (Exception ex) { 
            
            Console.WriteLine("Ha ocurrido un error "+ ex.Message);
        
        }

    }

    static void ConteoProductos()
    {
        Console.WriteLine("La cantidad de productos ingresados es: " + productos.Count);

    }





}