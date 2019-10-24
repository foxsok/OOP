using System;
using System.Collections.Generic;

namespace Musico
{
     class Musico 
    {

        protected string nombre;
        public Musico(string n)
        {
        nombre=n;

        }
       

        

    }

    class Bajista:Musico
    {
       private string bajo;
       public Bajista(string no,string bajo):base(no)
       {
       this.bajo=bajo;
       this.nombre=no;
       } 
       
       public void print()
      {
          Console.WriteLine("Hola, soy: {0}",nombre);
          Console.WriteLine("Instrumento: Bajo: {0}",bajo);
         
      }
    }
    class Baterista:Musico
    {
       private string Bateria;
       public Baterista(string no,string Bateria):base(no)
       {
       this.Bateria=Bateria;
       } 

        public void print()
      {
          Console.WriteLine("Hola, soy: {0}",nombre);
          Console.WriteLine("Instrumento: Bateria: {0}",Bateria);
         
      }
    }
    class Guitarrista:Musico
    {
       private string Guitarra;
       public Guitarrista(string no,string Guitarra):base(no)
       {
       this.Guitarra=Guitarra;
       } 

        public void print()
      {
          Console.WriteLine("Hola, soy: {0}",nombre);
          Console.WriteLine("Instrumento: Guitarra: {0}",Guitarra);
         
      }
       
    }
    class Program
    { 

        static void Main()
        {
            var B = new Bajista("Slash","Fender Deluxe P-Bass Special");
            var B1 = new Bajista("Carlos Santada","Epiphone Thunderbird Pro-IV Bass.");
            var B2 = new Bajista("Jose Cruz","Schecter Stiletto Custom-4.");
            var b = new Baterista("John Bonham","Ludwig");
            var b1 = new Baterista("Mike Portnoy","Gretsch.");
            var g = new Guitarrista("Jimmy Hendrix","Gibson les paul");
            var g2 = new Guitarrista("Eric Clapton","Fender");
            var g3 = new Guitarrista("Jimmy Page","Rickenbacker.");
            List<Musico> Mu = new List<Musico>();
            Mu.Add(B);
            Mu.Add(B1);
            Mu.Add(B2);
             List<Musico> Mu2 = new List<Musico>();
            Mu2.Add(b);
            Mu2.Add(b1);
             List<Musico> Mu3 = new List<Musico>();
            Mu3.Add(g);
            Mu3.Add(g2);
            Mu3.Add(g3);

             foreach (Bajista o in Mu )
           {
               o.print();
               Console.WriteLine("   ");
           } 
           foreach (Baterista o in Mu2 )
           {
               o.print();
               Console.WriteLine("   ");
           }
            foreach (Guitarrista o in Mu3 )
           {
               o.print();
               Console.WriteLine("   ");
           }

        }
    }
}
