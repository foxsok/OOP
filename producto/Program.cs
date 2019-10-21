using System;
using System.Collections.Generic;

namespace producto
{
    
    
    class Producto
    {
    
        public int codigo;
        public string nombre;
        public string descripcion;
        public double precio;
        
      
      public void ingre(int c, string n, string d, double p)
      {
          this.codigo=c;
          this.nombre=n;
          this.descripcion=d;
          this.precio=p;
      }
      public void print()
      {
          Console.WriteLine("Codigo: {0}",codigo);
          Console.WriteLine("Nombre: {0}",nombre);
          Console.WriteLine("Descripción: {0}",descripcion);
          Console.WriteLine("Precio: {0}",precio);
      }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
             var p = new Producto();
           p.ingre(345345, "Jabon","Jabon blanco zote", 23);
           var p1 = new Producto();
           p1.ingre(54247, "Ruffles","Ruffles Queso, 65mg", 15);
           var p2 = new Producto();
           p2.ingre(54256, "Ruffles","Ruffles crunch, 65ml", 15);

           List <Producto> pro=new List<Producto>();
           pro.Add(p);
           pro.Add(p1);
           pro.Add(p2);

            foreach (Producto o in pro)
           {
               o.print();
               Console.WriteLine("   ");
           }
        }
    }
}
