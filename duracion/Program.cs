using System;

namespace duracion
{
    class Duracion
    {
        public double Horas;
        public double Minutos;
        public double Segundos;
        
        public Duracion(double H, double M, double S)
        {
            Horas=H;
            Minutos=M;
            Segundos=S;
        }
        //public static double conversion(Duracion H, Duracion M, Duracion S)
       // {

       //     return(); 
       // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dur = new Duracion(2,15,12);
            Console.WriteLine("El tiempo es {0}:{1}:{2}",dur.Horas,dur.Minutos,dur.Segundos);

        }
    }
}
