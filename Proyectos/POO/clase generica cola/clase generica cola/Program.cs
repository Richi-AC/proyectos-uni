using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_generica_cola
{
    class Queue<T>
    {
        private int tamaño;
        private int apuntador = 0;
        private T[] cola;

        public Queue(int t)
        {
            tamaño = t;
            cola = new T[tamaño];
        }

        public void Push(T dato)
        {
            //validar 
            cola[apuntador] = dato;
            apuntador++;
        }

        public T Pop()
        {
            //validar 
            T dato = cola[0];

            for (int i = 0; i < tamaño; i++)
            {
                if (i < tamaño - 1)
                    cola[i] = cola[i + 1];
            }
            apuntador--;
            return dato;

        }

        public void Print()
        {
            for (int j = 0; j < tamaño; j++)
            {
                Console.WriteLine(cola[j]);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> cola = new Queue<string>(5);

            cola.Push("A");
            cola.Push("B");
            cola.Push("C");
            cola.Push("D");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(cola.Pop());

                cola.Print();
            }

            Console.ReadKey();
        }
    }
}