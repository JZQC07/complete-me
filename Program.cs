using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complete_me
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        public static void Menu()
        {
            Random slumpat = new Random();
            int speltal = slumpat.Next(1, 20); //Här behöver vi bestämma rangen för de slumpade numrena.
            int inttal = 0;
            string tal = "";

            while (true) //Loopen skall köras när spela inte är true (false)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                Console.WriteLine("Mata när som helst in Q för att avsluta programmet.");
                tal = Console.ReadLine();
                if (tal == "q" || tal == "Q")
                {
                    Console.WriteLine("Du valde att avsluta programmet...");
                    Console.WriteLine("Progarmmet avlsutas!");
                    System.Environment.Exit(0);
                }
                try
                {
                    inttal = int.Parse(tal); //Försöker parsa, om det inte går har användaren
                }                                        //inte matat en siffra..
                catch
                {
                    Console.WriteLine("Fel format"); //Här skall finnas throw!
                }
                if (speltal > inttal && inttal < 1)
                {
                    Console.WriteLine("Ditt angivna tal måste vara större än 0!");
                }
                else if (speltal > inttal)
                {
                    Console.WriteLine("\tDet inmatade talet " + inttal + " är för litet, försök igen.");
                }
                else if (inttal > speltal && inttal > 20)
                {
                    Console.WriteLine("Ditt inmatade tal får inte vara större än 20!");
                }
                else if (inttal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + inttal + " är för stort, försök igen.");
                }
                else if (inttal == speltal)
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    Console.WriteLine("För att spela igen, mata in valfri tangent.");
                    Console.WriteLine("Annars mata in Q.");
                    string avsluta = Console.ReadLine().ToUpper();
                    if(avsluta == "Q")
                    {
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Menu();
                    }
                }
            }
        }
    }
}
