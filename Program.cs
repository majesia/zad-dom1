using System;
using System.Collections.Generic;

namespace zaddom1
{
    class Program
    {
        static void Main(string[] args)
        {
            String dinozaur = "dinozaur";
            char x;
            int dlugosc = dinozaur.Length;
            int pozostalo = dlugosc;
            List<char> haslo = new List<char>();
            List<char> zgadywane = new List<char>();

            for(int i=0; i < dlugosc; i++) haslo.Add(dinozaur[i]);
        

            for(; ; )
            {
                Console.WriteLine("Haslo: ");
                for (int i = 0; i < dinozaur.Length; i++)
                {
                    if (zgadywane.Contains(haslo[i])) Console.Write(haslo[i]);
               
                    else Console.Write("#");
                }

                Console.Write("\nPodaj litere aby zgadnac haslo: ");
                x = char.Parse(Console.ReadLine());

                if (zgadywane.Contains(x))
                {
                    Console.WriteLine("Podana litera zostala podana wczesniej, wybierz inna.");
                    continue;
                }
                else zgadywane.Add(x);

                if (haslo.Contains(x))
                {
                    Console.WriteLine("Brawo, litera " + x + " znajdowała sie w hasle");
                    int ile=0;
                    for(int i =0; i < dlugosc; i++)
                    {
                        if (haslo[i] == x) ile++;
                    }
                    pozostalo -= ile;
                }

                if (pozostalo== 0)
                {
                    Console.WriteLine("Odgadles wszytskie litery hasla " + dinozaur + ". Gratulacje i dziekuje za gre!");
                    break;
                }

            }



        }
    }
}
