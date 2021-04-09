using System;

namespace Los_10_Ejercicios
{
    class Program
    {

        /* EJERCICIO 1     

    static void Main(string[] args)
    {

        int num = 0;

        Console.Clear();

        Console.SetCursorPosition(40, 5); Console.WriteLine("Digite  el numero");

        for (int i = 4; i < 100; i++)
        {
            Console.SetCursorPosition(i, 3); Console.Write("▄");
            Console.SetCursorPosition(i, 25); Console.Write("▄");
            Console.SetCursorPosition(i, 7); Console.Write("▄");        
        }
        for (int i = 4; i <= 25; i++)
        {
            Console.SetCursorPosition(4, i); Console.WriteLine("▓");
            Console.SetCursorPosition(99, i); Console.WriteLine("▓");
        }

        num = int.Parse(Console.ReadLine());



        if (num % 2 == 0)
        {
            Console.SetCursorPosition(40, 10); Console.WriteLine("El numero es par...");
        }
        else
        {
            Console.SetCursorPosition(40, 12); Console.WriteLine("El numero es impar");
        }

        Console.SetCursorPosition(40, 14); Console.WriteLine("gracias por usar el programa..");

        Console.ReadKey();
    }

   **/

        /*EJERCICIO 2
        static void Main(string[] args)

        {
            for (int i = 4; i < 40; i++)
            {
                Console.SetCursorPosition(i, 3); Console.Write("▄");
                Console.SetCursorPosition(i, 25); Console.Write("▄");
                
            }

            for (int i = 4; i <= 25; i++)
            {
            
                Console.SetCursorPosition(39, i); Console.WriteLine("▓");
            }


            int c = 1;
            int t = 0;
            int r = 0;

            Console.SetCursorPosition(1, 5); Console.WriteLine("DIGITE EL NUMERO DE LA TABLA");

            Console.SetCursorPosition(2, 7); t = int.Parse(Console.ReadLine());




            while (c <= 12)
            {

                r = c * t;

                Console.WriteLine(c + "X" + t + "=" + r);

                c = c + 1;

            }


            Console.ReadKey();



        }

        **/

        /*Ejercicio 3
        static void Main(string[] args)


        {

            for (int i = 1; i < 45; i++)
            {
                Console.SetCursorPosition(i, 3); Console.Write("▄");
                Console.SetCursorPosition(i, 5); Console.Write("▄");
                Console.SetCursorPosition(1, 4); Console.WriteLine("digite el numero que desea multiplicar");
            }

            for (int i = 4; i <= 5; i++)
            {

                Console.SetCursorPosition(45, i); Console.WriteLine("▓");
            }
            int rango;

          


            rango = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i< rango; i++)
            {
                Console.WriteLine("----------------TABLA DEL #" + i);

                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i + "x" +  j + "=" + (i + j));
                    Console.WriteLine("");
                }
                
            }
                                 
           Console.ReadKey();
                            
        }
                
        **/

