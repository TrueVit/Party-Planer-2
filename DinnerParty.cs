using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planer_2
{
    class DinnerParty
    {
        private const decimal CostOfFoodPerPerson = 25M;
        private const decimal CostOfAlcoholicDrink = 20M;
        private const decimal CostOfNonAlcoholicDrink = 5M;
        private const decimal DiscountOfHealthyOption = 0.05M;
        private const decimal CostOfUsualDecorations = 7.5M;
        private const decimal UsusaDecorationFee = 30M;
        private const decimal CostOfFancyDecorations = 15;
        private const decimal FancyDecorationsFee = 50M;

        public DinnerParty (int numberOfPeople, bool fancyDecorations, 
            bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;

        }

        public int NumberOfPeople;
        public bool FancyDecorations;
        public bool HealthyOption;

        public decimal Cost
        {
            get
            {
                decimal totalCost;
                totalCost = NumberOfPeople * CostOfFoodPerPerson;
                totalCost += CalculateCostOfDrinks();
                if (HealthyOption)
                    totalCost *= (1 - DiscountOfHealthyOption);
                totalCost += CalculateCostOfDecorations();
                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal CostOfDecorations;
            if (FancyDecorations)
            {
                CostOfDecorations = NumberOfPeople * CostOfFancyDecorations;
                CostOfDecorations += FancyDecorationsFee;
            }
            else
            {
                CostOfDecorations = NumberOfPeople * CostOfUsualDecorations;
                CostOfDecorations += UsusaDecorationFee;
            }
            return CostOfDecorations;
        }

        private decimal CalculateCostOfDrinks()
        {
            decimal CostOfDrinks;
            if (HealthyOption)
                CostOfDrinks = NumberOfPeople * CostOfNonAlcoholicDrink;
            else
                CostOfDrinks = NumberOfPeople * CostOfAlcoholicDrink;
            return CostOfDrinks;
        }
    }
}
