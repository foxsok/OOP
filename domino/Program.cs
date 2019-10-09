using System;

namespace domino
{
    class Domino
    {
        public readonly int LadoA;
        public readonly int LadoB;

        public Domino(int LA, int LB)
        {
            LadoA= LA;
            LadoB= LB;

        }
        public static int operator +(Domino a, Domino b)
        {
            return (a.LadoA+a.LadoB+b.LadoA+b.LadoB);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new Domino (2,0);
            var b = new Domino (4,1);
            Console.WriteLine(a+b);

        }
    }
}
