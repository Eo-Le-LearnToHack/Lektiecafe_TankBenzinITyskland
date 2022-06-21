using System;



namespace Skal_man_køre_til_tyskland

{

    class program

    {

        static void Main(string[] args)

        {
            Console.WriteLine("Indtast antal kilometer til Tyskland");

            decimal Antal_kilometer = Convert.ToDecimal(Console.ReadLine()); //Rettet fra Convert.ToInt32(Console.ReadLine()

            Console.WriteLine("Pris på brændstof i Danmark?");

            decimal Pris_DK = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Pris på brændstof i Tyskland?");

            decimal Pris_De = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Antal kilometer din bil kører pr. liter?"); //rettet fra 2Antal kilometer din bil kører pr. liter?"

            decimal Antal_KM = Convert.ToDecimal(Console.ReadLine()); //rettet fra Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Hvor mange liter, kan du tanke?");

            decimal Hvor_meget = Convert.ToDecimal(Console.ReadLine()); //rettet fra int Hvor_meget = Convert.ToInt32(Console.ReadLine())



            decimal Pris_til_Tyskland = ((Antal_kilometer * 2) / Antal_KM) * Pris_DK; //antaget at prisen for tur/retur betales med benzinpriser i Danmark


            decimal Pris_i_Danmark = (Hvor_meget * Pris_DK); //rettet fra "Hvor_meget * Pris_DK"

            decimal Pris_i_Tyskland = (Pris_til_Tyskland + Hvor_meget * Pris_De);

            decimal resultat = Pris_i_Danmark - Pris_i_Tyskland; //tilføjet ny variabel

            //if (Pris_i_Tyskland < Pris_i_Danmark)

            //{

            //    Console.WriteLine("Du skal køre til Tyskland, da du vil spare" + ' ' + string.Format("{0:0.00}", (Pris_i_Tyskland - Pris_i_Danmark)));

            //}

            //else

            //{

            //    Console.WriteLine("Du skal blive, da det der vil koste dig" + ' ' + string.Format("{0:0.00}", (Pris_i_Tyskland - Pris_i_Danmark)) + ' ' + "ekstra");

            //}

            if (resultat > 0)
            {
                Console.WriteLine($"Du vil spare {resultat:C2}");
            }
            else
            {
                Console.WriteLine($"Det vil koste dig {Math.Abs(resultat):C2}");
            }

            Console.ReadLine();

        }

    }

}