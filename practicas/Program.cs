using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
	class Program
	{
        static void Main(string[] args)
        {
        NoMegustaGithub:
            Console.Clear();
            Console.WriteLine("\tElige una opcion");
            Console.WriteLine("1.- Practica 1");
            Console.WriteLine("2.- Practica 2");
            Console.WriteLine("3.- Practica 3");
            Console.WriteLine("4.- Practica 4");
            Console.WriteLine("5.- Practica 5");
            Console.WriteLine("6.- Practica 6");
            Console.WriteLine("7.- Practica 7");
            Console.WriteLine("8.- Practica 8");
            Console.WriteLine("9.- Salir");

            int opc = int.Parse(Console.ReadLine());


                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\tEste programa muestra el valor mayor y el menor de una sucesion\n");
                        Console.Write("Indica el tamaño del arreglo: ");
                        int tam = int.Parse(Console.ReadLine());
                        double[] array = new double[tam];
                        double may = 0;
                        double men = 0;
                        int i = 0;
                        for (i = 0; i < array.Length; i++)
                        {
                            Console.Write("introduce el valor {0}:  ", i);
                            array[i] = double.Parse(Console.ReadLine());


                            if (array[i] > may)
                            {
                                may = array[i];
                            }

                            if (i == 0 || array[i] <= men)
                            {

                                men = array[i];

                            }


                        }

                        Console.WriteLine("Mayor: " + may + "       Menor: " + men);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\tEste programa inverte una seucesion de caracteres introducidos\n");
                        Console.Write("De que tamaño sera la sucesion de palabras: ");
                        int tamm = int.Parse(Console.ReadLine());
                        string[] caca = new string[tamm];

                        for (i = 0; i < caca.Length; i++)
                        {
                            Console.Write("Escribe una palabra: ");
                            caca[i] = Console.ReadLine();

                        }

                        Console.WriteLine("\nEl orden invertido de la sucesion es: ");
                        for (i = caca.Length - 1; i >= 0; i--)
                        {
                            Console.WriteLine("{0}", caca[i]);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\tEste programa regresa el índice de la última ocurrencia del elemento más \tgrande en la sucesión\n");
                        Console.Write("De que tamaño sera la sucesion de numeros: ");
                        int tammm = int.Parse(Console.ReadLine());
                        double[] cacaa = new double[tammm];
                        double mayy = 0;

                        int ind = 0;
                        for (i = 0; i < cacaa.Length; i++)
                        {
                            Console.Write("Escribe un numero: ");
                            cacaa[i] = double.Parse(Console.ReadLine());

                            if (cacaa[i] >= mayy)
                            {

                                mayy = cacaa[i];
                                ind = i + 1;

                            }
                        }

                        Console.Write("El indice de la ultima ocurrencia del valor mas grande es: {0}", ind);


                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\tEste programa encuentra el valor mas chico de entre 3 valores\n");
                        Console.Write("Ingresa un numero: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa un numero: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa un numero: ");
                        int n3 = int.Parse(Console.ReadLine());

                        if (n1 < n2 && n1 < n3)
                        {

                            Console.WriteLine("El primer numero es mas chico");
                        }
                        else if (n2 < n3)
                            Console.WriteLine("El segundo numero es mas chico");

                        else
                        {
                            Console.WriteLine("El tercer numero es mas chico");
                        }



                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\tEste programa regresa el índice de la primera ocurrencia del elemento\n\tmás grande en la sucesión\n");
                        Console.Write("De que tamaño sera la sucesion de numeros: ");
                        int tammmm = int.Parse(Console.ReadLine());
                        double[] Nogithub = new double[tammmm];
                        double mayor = 0;
                        int indice = 0;

                        for (i = 0; i < Nogithub.Length; i++)
                        {
                            Console.Write("Escribe un numero: ");
                            Nogithub[i] = double.Parse(Console.ReadLine());

                            if (Nogithub[i] > mayor)
                            {

                                may = Nogithub[i];
                                indice = i;

                            }
                        }

                        Console.Write("El indice de la primera ocurrencia del valor mas grande es: {0}", indice);

                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("\tEste programa regresa el indice del primer elemento que es mayor que su prdecedor\n");
                        Console.Write("Ingresa el tamañ de la sucesion: ");
                        tam = Convert.ToInt16(Console.ReadLine());
                        string[] ClassRoom = new string[tam];
                        int mayorr = 0;
                        for (i = 0; i < ClassRoom.Length; i++)
                        {
                            Console.Write("Ingresa una palabra: ");
                            ClassRoom[i] = Console.ReadLine();

                        }


                        for (i = 0; i < ClassRoom.Length; i++)
                        {

                            if (ClassRoom[i].Length > mayorr)
                            {
                                mayorr = ClassRoom[i].Length;
                                ind = i + 1;
                            }

                        }

                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("\tEste programa crea una lista del 1 al 100 aleatoriamente y las acomoda en forma ascendente\n");
                        Random rnd = new Random();
                        int q = 0;
                        int[] arreglo = new int[100];
                        for (i = 0; i < arreglo.Length; i++)
                        {
                            arreglo[i] = rnd.Next(1, 101);
                            Console.WriteLine("Numero generado: " + arreglo[i]);
                        }

                        Console.WriteLine("\nAhora en forma ascendiente: ");

                        for (i = 0; i < arreglo.Length; i++)
                        {
                            for (q = i + 1; q < arreglo.Length; q++)
                            {
                                if (arreglo[i] > arreglo[q])
                                {
                                    ind = arreglo[i];
                                    arreglo[i] = arreglo[q];
                                    arreglo[q] = ind;
                                }
                            }
                        }

                        for (i = 0; i < arreglo.Length; i++)
                        {

                            Console.WriteLine(arreglo[i]);
                        }


                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("\tEste programa indica si el numero introducido es palindromo o no\n");

                    NoEntiendoGitHub:
                        Console.Write("Inserta un valor de 5 digitos: ");
                        int valor = int.Parse(Console.ReadLine());


                        if (valor.ToString().Length == 5)
                        {
                            if (valor.ToString()[0] == valor.ToString()[4] && valor.ToString()[1] == valor.ToString()[3])
                            {
                                Console.WriteLine("Es un palindromo");
                            }

                            else
                                Console.WriteLine("No es palindromo");

                        }
                        else
                        {
                            Console.WriteLine("Error: No es un numero de 5 digitos, vuelve a intentarlo");
                            Console.Clear();
                            goto NoEntiendoGitHub;
                        }


                        break;
                case 9:
                    break;
                default:

                    Console.WriteLine("Opcion invalida, vuelve a intentarlo chamop!");
                    goto NoMegustaGithub;

                }
           
            Console.WriteLine("Press any key to continue...");

			Console.ReadKey();




		}
	}
}


