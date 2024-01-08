using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IF();
            //SWITCH();
            //WHILE();
            DOWHILE();
        }

        static void IF()
        {
            /*Si el condicional solo posee 1 linea de codigo, se puede
             * dejar sin llave y siempre lo reconoceria 
              if (Edad >= 18) Console.WriteLine("Eres mayor de edad");
            */

            Console.WriteLine("Vamo a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Ingrese tu edad");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");

            else
            {
                Console.WriteLine("¿Tienes carnet?");

                string carnet = Console.ReadLine();

                int compara = String.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

                else Console.WriteLine("Lo siento mucho no puedes conducir");
            }
            //-------------------------------------------------------------------------------
            Console.WriteLine("Ingrese la nota del primer parcial");

            float parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del segundo parcial");

            float parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del tercero parcial");

            float parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
                Console.WriteLine($"La nota media es: {(parcial1 + parcial2 + parcial3) / 3}");

            else Console.WriteLine("Vuelve el otro año xD");
            //------------------------------------------------------------------------------------

            Console.WriteLine("Introduce tu edad");

            int Edad = Int32.Parse(Console.ReadLine());

            if (Edad < 18) Console.WriteLine("Eres un niño");

            else if (Edad < 30) Console.WriteLine("Eres joven");

            else if (Edad < 60) Console.WriteLine("Eres maduro");

            else Console.WriteLine("Ya estas jubilado");
        }

        static void SWITCH()
        {
            //Con SWITCH solo evaluan los datos "int","char","String"
            //Si son "float","double" se utilizara IF

            Console.WriteLine("Introduce N° de mes para calculo de la comision");
            int nMes = Int32.Parse(Console.ReadLine());

            switch (nMes)
            {
                case 1:
                    Console.WriteLine("Mes escojido: Enero");
                    break;
                case 2:
                    Console.WriteLine("Mes escojido: Febrero");
                    break;
                case 3:
                    Console.WriteLine("Mes escojido: Marzo");
                    break;
                case 4:
                    Console.WriteLine("Mes escojido: Abril");
                    break;
                case 5:
                    Console.WriteLine("Mes escojido: Mayo");
                    break;
                case 6:
                    Console.WriteLine("Mes escojido: Junio");
                    break;
                case 7:
                    Console.WriteLine("Mes escojido: Julio");
                    break;
                case 8:
                    Console.WriteLine("Mes escojido: Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mes escojido: Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Mes escojido: Octubre");
                    break;
                case 11:
                    Console.WriteLine("Mes escojido: Novienbre");
                    break;
                case 12:
                    Console.WriteLine("Mes escojido: Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes no existente");
                    break;
            }
            Console.WriteLine("Fin del programa");
        }

        static void WHILE()
        {
            Console.WriteLine("Deseas entrar en el bucle while?");
            string respueta = Console.ReadLine();

            while (respueta != "no")
            {
                Console.WriteLine("Estas ejecutando en el interior del bucle while");

                Console.WriteLine("Introduce nombre por favor");
                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldras del bucle {nombre} cuando respondas 'no' a la pregunta");
                Console.WriteLine("Deseas repetir otra vez");

                respueta = Console.ReadLine();
            }
            Console.WriteLine("Estas fuera del bucle");

            Random numero = new Random();
            int numAleatorio = numero.Next(0,100);

            int num = -1;
            int contador = 0;

            Console.WriteLine("Que numero se genero del 0-100");

            while (num != numAleatorio)
            {
                num = Int32.Parse(Console.ReadLine());

                if (numAleatorio<num) Console.WriteLine("El numero es menor");

                else if(numAleatorio>num) Console.WriteLine("El numero es mayor");

                contador++;
            }
            Console.WriteLine($"Numero de intentos {contador}");
        }

        static void DOWHILE()
        {
            Random numero = new Random();
            int numAleatorio = numero.Next(0, 100);

            int num;
            int contador = 0;

            Console.WriteLine("Que numero se genero del 0-100");

            
            do{
                
                num = Int32.Parse(Console.ReadLine());
                
                if (numAleatorio < num) Console.WriteLine("El numero es menor");

                else if (numAleatorio > num) Console.WriteLine("El numero es mayor");

                contador++;
            } while (num != numAleatorio) ;
           
            Console.WriteLine($"Numero de intentos {contador}");
        }
    }
}
