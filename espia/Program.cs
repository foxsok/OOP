using System;

namespace espia
{
       class Persona
    {
        public string nombre;
        public string apellido;
        public int ran;

        public Persona()
        {
            nombre = "Fulano";
            apellido = "De Tal";
        }
    }

class Anonymous {
   public static void anonimiza(Persona p)
    {
            p.nombre = "xxxxxxxxxxx";
            p.apellido = "xxxxxxxxxxx";       
    }

    public static void cambia(ref Persona p )
      {
          Random rnd = new Random();
          p = new Persona();
          p.nombre = "new";
          p.ran = rnd.Next(0,100);
      }
}

    class Program
    {
        static void Main(string[] args)
        {
         Persona p = new Persona();
         Console.WriteLine(p.nombre);
         Anonymous.anonimiza(p);
         Console.WriteLine(p.nombre);
         Anonymous.cambia(ref p);
         Console.WriteLine("Nombre clave: "+p.ran);
         

        }
    }
}
