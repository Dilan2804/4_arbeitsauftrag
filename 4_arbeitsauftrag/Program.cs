using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_arbeitsauftrag
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beispiel 1
            int zahl = 3;

            string[] Name = new string[zahl];

           
            zahl = zahl + 1;

            try
            {
                int i = 0;
                int d = 0;

                while (i < zahl)
                {
                    Console.WriteLine("Geben Sie einen Namen ein");
                    string name1 = Console.ReadLine();
                    Name[d] = name1;

                    i++;
                    d++;
                }

            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }





            //Beispiel 2
            int zahl1 = 10;
            int zahl2 = 0;

            try
            {
                Console.WriteLine(zahl1/zahl2);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            //Beispiel 3

            try
            {
                Console.WriteLine("Geben Sie eine Zahl ein: ");
                int nr1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben Sie eine weiter Zahl ein: ");
                int nr2 = Convert.ToInt32(Console.ReadLine());
                
                if (nr1 == 10 || nr2 == 10)
                {
                    throw new Exception("10 ist nicht erlaubt");
                }
                else
                {
                    Console.WriteLine(nr1 + nr2);
                }               
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }






        }
    }
}
