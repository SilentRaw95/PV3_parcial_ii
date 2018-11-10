using System;
using System.IO;∫
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace trycatch
{
    public class catch_cases
    {
        public catch_cases()
        {

        }

        public void caso_1(){
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("ArithmeticException Handler: {0}", e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Generic Exception Handler: {0}", e.ToString());
            }
        }

        public void caso_2()
        {
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Error aritmetico intentaste dividir entre 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("Generic Exception Handler: {0}", e.ToString());
            }
        }

        public void caso_3()
        {
            try
            {
                string s = null;
                ProcessString(s);
            }
            // Most specific:
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} First exception caught.", e);
            }
            // Least specific:
            catch (Exception e)
            {
                Console.WriteLine("\n estas procesando un string nulo \n");
                Console.WriteLine("{0} Second exception caught.", e);
            }
        }

        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }

        public void caso_4()
        {
            try
            {
                StreamReader sr = File.OpenText("data.txt");
                Console.WriteLine("The first line of this file is {0}", sr.ReadLine());
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("El archivo no existe", e);
            }
        }
    }
}