        /*EJERCICIO 4        
        static void Main(string[] args)
        {

            for (int i = 4; i < 100; i++)
            {
                Console.SetCursorPosition(i, 3); Console.Write("▄");
                Console.SetCursorPosition(i, 25); Console.Write("▄");
             
            }
            for (int i = 4; i <= 25; i++)
            {
                Console.SetCursorPosition(4, i); Console.WriteLine("▓");
                Console.SetCursorPosition(99, i); Console.WriteLine("▓");
            }

            Console.SetCursorPosition(50, 8); Console.Write("─────────────────────────────────────── ");
             Console.SetCursorPosition(50, 9); Console.Write("───▐▀▄───────▄▀▌───▄▄▄▄▄▄▄───────────── ");
            Console.SetCursorPosition(50, 10); Console.Write(" ───▌▒▒▀▄▄▄▄▄▀▒▒▐▄▀▀▒██▒██▒▀▀▄──────────");
            Console.SetCursorPosition(50, 11); Console.Write(" ──▐▒▒▒▒▀▒▀▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄────────");
            Console.SetCursorPosition(50, 12); Console.Write(" ──▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▒▒▒▒▒▒▒▒▒▒▒▒▀▄──────");
            Console.SetCursorPosition(50, 13); Console.Write(" ▀█▒▒▒█▌▒▒█▒▒▐█▒▒▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌─────");
            Console.SetCursorPosition(50, 14); Console.Write(" ▀▌▒▒▒▒▒▒▀▒▀▒▒▒▒▒▒▀▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐───▄▄");
            Console.SetCursorPosition(50, 15); Console.Write(" ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌▄█▒█");
            Console.SetCursorPosition(50, 16); Console.Write("▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒█▀─ ");
            Console.SetCursorPosition(50, 17); Console.Write("▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀─── ");
            Console.SetCursorPosition(50, 18); Console.Write("▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌──── ");
            Console.SetCursorPosition(50, 19); Console.Write("─▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐───── ");
            Console.SetCursorPosition(50, 20); Console.Write("─▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌───── ");
            Console.SetCursorPosition(50, 21); Console.Write("──▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐────── ");
            Console.SetCursorPosition(50, 22); Console.Write("──▐▄▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▌────── ");
            Console.SetCursorPosition(50, 23); Console.Write("────▀▄▄▀▀▀▀▀▄▄▀▀▀▀▀▀▀▄▄▀▀▀▀▀▄▄▀──────── ");



            int n = 0;
            int c = 0;

            Console.SetCursorPosition(11, 6); Console.WriteLine(" ╔═════════════════════════╗ ");
            Console.SetCursorPosition(11, 7);  Console.WriteLine(" ║ INGRESE EL NUMERO!..♥   ║ ");
            Console.SetCursorPosition(11, 8); Console.WriteLine(" ╚═════════════════════════╝  ");


            
            Console.SetCursorPosition(11, 10); n = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i < (n +1); i++)
            {

                if (n%i==0)
                {
                    c++;
                }
            }

            if (c!=2)
            {
                Console.SetCursorPosition(11, 9); Console.WriteLine(" ╔═════════════════════════╗ ");
                Console.SetCursorPosition(11, 10); Console.WriteLine(" ║ EL NUMERO NO ES PRIMO.♥ ║  ");
                Console.SetCursorPosition(11, 11); Console.WriteLine(" ╚═════════════════════════╝  ");
            }
            else
            {
                Console.SetCursorPosition(11, 11); Console.WriteLine("  ╔═════════════════════════╗ ");
                Console.SetCursorPosition(11, 12); Console.WriteLine("  ║ EL NUMERO SI ES PRIMO   ║");
                Console.SetCursorPosition(11, 13); Console.WriteLine("  ╚═════════════════════════╝  ");
            }
 
             Console.SetCursorPosition(11, 15); Console.WriteLine("             .:||||||||:.     ");           
             Console.SetCursorPosition(11, 16); Console.WriteLine("           .:            :.  ");            
             Console.SetCursorPosition(11, 17); Console.WriteLine("           (   o      o   )    "); 
             Console.SetCursorPosition(11, 18); Console.WriteLine("   @@@@----------:  :----------@@@@  "); 

            Console.SetCursorPosition(11, 19); Console.WriteLine("      GRACIAS POR USAR EL PROGRAMA ");
            Console.ReadKey();
        }



        **/
        /*EJERCICIO 5 Y 6
        static void Main(string[] args)

        {

            string[] edad = { "12", "50", "23", "11", "18", "35", "41", "85", "16", "45" };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

            string nombreBuscar;
            string salir;
            bool existe = false;
            int posicion = 0;



            do
            {
                Console.Clear();
                ImprimirVector(edad, " Edades");
                ImprimirVector(nombre, "Nombres");
                do
                {
                    Console.WriteLine("Digite El nombre");
                    nombreBuscar = Console.ReadLine();
                    if (nombreBuscar == String.Empty)
                    {
                        Console.WriteLine("El campo no puede esta vacio, ingrese un dato : ");
                    }
                } while (nombreBuscar == String.Empty);


                for (int i = 0; i < nombre.Length; i++)
                {
                    if (nombre[i] == nombreBuscar)
                    {
                        existe = true;
                        posicion = i;
                    }
                }

                if (existe)
                {
                    Console.WriteLine(" El Usuario " + nombreBuscar + " Existe y tiene " + edad[posicion] + " Años de edad");
                }
                else
                {
                    Console.WriteLine(" El Usuario " + nombreBuscar + " No Existe");
                }
                do
                {
                    Console.WriteLine(" \nDesea salir del sistema \n S/s para Salir \n N/n Para volver a buscar");
                    salir = Console.ReadLine();
                    if (salir == String.Empty)
                    {
                        Console.WriteLine("Porfavor digite un opcion valida");
                    }

                } while (salir != "S" && salir != "N" && salir != "s" && salir != "n");

            } while (salir != "S" && salir != "s");



        }

        static void ImprimirVector(Array vector, string titulo)
        {
            Console.WriteLine("\n Arreglo " + titulo);

            foreach (string elemento in vector)
            {
                Console.Write("[ " + elemento + " ] ");
            }
            Console.WriteLine("\n");


        }
        **/

