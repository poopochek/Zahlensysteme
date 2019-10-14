using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            int auswahl;
            string nochmal;
            do
            {
                Console.WriteLine("Zahlensysteme in verschidene Systeme umwandeln.");
                Console.WriteLine("1: Dezimal zu Binär");
                Console.WriteLine("2: Binär zu Dezimal");
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.WriteLine("Dezimalzahl eingeben:");
                    int dez = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(dez + " in binär: " + Von10zu2(dez));

                }
                else if (auswahl == 2)
                {
                    Console.WriteLine("Binärzahl eingeben:");
                    string bin =Console.ReadLine();
                    Console.WriteLine(bin + " in dezimal: " + Von2zu10(bin));
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte 1 oder 2 wählen!");
                }
                Console.WriteLine("Neue Zahl umrechnen? (j/n)");
                nochmal = Console.ReadLine();
            } while (nochmal == "j" || nochmal == "J");


        }

        static string Von10zu2(int dez)
        {
            string bin = "";
            int Q, R, Z;
            Z = dez;
            Q = 1;
            while (Q != 0)
            {
                Q = Z / 2;
                R = Z % 2;
                bin += Convert.ToString(R);
                // bin = bin + ...
                Z = Q;
            }

            return Umkehren(bin);
        }

        static string Umkehren(string bin)
        {
            string b_u = "";
            for (int i = bin.Length - 1; i >= 0; i--)
            { 
                b_u += bin[i];
            }
            return b_u;
        }

        static double Von2zu10(string bin)
        {
            double Z=0, S, E;
            for (int i=0; i<bin.Length; i++)
            {
                S = Convert.ToDouble(Convert.ToString(bin[i]));
                E = Convert.ToDouble(bin.Length - 1 - i);
                Z += S * Math.Pow(2, E);
            }
            return Z;

        }
        

        
    }
}
