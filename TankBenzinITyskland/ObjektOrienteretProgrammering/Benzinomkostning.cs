using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrienteretProgrammering
{
    internal class Benzinomkostning
    {
        public double Totalomkostning_resultat {get; set;}
        public double OmkostningVedAtTankeIDanmark_resultat { get; set; }


        public double Totalomkostning(double afstandTilTyskland, double bilensBenzinForbrug, double benzinPrisIDanmark, double benzinPrisITyskland, double benzinTankKapacitet)
        {
            Totalomkostning_resultat = ((afstandTilTyskland * 2) / bilensBenzinForbrug) * benzinPrisIDanmark + (benzinTankKapacitet * benzinPrisITyskland);
            return Totalomkostning_resultat;
        }

        public double OmkostningVedAtTankeIDanmark(double benzinTankKapacitet, double benzinPrisIDanmark)
        {
            OmkostningVedAtTankeIDanmark_resultat = benzinTankKapacitet * benzinPrisIDanmark;
            return OmkostningVedAtTankeIDanmark_resultat;
        }

        public void Difference()
        {
            double resultat = OmkostningVedAtTankeIDanmark_resultat - Totalomkostning_resultat;
            Console.WriteLine($"regnestykket giver: {resultat:C2}");
            if (resultat > 0)
            {
                Console.WriteLine($"Du vil spare {resultat:C2}");
            }
            else
            {
                Console.WriteLine($"Det vil koste dig {Math.Abs(resultat):C2}");
            }
        }


    }
}
