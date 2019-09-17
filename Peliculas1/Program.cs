using System;

namespace Peliculas1
{
  
   class Pelicula
    {
        private string titulo,titulo2;
        private int año,año2;
       
       public Pelicula()
       {
           titulo="Una mente brillante";
           año=2001;
           titulo2="Dunkerque";
           año2=2017;
       }
       public Pelicula(string t,string t2, int a, int a2)
       {
           titulo=t;
           titulo2=t2;
           año=a;
           año2=a2;
       }
       

       public void imprime()
       {
           Console.WriteLine("Pelicula 1: {0} {1} Pelicula 2: {2} {3}", titulo, año, titulo2, año2);
       }


    }
    class Program
    {
         static void Main(string[] args)
        {
            

            Pelicula pelicula1=new Pelicula();
            
            pelicula1.imprime();
            
            
        }
    }
}
