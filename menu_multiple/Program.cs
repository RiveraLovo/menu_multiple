using System;

namespace menu_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("oooooooooooooo MENU DE OPCIONES - PREGUNTAS DE 01 AL 06 ooooooooooooooooo");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                Console.WriteLine("oooooooooo 1.Pregunta 01                                ooooooooooooooooo");
                Console.WriteLine("oooooooooo 2.Pregunta 02                                ooooooooooooooooo");
                Console.WriteLine("oooooooooo 3.Pregunta 03                                ooooooooooooooooo");
                Console.WriteLine("oooooooooo 4.Pregunta 04                                ooooooooooooooooo");
                Console.WriteLine("oooooooooo 5.Pregunta 05                                ooooooooooooooooo");
                Console.WriteLine("oooooooooo 6.Pregunta 06                                ooooooooooooooooo");
                Console.WriteLine("ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                Console.Write("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (opcion)
                {
                    case 1: Dias_Semana(); break;
                    case 2: Menor_Mayor(); break;
                    case 3: Temperatura(); break;
                    case 4: NotaFinal_Estudiante(); break;
                    case 5: Numero_04_Digitos(); break;
                    case 6: EcuacionPrimerGrado(); break;

                    default:
                        Console.WriteLine(" :)...Ingrese una Opcion Valida .....!! :)");
                        break;
                }

            } while (opcion != 7);

        }

        static void Dias_Semana()
        {
            int dia;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_______________________________________________________________________________________");
            Console.WriteLine(" Pregunta 1: Ingrese un numero del 1 al 7 e imprima el dia de la semana correspondiente");
            Console.WriteLine("_______________________________________________________________________________________");

            Console.WriteLine("Ingrese un dia de la semana");
            dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sabado"); break;
                case 7: Console.WriteLine("Domingo"); break;

                default:
                    Console.WriteLine(":)...Ingrese un dia de la semana valida .....!! :)");
                    break;
            }


            Console.WriteLine();
            Console.WriteLine(" :):)....... Presione la Tecla (INTRO) Para -->> Continuar ...... :):)");
            Console.ReadLine();

        }

        static void Menor_Mayor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine(" Pregunta 2: Ingrese 3 numeros y muestre en pantalla de menor a mayor");
            Console.WriteLine("_____________________________________________________________________________");

            Console.WriteLine("Ingrese un  primer numero");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese un  segundo numero");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese un  tercer numero");
            int num3 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Numeros Ordenados:" + num3 + "-" + num2, "-" + num1);
                }
                else
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("Numeros Ordenados:" + num2 + "-" + num3 + "-" + num1);
                    }
                    else
                    {
                        Console.WriteLine("Numeros Ordenados:" + num2 + "-" + num1 + "-" + num3);
                    }
                }
            }
            else
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Numeros Ordenados:" + num3 + "-" + num1 + "-" + num2);
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("Numeros Ordenados:" + num1 + "-" + num3 + "-" + num2);
                    }
                    else
                    {
                        Console.WriteLine("Numeros Ordenados:" + num1 + "-" + num2 + "-" + num3);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(" :):)....... Presione la Tecla (INTRO) Para -->> Continuar ...... :):)");
            Console.ReadLine();
        }

        static void Temperatura()
        {
            int temp;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("__________________________________________________________________________________________");
            Console.WriteLine(" Pregunta 3: Escribe un programa que lea una temperatura introducida a traves del teclado");
            Console.WriteLine(" y muestre por pantalla la actividad mas apropiada para dicha temperatura ");
            Console.WriteLine("__________________________________________________________________________________________");

            Console.WriteLine("Ingrese una temperatura");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp > 30)
            {
                Console.WriteLine("Natacion");
            }
            else if (20 < temp && temp <= 30)
            {
                Console.WriteLine("Tenis");
            }
            else if (10 < temp && temp <= 20)
            {
                Console.WriteLine("Golf");
            }
            else if (5 < temp && temp <= 10)
            {
                Console.WriteLine("Esqui");
            }
            else if (temp <= 5)
            {
                Console.WriteLine("Parchis");
            }

            Console.WriteLine();
            Console.WriteLine(" :):)....... Presione la Tecla (INTRO) Para -->> Continuar ...... :):)");
            Console.ReadLine();

        }

      
        static void NotaFinal_Estudiante()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.WriteLine(" Pregunta 4: Escribir un programa que pida nota final del estudiante e imprima por pantalla la calificacion");
            Console.WriteLine(" en formato APROBADO para quienes tienen 11 a 20, SUSTITUTORIO para quienes tienen de 7 a 10 y REPROBADO para el resto ");
            Console.WriteLine("_______________________________________________________________________________________________________________________");

            Console.WriteLine("Ingrese nota final del estudiante");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 11 && nota <= 20)
            {
                Console.WriteLine("Aprobado");
            }
            else if (nota >= 7 && nota <= 10)
            {
                Console.WriteLine("Sustitutorio");
            }
            else if (nota < 7)
            {
                Console.WriteLine("Reprobado");
            }

            Console.WriteLine();
            Console.WriteLine(" :):)....... Presione la Tecla (INTRO) Para -->> Continuar ...... :):)");
            Console.ReadLine();
        }

      
        static void Numero_04_Digitos()
        {
            double millar, centena, decena, unidad, sumatoria;
            double raizCuadrada, promedio;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine(" Pregunta 5: Calcular el promedio de sus digitos");
            Console.WriteLine(" 1: Calcular el promedio de sus digitos ");
            Console.WriteLine(" 2: Calcular la raiz cuadarada de la suma de sus digitos ");
            Console.WriteLine("_______________________________________________________________________");

            Console.WriteLine("Ingrese un Numero de 4 digitos");
            int numero = Convert.ToInt32(Console.ReadLine());

            millar = (numero / 1000);
            centena = ((numero % 1000) / 100);
            decena = ((numero % 100) / 10);
            unidad = numero % 10;

            sumatoria = (millar + centena + decena + unidad);

            raizCuadrada = Math.Sqrt(sumatoria);

            promedio = (millar + centena + decena + unidad) / 4;


            Console.WriteLine("El promedio de sus digitos es: {0}", promedio);
            Console.WriteLine("La raiz cuadrada de la suma de sus digitos es: {0}", raizCuadrada);


            Console.WriteLine();
            Console.WriteLine(" :):)....... Presione la Tecla (INTRO) Para -->> Continuar ...... :):)");
            Console.ReadLine();
        }

        static void EcuacionPrimerGrado()
        {
            double a, b, x;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("____________________________________________________________________________________________________");
            Console.WriteLine(" Pregunta 6: Escriba un programa que pida los coeficientes de una ecuacion de primer grado (ax+b=0)");
            Console.WriteLine(" y escriba la solucion.  ");
            Console.WriteLine("____________________________________________________________________________________________________");

            Console.WriteLine("Coeficiente a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coeficiente b");
            b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                x = (-1 * b) / a;
                Console.WriteLine("Solucion de la ecuacion: " + x);
            }
            else if (b != 0)
            {
                Console.WriteLine("Sin Solucion");
            }
            else
            {
                Console.WriteLine("Todos los numeros son solucion");
            }


            Console.WriteLine();
            Console.WriteLine(" :):)....... Presione la Tecla (INTRO) Para -->> Continuar ...... :):)");
            Console.ReadLine();
        }

    }
}
