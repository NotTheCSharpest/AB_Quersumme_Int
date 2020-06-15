using System;

namespace AB_Quersumme
{
    class Program
    {
        static void Main(string[] args)
        {
            // quersumme - int Aufgabe
            Console.WriteLine("Bitte Ihre Quersumme eingeben");
            string eingabe = Console.ReadLine();
            int quersumme = 0;
            string ziffer;
            for (int i = 0; i < eingabe.Length; i++)
            {
                ziffer = Char.ToString(eingabe[i]);
                //Console.WriteLine("ziffer ist jetzt: {0}", ziffer)
;                quersumme = (quersumme + int.Parse(ziffer));
                //Console.WriteLine("quersumme ist jetzt: {0}", quersumme);
            }
            Console.WriteLine("Ihre Quersumme ist: {0}", quersumme);

        }
    }
}
