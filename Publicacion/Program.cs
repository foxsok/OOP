using System;
using System.Collections.Generic;


namespace FaceClon
{
    abstract class Publicacion
    {
        protected string text;
        protected string nombre;
        protected int HP;
        

        public Publicacion (string t, int hp,string n)
        {
            this.text=t;
            this.HP=hp;
            this.nombre=n;
        }

        public abstract void imprime();
        

        

    }
    class Estado : Publicacion
    {
        public Estado(string t, int hp, string n): base(t,hp,n)
        {
            
        }

        public override void imprime()
        {
            Console.WriteLine("{0}\n {1} \n Hora:{2} ",nombre,text,HP);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Estado("Jose luis",12,"El mejor dia");
            p.imprime();
            
        }
    }
}
