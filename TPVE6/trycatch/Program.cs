using System;

namespace trycatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boolean xd = true;
            int option = 0;
            //clases
            catch_cases error_mesages = new catch_cases();

            //menu
            while(xd){
                Console.WriteLine("--- Menu ---\n");
                Console.WriteLine("1) Division entre 0 (defecto) \n" +
                                  "2) Division entre 0 (personalizado) \n" +
                                  "3) String nulo \n" +
                                  "4) Uso de archivo no encontrado \n" +
                                  "5) Salir \n");
                Console.WriteLine("Ingrese una opcion: ");
                String owo = Console.ReadLine();

                try
                {
                    option = Convert.ToInt32(owo);
                    switch (option)
                    {
                        case 1:
                            error_mesages.caso_1();
                            Console.WriteLine("");
                        break;
                        case 2:
                            error_mesages.caso_2();
                            Console.WriteLine("");
                            break;
                        case 3:
                            error_mesages.caso_3();
                            Console.WriteLine("");
                            break;
                        case 4:
                            error_mesages.caso_4();
                            Console.WriteLine("");
                            break;
                        case 5:
                            xd = false;
                            break;
                        default:
                            Console.WriteLine("La opcion ingresada no existe");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Debes ingresar un numero ", e.ToString());
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
