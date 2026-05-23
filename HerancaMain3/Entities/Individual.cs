using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMain3.Entities
{
    internal class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures; 
        }

        public override double Tax()
        {
            return (AnualIncome < 20000.0) ? (AnualIncome * 0.15) - (HealthExpenditures * 0.5) : (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }
    }
}
