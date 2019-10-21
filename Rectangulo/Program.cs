using System;

namespace Rectangulo
{
    class Rectangulo
    {
        public readonly double Base;
        public readonly double Altura;
        public double ar;
        public Rectangulo(double B, double A)
        {
           this.Base=B;
          this.Altura=A;

        }
        public static double operator +(Rectangulo B, Rectangulo A)
        {
            double valor1 = B.Altura+A.Altura;
            double valor2 = B.Base+A.Base;
            return (valor1+valor2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangulo (10,5);
            var r2 = new Rectangulo (5,5);
            double r3 = r+r2;
            Console.WriteLine("El rectangulo 3 tiene valores de:{0} y el area es de {1}",r3,r.ar);

        }
    }
}
