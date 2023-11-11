using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            int opcion;
            do
            {
                
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1.Asiganacion de salarios a empleados");
                Console.WriteLine("2.Listado de dias de la semana");
                Console.WriteLine("0.Salir");
                Console.WriteLine("Seleccione una opcion:");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AsignarSalarios();
                            break;
                        case 2:
                            MostrarDiasSewmana();
                            break;
                        case 0:
                            Console.WriteLine("\nSaliendo del programa. Hasta luego!\n");
                            break;

                        default:
                            Console.WriteLine("Opcion no valida. Intente nuevamente.");
                            break;
                    }
                    
                }
                else
                {
                 Console.WriteLine("Ingrese un numero valid");   
                }

            } while (opcion !=0);




        }
        static void AsignarSalarios()
        {
            List<string?> nombres = new List<string?>();
            List<double> salarios = new List<double>();

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"\nIngrese el nombre del empleado {i}: ");
                string? nombre = Convert.ToString(Console.ReadLine());
                nombres.Add(nombre);

                Console.WriteLine($"\nIngrese el salario del empleado {nombre}: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                salarios.Add(salario);

            }

            Console.WriteLine("\nAsiganacion de salarios compeletada... \nDetalles:");

            for (var i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine($"{nombres[i]}: ${salarios[i]}");
            } 
        }
        enum DiasSemana
        {
            lunes,
            martes,
            miercoles,
            jueves,
            viernes,
            sabado,
            domingo
        }
        static void MostrarDiasSewmana()
        {
            foreach (DiasSemana dia in Enum.GetValues(typeof(DiasSemana)))
            {
                if (dia == DiasSemana.domingo)
                {
                    Console.WriteLine($"\n{dia}: !Dia de descanso!");
                }
                else
                {
                    Console.WriteLine($"\n{dia}: Dia de trabajo.");
                }
            }
        }
    }
}