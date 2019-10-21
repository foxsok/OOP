using System;
using System.Collections.Generic;
namespace Alumno
{
    class Alumno
    {
    
        public int NumeroDeControl;
        public string Nombre;
        public string Apellido;
        public string Correo;
        
      
      public void ingre(int nc, string n, string a, string c)
      {
          this.NumeroDeControl=nc;
          this.Nombre=n;
          this.Apellido=a;
          this.Correo=c;
      }
      public void print()
      {
          Console.WriteLine("Numero de control: {0}",NumeroDeControl);
          Console.WriteLine("Nombre: {0}",Nombre);
          Console.WriteLine("Apellido: {0}",Apellido);
          Console.WriteLine("Correo: {0}",Correo);
      }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
             var alu = new Alumno();
           alu.ingre(5463, "Juan","Ramos", "Juan.18@tectijuana.edu.mx");
           var alu1 = new Alumno();
           alu1.ingre(542, "Pedro","Sola", "Pedro.18@tectijuana.edu.mx");
           var alu2 = new Alumno();
           alu2.ingre(5425, "Carlos","Valboa","Carlos.18@tectijuana.edu.mx");

           List<Alumno> al=new List<Alumno>();
           al.Add(alu);
           al.Add(alu1);
           al.Add(alu2);

            foreach (Alumno o in al)
           {
               o.print();
               Console.WriteLine("   ");
           }
        }
    }
    
}
