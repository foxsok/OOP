using System;

namespace Stock
{
    class Stocks<T>
    {
       
     public T[] elementos;
     readonly int max_size;
     public int Apuntador = 0;
    
    
     public Stocks():this(100)
     {
         
     }
    
       public Stocks(int size)
     {
         max_size = size;
         elementos = new T[max_size];
     }

    
     public void Push(T elemento)
     {
         
         if(Apuntador >= max_size)
         {
            throw new StackOverflowException();
         }

         else
         {
            elementos[Apuntador] = elemento;
            Apuntador++;
         }

     }  

     
     public T Pop()
     {
         Apuntador--;
        
         if(Apuntador >= 0)
         {
           return elementos[Apuntador];
         }
         
         else
         {
            Apuntador = 0;
            throw new InvalidOperationException("Error");
         }
     }

     }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Stocks <int> elementos = new Stocks <int> (4); 
            
            elementos.Push(1);
            elementos.Push(4);
            elementos.Push(10);
            elementos.Push(15);
        
            Console.WriteLine("Elementos de la pila");
            Console.WriteLine(elementos.Pop());
            Console.WriteLine(elementos.Pop());
            Console.WriteLine(elementos.Pop());
            Console.WriteLine(elementos.Pop());

            

            string Nombre;
         
            Queue Cola =new Queue();

            Cola.Enqueue("Luis  \n");
            Cola.Enqueue("Jose  \n");
            Cola.Enqueue("Daniel  \n");
            Cola.Enqueue("Ricardo");

            Console.WriteLine("/////////////////");
            Console.WriteLine("Elementos de la Cola");
            
            for(int i=0;i<4;i++)
            {
        
         Nombre=(string) Cola.Dequeue();
         
         Console.Write(Nombre);
        
         
            }



            
        }
    }
}
