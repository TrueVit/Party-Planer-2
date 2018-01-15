using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planer_2
{
    class BirthdayParty:Party
    {
        const int numberOfPeopleToLittleCacke = 4;
        const int maxLettersOnLiitleCake = 16;
        const decimal costOfLittleCacke = 40M;
        const int maxLettersOnBigCake = 40;
        const decimal costOfBigCake = 75M;
        const decimal costOfLetter = 0.25M;

       public string CakeWritting;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations,
            string cakeWritting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWritting = cakeWritting;
        }

        private int maxCakeWrittingLength
        {
            get
            {
                if (NumberOfPeople > numberOfPeopleToLittleCacke)
                    return maxLettersOnBigCake;
                else
                    return maxLettersOnLiitleCake;
            }
        }

        public bool TooLong {
            get
            {
                if (CakeWritting.Length > maxCakeWrittingLength)
                    return true;
                else
                    return false;
                    
            }
        }

        private int actualLength
        {
            get
            {
                if (CakeWritting.Length > maxCakeWrittingLength)
                    return maxCakeWrittingLength;
                else
                    return CakeWritting.Length;
            }
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost;
                totalCost = NumberOfPeople * CostOfFoodPerPerson;
                totalCost += CalculateCostOfCake();
                totalCost += CalculateCostOfDecorations();
                return totalCost;
            }
        }
        
        private decimal CalculateCostOfCake()
        {
            decimal costOfCacke;
            if (NumberOfPeople > numberOfPeopleToLittleCacke)
                costOfCacke = costOfBigCake;
            else
                costOfCacke = costOfLittleCacke;
            costOfCacke += actualLength * costOfLetter;
            return costOfCacke;
        }

    }
}
