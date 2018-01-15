﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planer_2
{
    class Party
    {
        protected const decimal CostOfFoodPerPerson = 25M;
        protected const decimal CostOfUsualDecorations = 7.5M;
        protected const decimal UsusaDecorationFee = 30M;
        protected const decimal CostOfFancyDecorations = 15;
        protected const decimal FancyDecorationsFee = 50M;

        public int NumberOfPeople;
        public bool FancyDecorations;

        //public decimal Cost;

        protected virtual decimal CalculateCostOfDecorations()
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
    }
}