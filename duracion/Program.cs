using System;

namespace duracion
{
    class Duracion
    {
        public double Horas;
        public double Minutos;
        public double Segundos;
        public double Hrs;
        
        public Duracion(double H, double M, double S)
        {
            Horas=H;
            Minutos=M;
            Segundos=S;
        }
        
        public void print()
        {
           Console.WriteLine("El tiempo en segundos es: "+Horas*3600+Minutos*60+Segundos);
           Console.WriteLine("El tiempo en horas es: "+(Horas+(Minutos/60)+(Segundos/3600)));
           Console.WriteLine("El tiempo en minutos es:"+(Horas*60+(Minutos+(Segundos/60))));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dur = new Duracion(2,15,12);
            
            Console.WriteLine("El tiempo es {0}:{1}:{2}",dur.Horas,dur.Minutos,dur.Segundos);
            dur.print();
            

        }
    }
}
