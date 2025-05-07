using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_2
{
    class Musico
    {
        //Protected: Solo la clase y sus derivadas pueden usar la variable

        protected string nombre;

        //Constructor
        public Musico(string n)
        {
            nombre = n;
        }
        //Metodo Afina virtual: permite que este metodo se pueda sobreescribir en una clase derivada
        public virtual void Afina()
        {
            Console.WriteLine("{0}, Afina su instrumento", nombre);
        }
        //Metodo Saluda

        public virtual string Saluda()
        {
            return string.Format("Hola, soy {0}", nombre);
        }
    }
    //Clase bajista que hereda de musico
    class Bajista : Musico
    {
        //Private: Solo se puede usar en esta clase las variables con dicha propiedad
        private string bajo;
        //Constructor
        //base: Manda llamar variable de la clase base(Musico) de la cual estamos heredando
        public Bajista(string no, string bajo) : base(no)
        {
            this.bajo = bajo;
        }
        //clase derivada override: Es para implementar metodos de la clase base que marcamos con virtual en esta 

        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su bajo {1}", nombre, bajo);
        }
        public override string Saluda()
        {
            return base.Saluda() + " y soy bajista";
        }
    }
    //Clase baterista que hereda de musico
    class Baterista : Musico
    {

        private string bateria;

        public Baterista(string no, string bateria) : base(no)
        {
            this.bateria = bateria;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} Acomodando su bateria {1}", nombre, bateria);
        }
        public override string Saluda()
        {
            return base.Saluda() + " y soy baterista";
        }
    }
    //Clase guitarrista que hereda de musico
    class Guitarrista : Musico
    {

        private string guitarra;
        public Guitarrista(string no, string guitarra) : base(no)
        {
            this.guitarra = guitarra;
        }

        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su guitarra {1}", nombre, guitarra);
        }
        public override string Saluda()
        {
            return base.Saluda() + " y soy guitarrista";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objetos de clases 
            Musico Alday = new Musico("Alday");
            Bajista JR = new Bajista("JR", "Gibson");
            Guitarrista Castro = new Guitarrista("Castro", "Glader");
            Baterista Ricardo = new Baterista("Ricardo", "Gabriel");



            //Lista de musicos

            List<Musico> grupo = new List<Musico>();
            grupo.Add(Alday);
            grupo.Add(JR);
            grupo.Add(Castro);
            grupo.Add(Ricardo);

            //Estructura repetitiva
            foreach (Musico m in grupo)
            {
                Console.WriteLine(m.Saluda());
                m.Afina();
            }
            Console.ReadKey();
        }
    }
}