        /* EJERCICIO 7

        static void Mayor_menor()

		{
			Console.Clear();


			int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
			string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
			int em = 0, ea = 100, pem = 0, pea = 0;
            for (int i = 0; i<edad.Length; i++)
            {
                if (edad[i] > em)
                {
                    em = edad[i];
                    pem = i;
                }
                if (edad[i] < ea)
                {
                    ea = edad[i];
                    pea = i;
                }
            }
				
				Console.WriteLine("Persona mayor es : " + nombres[pem] + " Edad : " + em + " años  ");
				Console.WriteLine("Persona menor es : " + nombres[pea] + " Edad : " + ea + " años  ");
				
            
        }

        */

        /* EJERCICIO 8
        static void Main(string[] args)
        {
            string palabra, inverso, caracter;

            int i;

            Console.WriteLine("palabra que desea invertir");
            palabra = Convert.ToString(Console.ReadLine());

            i = palabra.Length;
            inverso = "";
            for (int x=i = 1; x >= 0  ; x=i++)
            {
                caracter = palabra.Substring(x, 1);

                inverso = inverso + caracter;

            }
            if (palabra == inverso)
            {
                Console.WriteLine("ES PALINDROMIE");
            }
            else
            {
                Console.WriteLine("NO ES PALINDROMIE");
            }

            Console.ReadKey();

        }
        **/


        /* EJERCICO 9
        static void Main(string[] args)
        {

            byte cant;
            int a=0, b=1, c;
           


            string aux;
            Console.WriteLine("Cuantos numeros FIBONACCI desea generar?...");

            aux = Console.ReadLine();
            cant = byte.Parse(aux);

            Console.Write("LA SERIE ES:" +a + " " + b + " ");

            for (int i = 3; i <=cant ; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
            Console.WriteLine();
            Console.Write("PRESIONE UNA TECLA PARA SALIR...");
            Console.ReadKey();
        }
        **/




