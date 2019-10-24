using System;

namespace Alumnos
{
    abstract class Alumnos
    {
       protected string Nombre;
       protected string Grado;
       public Alumnos(string n, string g)
       {
           this.Nombre=n;
           this.Grado=g;
       }
       public abstract void print();
       
    }

    class Licen : Alumnos
    {
        public Licen(string n,string g):base(n,g)
        {
          
        }
        public override void print()
        {
              Console.WriteLine("El alumno:{0} de {1}\nHara un servicio social en la empresa tumbers C.A de C.V y la residencia en la misma empresa\n",Nombre,Grado);
        }
    }
    class Posgrado : Alumnos
    {
        public Posgrado(string n,string g):base(n,g)
        {
            
        }
        public override void print()
        {
            Console.WriteLine("El alumno:{0} de {1}\nHara una investigación sobre programacion pix2pix",Nombre,Grado);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var L = new Licen("Carlos de la cruz","Licenciatura");
            var P= new Posgrado("Jose Luis","Posgrado");
            P.print();
            L.print();
        }
    }
}
