using System;

namespace Peliculas1
{
  
    class Pelicula
    {
        private string titulo, pais, director;
        private Int16 año;
        
        public void settitulo(string t)
        {
            titulo=t;
        }
      public string gettitulo()
        {
        return titulo;
        }
        public void setaño(Int16 a)
        {
            año=a;
        }
      public Int16 getaño()
        {
        return año;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1 = new Pelicula();
           Pelicula p2 = new Pelicula();

           p1.settitulo("Una mente brillante");
           p1.setaño(2001); 
           p2.settitulo("Dunkerque");
           p2.setaño(2017);
    Console.WriteLine("Pelicula 1: {0} {1} Pelicula 2: {2} {3}", p1.gettitulo(), p1.getaño(),p2.gettitulo(),p2.getaño());
        }
    }
}
