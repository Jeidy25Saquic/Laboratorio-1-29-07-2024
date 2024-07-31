﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Ejercicio
{
    public class Producto
    {
        string Name {  get; set; }
        int Precio { get; set; }
        int Stock {  get; set; }
         
        public Producto() { 

        }
        public Producto(string nombre, int precio, int stock) {
            Name = nombre;
            Precio = precio;
            Stock = stock;
           
        }

       
        public void Consultar(string nombre)
        {
            if(nombre!= Name)
            {
                Console.WriteLine("No existe ese producto");
            }
            else
            {
                Console.WriteLine("Nombre del poroducto: "+ Name);
                Console.WriteLine("Precio" + Precio);
                Console.WriteLine("Stock: " + Stock);
            }
        }

        public void VentaProducto(string nombreProducto,int cantidad)

        {
            if (nombreProducto != Name) { Console.WriteLine("No existe el producto"); }
            else
            {
                if (Stock <= 0 || cantidad > Stock)
                {
                    Console.WriteLine("No hay cantidad suficiente de productos");
                }
                else
                {
                    Stock = Stock - cantidad;
                    Console.WriteLine("Se han vendido " + cantidad + " producto/s");
                }
            }

        }




    }
}
