using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SegundParcial
{
    class MainClass
    {
        //el archivo se encuentra en bin y debug
        static readonly object firstLock = new object();
        static String bottomText = "";
        static Stopwatch contador;

        static void ThreadJob()
        {
            contador = Stopwatch.StartNew();
            while(bottomText.Equals("")){
                //EVITAR QUE ACABE EL HILO
            }
            contador.Stop();
            Console.WriteLine("Tardaste: " + contador.Elapsed.Seconds + " segundos");
        }

        public static void Main(string[] args)
        {
            Boolean menu = true;
            int op;

            while(menu){
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1) Escribir");
                Console.WriteLine("2) Leer");
                Console.WriteLine("3) Salir");
                Console.WriteLine("Opcion: ");
                op = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                switch (op){
                    case 1:
                        Console.WriteLine("Escribe: ");
                        new Thread(new ThreadStart(ThreadJob)).Start();
                        bottomText = Console.ReadLine();
                        string file = "exam.txt";
                        if (!File.Exists(file))
                        {
                            // Create a file to write to.
                            using (StreamWriter sw = File.CreateText(file))
                            {
                                sw.WriteLine(bottomText);
                            }
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText(file))
                            {
                                sw.WriteLine(bottomText);
                            }
                        }
                        bottomText = "";
                        break;
                    case 2:
                        string fileowo = "exam.txt";
                        if (!File.Exists(fileowo))
                        {
                            Console.WriteLine("El archivo no existe aun escribe algo primero");
                        } else {
                            using (StreamReader sr = File.OpenText(fileowo))
                            {
                                string s = "";
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                            }
                            Console.WriteLine("termino el archivo");
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
                Console.Read();
            }
        }
    }
}
