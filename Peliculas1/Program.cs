using System;

namespace Peliculas1
{
  
    class Pelicula
    {
        public string titulo, pais, director;
        public Int16 año;
    }
    class Program
    {
        static void Main(string[] args)
        {
           Pelicula p1 = new Pelicula();
           Pelicula p2 = new Pelicula();

           p1.titulo=("Una mente brillante");
           p1.año=(2001); 
           p2.titulo=("Dunkerque");
           p2.año=(2017);
    Console.WriteLine("Pelicula 1: {0} {1} Pelicula 2: {2} {3}", p1.titulo, p1.año,p2.titulo,p2.año);
        }
    }
}
