using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMain3.Entities
{
    internal class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }
        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees; 
        }

        public override double Tax()
        {
           return (NumberOfEmployees < 10) ? (AnualIncome * 0.16) : (AnualIncome * 0.14);
        }
    }
}
