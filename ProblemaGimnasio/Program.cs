// See https://aka.ms/new-console-template for more information
using ProblemaGimnasio;
using System.ComponentModel;
    //llamado de la clase 
    GymDiscount gym =new GymDiscount();
    int passwordGym;
do
{
    try
    {
        Console.Clear();
        Console.WriteLine("-------------------------------BIENVENIDO AL GIMNASIO ROBLES---------------------------------");
        Console.WriteLine("-------------------------------Estudiante Daniela Guzman Avila-------------------------------");
        Console.WriteLine("-------------------------------------Estructura de datos-------------------------------------\n");
        Console.WriteLine("Ingrese la contraseña por favor:");
        passwordGym=int.Parse(Console.ReadLine());
        if(passwordGym == 123)
        {
            gym.requestData();
        }
    }
    //usamos el cath para mostrar al usuario que ha ingresado mal 
    catch (Exception)
    {
        Console.Clear();
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("    error en los datos, vuelve a intentarlo");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
        passwordGym = -1;

    }
} while(passwordGym!=123);