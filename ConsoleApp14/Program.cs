using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso: ");
            int peso = int.Parse(Console.ReadLine());

            Console.ReadKey();
            Console.Clear();

           
            if (año <= 1970)
            {
                int clase = 0;
                float tarifa = 0f;
                for (int opcion = 0; peso < 2700 && opcion ==0; opcion++)
                {
                    clase = 1;
                    tarifa = 16.50f;
                    opcion++;
                }
                for (int opcion = 0; peso >= 2700 && peso <= 3800 && opcion == 0; opcion++)
                {
                    clase = 2;
                    tarifa = 25.50f;
                    opcion++;
                }
                for (int opcion = 0; peso > 3800 && opcion == 0; opcion++)
                {
                    clase = 3;
                    tarifa = 46.50f;
                    opcion++;
                }
                Console.Write("Año del modelo");
                Console.Write("{0,10}", "Peso");
                Console.Write("{0,24}", "Clase de peso");
                Console.Write("{0,30}", "Tarifa de registro");
                Console.WriteLine();

                Console.Write(año);
                Console.Write("{0,24}", peso +" lbs");
                Console.Write("{0,8}", clase);
                Console.Write("{0,28}", tarifa);
            }
            else if (año >= 1971 && año <= 1979)
            {
                int clase = 0;
                float tarifa = 0f;
                for (int opcion = 0; peso < 2700 && opcion ==0; opcion++)
                {
                    clase = 4;
                    tarifa = 27.00f;
                    opcion++;
                }
                for (int opcion = 0; peso >= 2700 && peso <= 3800 && opcion == 0; opcion++)
                {
                    clase = 5;
                    tarifa = 30.50f;
                    opcion++;
                }
                for (int opcion = 0; peso > 3800 && opcion == 0; opcion++)
                {
                    clase = 6;
                    tarifa = 52.50f;
                    opcion++;
                }
                Console.Write("Año del modelo");
                Console.Write("{0,10}", "Peso");
                Console.Write("{0,24}", "Clase de peso");
                Console.Write("{0,30}", "Tarifa de registro");
                Console.WriteLine();

                Console.Write(año);
                Console.Write("{0,24}", peso + " lbs");
                Console.Write("{0,8}", clase);
                Console.Write("{0,28}", tarifa);
            }
            else if (año >= 1980)
            {
                int clase = 0;
                float tarifa = 0f;
                for (int opcion = 0; peso < 3500 && opcion ==0; opcion++)
                {
                    clase = 7;
                    tarifa = 19.50f;
                    opcion++;
                }
                for (int opcion = 0; peso >= 3500 && opcion == 0; opcion++)
                {
                    clase = 8;
                    tarifa = 52.50f;
                    opcion++;
                }
                Console.Write("Año del modelo");
                Console.Write("{0,10}", "Peso");
                Console.Write("{0,24}", "Clase de peso");
                Console.Write("{0,30}", "Tarifa de registro");
                Console.WriteLine();

                Console.Write(año);
                Console.Write("{0,24}", peso + " lbs");
                Console.Write("{0,8}", clase);
                Console.Write("{0,28}", tarifa);
            }


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