        static void Main(string[] args)
        {
                      
            Console.SetCursorPosition(30, 8); Console.Write(" _____________§_§§_______§__§_____§§__§_________________ ");
            Console.SetCursorPosition(30, 9); Console.Write(" ____________§___§§§____§___§__§§_____§_________________ ");
            Console.SetCursorPosition(30, 10); Console.Write(" ____________§_____§§§_§____§_§§______§______§§_________ ");
            Console.SetCursorPosition(30, 11); Console.Write(" _____________§_______§§_____§________§__§§§§_§_________");
            Console.SetCursorPosition(30, 12); Console.Write(" _____________§_______________________§§§_____§_________");
            Console.SetCursorPosition(30, 13); Console.Write(" _____________§______________________________§__________");
            Console.SetCursorPosition(30, 14); Console.Write(" ___§§§§§§_____§_____________________________§__________");
            Console.SetCursorPosition(30, 15); Console.Write(" ____§______§§§_____________________________§___________");
            Console.SetCursorPosition(30, 16); Console.Write(" ____§§_____________________________________§§§_________");
            Console.SetCursorPosition(30, 17); Console.Write(" _____§________________________________________§§§§_____");
            Console.SetCursorPosition(30, 18); Console.Write(" ______§________________________________________ _§§_____");
            Console.SetCursorPosition(30, 19); Console.Write("_______§_______________________________________§_______ ");
            Console.SetCursorPosition(30, 20); Console.Write(" _______§§____________________§_______________§§________");
            Console.SetCursorPosition(30, 21); Console.Write(" _______§_____________§§§§§§§§§_______________§_________");
            Console.SetCursorPosition(30, 22); Console.Write(" ______§_____________§§§§§§§§§§§_______§_______§§_______");
            Console.SetCursorPosition(30, 23); Console.Write(" ____§§____________§§§§§§§§§§§§§§________________§§_____");
            Console.SetCursorPosition(30, 24); Console.Write(" ___§_____________§§§§§§____§§§§§§___§___§_________§§___");
            Console.SetCursorPosition(30, 25); Console.Write(" __§_____________§§§§§______§§§§§§____§__§§__________§__");
            Console.SetCursorPosition(30, 26); Console.Write(" §§_____________§§§§__§______§§§§§§§__§§__§________§§___");
            Console.SetCursorPosition(30, 27); Console.Write(" §_____________§§§§__§§______§§§§§§§__§§§_§§___§§§§_____");
            Console.SetCursorPosition(30, 28); Console.Write(" ______________§§§__§_§§_____§§§§§§§§__§§§_§§__§________");
            Console.SetCursorPosition(30, 29); Console.Write(" _____________§§§___§§§_____§§§§§§§§§§_§§§§§§§__§_______");
            Console.SetCursorPosition(30, 30); Console.Write(" _____________§§____§§§____§§§§§§§§§_§§§§§§§§§___§______");
            Console.SetCursorPosition(30, 31); Console.Write(" §§§__________§_____§§§§_§§§§§§________§__§§§§§___§_____");
            Console.SetCursorPosition(30, 32); Console.Write(" ___§§_______§§§____§§_§§§§§§§_____________§§§§§__§§____");
            Console.SetCursorPosition(30, 33); Console.Write(" ____§_______§§§§___§_§§§§§__§________§____§§§§§§§§§§§§§");
            Console.SetCursorPosition(30, 34); Console.Write(" ___§___§____§§§§§__§§§§§§__§______§§§________§__§§§§§§§");
            Console.SetCursorPosition(30, 35); Console.Write(" ___§___§____§§§§§§§§§§§___§_____§§_________§_§§_§§§§§§§");
            Console.SetCursorPosition(30, 36); Console.Write(" __§____§____§§§§§§§§§§_________§§______§§§§§_§§__§§§§§§");
            Console.SetCursorPosition(30, 37); Console.Write(" _§_____§____§§§§§§§§§__________§______§_____§§§__§__§§§");
            Console.SetCursorPosition(30, 38); Console.Write(" _§____§§____§§§§§§§§§_______________________§§§__§_____");
            Console.SetCursorPosition(30, 39); Console.Write(" §______§____§§§§§§§§§§§§§____________________§§§_§_____");
            Console.SetCursorPosition(30, 40); Console.Write(" ___§§§§_____§§§§§§_______§______________§§_§§§_§§______");
            Console.SetCursorPosition(30, 41); Console.Write(" ______§__§__§§§§§§_§§§§§_____________________§§_§§_____");
            Console.SetCursorPosition(30, 42); Console.Write(" ______§_§§__§§§§§_§§_§§_§_____________________§§_§§____");
            Console.SetCursorPosition(30, 43); Console.Write(" ______§_§_§_§§§§§_§_§§§§§_________________§§§____§§____");
            Console.SetCursorPosition(30, 44); Console.Write(" ______§_§_§_§§§§§_§_§§§§_____________________§____§____");
            Console.SetCursorPosition(30, 45); Console.Write(" ______§§§_§§§§§§§_§§§§§§_______§_____§§§________§__§___");
            Console.SetCursorPosition(30, 46); Console.Write(" ______§§§__§_§§§§__§§§§______§_____§§_________§§§_§§§__");
            Console.SetCursorPosition(30, 47); Console.Write(" ______§_§___§_§_§___________§_____§___§§§_____§§__§§§§§");
            Console.SetCursorPosition(30, 48); Console.Write(" ________§__§§____§______________§§__§§__§_____§§§_§§§§§");
            Console.SetCursorPosition(30, 49); Console.Write(" __________§____§_§§____________§§__§___§______§_§§_§§§§");
            Console.SetCursorPosition(30, 50); Console.Write(" _________§§_____§_§_§_________§§_§§__§§_______§__§§§_§§");
            Console.SetCursorPosition(30, 51); Console.Write(" _________§_______§_§__________§_§___§________§§__§§§___");
            Console.SetCursorPosition(30, 52); Console.Write(" _________________§§§_________§_§__§§_________§§__§§§§__");
            Console.SetCursorPosition(30, 53); Console.Write(" _________________§_§§_§_____§_§_§§___________§§_§§§§§__");
            Console.SetCursorPosition(30, 54); Console.Write(" __________________§§§§§_____§§§§_____§______§§§§§§§§§__");
            Console.SetCursorPosition(30, 55); Console.Write(" ___________________§§§____________§§§______§§§§§§§§§§§_");
            Console.SetCursorPosition(30, 56); Console.Write(" ____________________§§§__§________________§§§§§§§§§§§§§");
            Console.SetCursorPosition(30, 57); Console.Write(" _____________________§§§_§_______________§§§§§§§§§§§§§§");
            Console.SetCursorPosition(30, 58); Console.Write(" ______________________§_§§______________§§§§§§§§§§§§§§§");
            Console.SetCursorPosition(30, 59); Console.Write(" ________________________§§§____________§§§§§§§§§§§§§§§§");
            Console.SetCursorPosition(30, 60); Console.Write(" __________________________§§§§________§§§§§§§§§§§§§§§§§");
            Console.SetCursorPosition(30, 61); Console.Write(" _____________________________§§§§__§§§§§§§§§§§§§§§§§§§§");
            Console.SetCursorPosition(30, 23); Console.Write(" ");
            Console.SetCursorPosition(30, 23); Console.Write(" ");




            Console.ReadKey();
        }

    }
}
