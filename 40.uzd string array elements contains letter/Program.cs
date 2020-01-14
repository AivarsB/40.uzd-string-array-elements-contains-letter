using System;

namespace _40.uzd_string_array_elements_contains_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jānis", "Pēteris", "Andris", "Sergejs", "antons" };

            foreach (var name in names)
            {
                if (name.Contains('a') || name.Contains('ā') || name.Contains('A'))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
// Definēt string tipa masīvu ar vērtībām “jānis”, “pēteris”, “andris”, “sergejs”, “antons”. 
// Izdrukāt uz ekrāna tikai tos vārdus, kuros ir atrodams burts “a” vai “ā”. Šim nolūkam var izmantot string metodi Contains.