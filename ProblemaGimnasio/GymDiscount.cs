using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaGimnasio
{
    internal class GymDiscount
    {
        double monthly;
        int id;
        string name;
        int salary;
        string stratum;
        string gender;
        double cost;

        public void requestData()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------BIENVENIDO AL GIMNASIO ROBLES-------------------------------");
            Console.WriteLine("Ingrese su número de documento");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su nombre completo");
            name = Console.ReadLine();

            Console.WriteLine("Ingrese su salario");
            salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estrato");
            stratum = Console.ReadLine();

            Console.WriteLine("Ingrese su genero\n");
            Console.WriteLine("por favor escriba F o M");
            gender = Console.ReadLine();

            generateDiscount();
            showInvoice();
        }

        public void generateDiscount()
        {
            if (salary >= 1000000 && salary < 2000000)
            {
                if (stratum == "1" || stratum == "2")
                {

                    if (gender == "F")
                    {
                        cost = 40000 * 0.25;
                        monthly = 40000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 40000 * 0.20;
                        monthly = 40000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }


                }
                else if (stratum == "3" || stratum == "4")
                {
                    if (gender == "F")
                    {
                        cost = 40000 * 0.2;
                        monthly = 40000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 40000 * 0.15;
                        monthly = 40000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }

                }
                else if (stratum == "5" && stratum == "6")
                {
                    if (gender == "F")
                    {
                        cost = 40000 * 0.15;
                        monthly = 40000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 40000 * 0.1;
                        monthly = 40000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                }
            }
            else if (salary >= 2000000 && salary <= 5000000)
            {
                if (stratum == "1" || stratum == "2")
                {

                    if (gender == "F")
                    {
                        cost = 60000 * 0.25;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 60000 * 0.20;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }


                }
                else if (stratum == "3" || stratum == "4")
                {
                    if (gender == "F")
                    {
                        cost = 60000 * 0.2;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 60000 * 0.15;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }

                }
                else if (stratum == "5" && stratum == "6")
                {
                    if (gender == "F")
                    {
                        cost = 60000 * 0.15;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 60000 * 0.1;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                }
            }else if (salary > 5000000)
            {
                if (stratum == "1" || stratum == "2")
                {

                    if (gender == "F")
                    {
                        cost = 60000 * 0.25;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 60000 * 0.20;
                        monthly = 60000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }


                }
                else if (stratum == "3" || stratum == "4")
                {
                    if (gender == "F")
                    {
                        cost = 80000 * 0.2;
                        monthly = 80000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 80000 * 0.15;
                        monthly = 80000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }

                }
                else if (stratum == "5" && stratum == "6")
                {
                    if (gender == "F")
                    {
                        cost = 80000 * 0.15;
                        monthly = 80000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                    else
                    {
                        cost = 80000 * 0.1;
                        monthly = 80000 - cost;
                        Console.WriteLine($"\nValor de la mensualidad:{monthly}");
                    }
                }
            }
        }

        public void showInvoice()
        {
            Console.WriteLine(                               $"Factura");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                       Gimnasio Robles");
            Console.WriteLine($"                   Número de documento:{id}");
            Console.WriteLine($"                   nombre:{name}");
            Console.WriteLine( $"                  Sueldo:{salary}");
            Console.WriteLine($"                   estrato al que pertenece:{stratum}");
            Console.WriteLine($"                   Genero:{gender}");
            Console.WriteLine( $"                  Mensualidad a pagar en el GYM:{monthly}");
            Console.WriteLine("----------------------------------------------------------------");
        }
    }


}
