using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planer_2
{
    class DinnerParty : Party 
    {
        private const decimal CostOfAlcoholicDrink = 20M;
        private const decimal CostOfNonAlcoholicDrink = 5M;
        private const decimal DiscountOfHealthyOption = 0.05M;

        public bool HealthyOption;

        public DinnerParty (int numberOfPeople, bool fancyDecorations, 
            bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;

        }
        public override decimal Cost
        {
            get
            {
                decimal totalCost;
                totalCost = base.Cost;
                totalCost += CalculateCostOfDrinks();
                if (HealthyOption)
                    totalCost *= (1 - DiscountOfHealthyOption);
                totalCost += CalculateCostOfDecorations();
                return totalCost;
            }
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
