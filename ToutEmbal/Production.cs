using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToutEmbal
{
    public class Production 
    {
        public double faultsRateOfLastHour;
        public double maxFaultsInOneHour;
        public double nbrOfBoxes_typeA, nbrOfBoxes_typeB, nbrOfBoxes_typeC;
        public double faultsRateSBegining;
        public double nbrOfBreakedBoxes = 0;
        public double nbrOfBoxesSBegining = 0;
        public int compteur = 0;


        public Production()
        {
           
            nbrOfBoxes_typeA = 10000;
            nbrOfBoxes_typeB = 25000;
            nbrOfBoxes_typeC = 120000;
            maxFaultsInOneHour = 20/100.00;

        }
        public void RunProduction(double _nbrOfBoxes)
        {
            double typeOfBoxes = 0;
            if (_nbrOfBoxes == 1000)
                typeOfBoxes = nbrOfBoxes_typeA;
            else if (_nbrOfBoxes == 5000)
                typeOfBoxes = nbrOfBoxes_typeB;
            else if (_nbrOfBoxes == 10000)
                typeOfBoxes = nbrOfBoxes_typeC;

            if ((nbrOfBoxesSBegining < typeOfBoxes)
                || (_nbrOfBoxes > (typeOfBoxes - nbrOfBoxesSBegining))
                )
            {

                if (_nbrOfBoxes > (typeOfBoxes - nbrOfBoxesSBegining))
                    _nbrOfBoxes = (typeOfBoxes - nbrOfBoxesSBegining);

                compteur++;
                for (int i = 0; i < _nbrOfBoxes; i++)
                {
                    Boxes boxes = new Boxes();

                    if (!Alea())
                        nbrOfBreakedBoxes++;
                    else
                        nbrOfBoxesSBegining++;

                }
                if (nbrOfBoxesSBegining > 0)
                {
                    faultsRateOfLastHour = (((nbrOfBreakedBoxes * 100) / nbrOfBoxesSBegining) / compteur) / 100;
                    faultsRateSBegining = ((nbrOfBreakedBoxes * 100) / nbrOfBoxesSBegining) / 100;
                }
            }
        }
        
        public bool Alea()
        {
            Random random = new Random();
            int alea = random.Next(101);
            if (alea <= 20)
                return false;
            else
                return true;

        }
    }
}
