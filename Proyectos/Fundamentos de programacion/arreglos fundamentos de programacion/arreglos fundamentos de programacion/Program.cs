using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos_fundamentos_de_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar;
            //inicio del ciclo do while
            do
            {
                Console.Clear();
                Console.Write("Semestre:");//Capturar el semestre en el cual estudian los alumnos 
                string dept = Console.ReadLine();
                //Captura el número de estudiantes
                Console.Write("Cantidad de estudiantes: ");
                int noEst = int.Parse(Console.ReadLine());
                double[,] calificaciones = new double[2, noEst];
                string[] empleados = new string[noEst];
                for (int i = 0; i < noEst; i++)
                {
                    Console.Write("          Nombre del estudiante {0}: ".Trim(), i + 1);
                    empleados[i] = Console.ReadLine();

                    Console.Write("Calificación del estudiante {0}: ", i + 1);
                    double calificación = double.Parse(Console.ReadLine());
                    calificaciones[0, i] = calificación;
                }
                Console.Clear();
                Console.WriteLine("Semestre: " + dept);
                Console.WriteLine("Estudiante\tCalificación");

                double PromedioT = 0;
                for (int i = 0; i < noEst; i++)
                {
                    double calificación = calificaciones[0, i];
                    PromedioT=calificación/noEst;
                    //impresión de resultados
                    Console.WriteLine("{0}\t\t{1:F2}", empleados[i], calificación);
                }

                //Impresión de los resultados
                Console.WriteLine("\nPromedio grupal: {0:F2}", PromedioT);
                Console.WriteLine("\nLeer más calificaciones? (y/n)");
                string opcion = Console.ReadLine();
                //ejecución del ciclo do while

                continuar = opcion == "Y" || opcion == "y";
            } while (continuar);
        }
    }
}

