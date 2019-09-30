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

           static void anonimiza(out string nombre)
    {
            nombre = "xxxxxxxxxxx";
            //p.apellido = "xxxxxxxxxxx";       
    }

        static void Main(string[] args)
        {


            string a;
         Persona p = new Persona();
         Console.WriteLine(p.nombre);
        // Anonymous.anonimiza(p.nombre);
        anonimiza(out a);
         Console.WriteLine( a);
         Anonymous.cambia(ref p);
         Console.WriteLine("Nombre clave: "+p.ran);
         

        }
    }
}
