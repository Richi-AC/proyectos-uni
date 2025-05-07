using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Alumno
    {
        //Protected: Solo esta clase y sus derivadas pueden usar la variable definida con esa propiedad

        protected string Nombre;
        protected int NControl;

        //Constructor de alumno
        public Alumno(string n, int NumeroC)
        {
            Nombre = n;
            NControl = NumeroC;
        }
        //se implementa el metodo de la presentacion
        public void Presentacion()
        {
            Console.WriteLine("Hola, soy {0} , mi numero de control es: {1} ", Nombre, NControl);
        }
    }
    //se crea la clase licenciatura en herencia a alumno
    class Licenciatura : Alumno
    {
        //Private: Solo se pueden usar en esta clase las variables con dicha propiedad implementada 
        private string Residencia;
        private string ServicioSocial;

        public Licenciatura(string no, int nc, string r, string sc) : base(no, nc)
        {
            Residencia = r;
            ServicioSocial = sc;
        }
        //New: Redefinimos el metodo de la clase base 
        public new void Presentacion()
        {
            Console.WriteLine("Hola, soy {0} y soy alumno de licenciatura en el instituto tecnologico de tijuana  , mi numero de control es: {1} \n Hago mis residencias en {2} y mi servicio social en {3}", Nombre, NControl, Residencia, ServicioSocial);
        }
    }
    //Clase Posgrado que obtiene valores heredados de la clase alumno









    class Posgrado : Alumno
    {

        private string Investigacion;

        public Posgrado(string no, int nc, string i) : base(no, nc)
        {
            Investigacion = i;
        }

        public new void Presentacion()
        {
            Console.WriteLine("Hola, soy {0} y soy alumno de posgrado, mi numero de control es: {1} \n Realizo una investigacion sobre el tema de las {2}", Nombre, NControl, Investigacion);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los objetos de la clase
            Licenciatura Alday = new Licenciatura("Alday Castro Ricardo", 19210458, "intel", "Nvidia");
            Posgrado Jose = new Posgrado("Jose adrian", 19220478, "Tecnologias para la inteligencia artificial");

            //se llaman los valores a impirmir
            Alday.Presentacion();
            Jose.Presentacion();

            Console.ReadKey();

        }
    }
}

