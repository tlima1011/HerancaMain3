using System;
using System.Globalization;
using System.Collections.Generic;
using HerancaMain3.Entities;

namespace HerancaMain3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> tp = new List<TaxPayer>();

            double sum = 0.0; 

            Console.Write("Enter the number of tax payers: "); 
            int n = int.Parse(Console.ReadLine()); 

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write("Individual or Company (i/c): ");
                char op = char.Parse(Console.ReadLine());
                op = char.ToLower(op);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: "); 
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                switch (op)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        tp.Add(new Individual(name, anualIncome, healthExpenditures));  
                        break;
                    case 'c':
                        Console.Write("Number of employees:");
                        int ne = int.Parse(Console.ReadLine());
                        tp.Add(new Company(name, anualIncome, ne));
                        break;
                }
            }
            Console.WriteLine("\nTAXES PAID: ");
            foreach(TaxPayer t in tp)
            {
                Console.WriteLine(t);
            }

            foreach (TaxPayer t in tp)
            {
                sum += t.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}