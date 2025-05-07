using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_generica_stack
{
    class Stack<T>
    {
        private readonly int Capacidad;
        private int apuntador = 0;
        T[] miembros;
        public Stack() : this(8) { }
        public Stack(int capacity)
        {
            this.Capacidad = capacity;
            miembros = new T[this.Capacidad];
        }

        public void Push(T miembro)
        {
            if (this.apuntador >= this.Capacidad)
                throw new Exception("Stack lleno");
            else
            {
                this.miembros[this.apuntador] = miembro;
                this.apuntador++;
            }
        }
        public T Pop()
        {
            this.apuntador--;
            if (this.apuntador >= 0)
                return this.miembros[this.apuntador];
            else
                throw new IndexOutOfRangeException("Stack vacio");
        }
    }
    class Program
    {
        static void Main()
        {
            var nums = new Stack<int>();
            Random rdm = new Random();
            for (int i = 0; i < 8; i++)
                nums.Push(i + 1);
            for (int i = 0; i < 8; i++)
                Console.Write(nums.Pop() + "\t");

            Console.WriteLine();

            var vocal = new Char[] { 'a', 'e', 'i', 'o', 'u' };
            var text = new Stack<char>(vocal.Length);
            for (int i = 0; i < vocal.Length; i++)
                text.Push(vocal[i]);
            for (int i = 0; i < vocal.Length; i++)
                Console.Write(text.Pop() + "\t");
            Console.ReadKey();
        }
    }
}
