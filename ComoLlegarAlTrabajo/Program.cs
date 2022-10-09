using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ComoLlegarAlTrabajo
{



    internal class Program
    {
        static void Main(string[] args)
        {
            string work; 
            Console.WriteLine("¿Vas al trabajo?");

            work = Console.ReadLine();

            if(work == "si")
            {
                Console.WriteLine("¿Vas en transporte?");
                string transporte = Console.ReadLine();

                if (transporte == "si")
                {
                    Console.WriteLine("¿Tienes Dinero?");
                    string dinero = Console.ReadLine();
                    while(dinero != "si")
                    {
                        Console.WriteLine("Consigue Dinero");
                        Console.WriteLine("");

                        Console.WriteLine("¿Ya tienes dinero?");
                        dinero = Console.ReadLine();
                    }
                    Console.WriteLine("¿Que tipo de transporte busca?\n" +
                        "1. auto\n" +
                        "2. moto\n" +
                        "3. bus\n" +
                        "4. Taxi\n");

                    int tTransporte = int.Parse(Console.ReadLine());

                    switch (tTransporte)
                    {
                        case 1:
                            Funciones.auto();
                            break;
                        case 2:
                            Funciones.moto();
                            break;
                        case 3:
                            Funciones.bus();
                            break;
                        case 4:
                            Funciones.taxi(); 
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }

                    Console.WriteLine("¿Cuando sales del medio de transporte \n" +
                        "tienes que caminar?");
                    string caminar = Console.ReadLine();

                    if(caminar == "si")
                    {
                        Funciones.aPie(); 
                    }
                    Console.WriteLine("Hoy no hay trabajo");
                }
                else
                {
                
                    Console.WriteLine("¿tienes que caminar?");

                    string caminar = Console.ReadLine();

                    if (caminar == "si")
                    {
                    
                        Funciones.aPie();
                        
                    }

                }
                
                Console.WriteLine("Has llegado al trabajo"); 

            }
            else
            {
                Console.WriteLine("Hoy no hay trabajo");
            }

        }
    }
}
