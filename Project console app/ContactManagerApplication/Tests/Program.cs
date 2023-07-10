using Models;
using System;
using System.Collections.Generic;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyWithTitle company = new CompanyWithTitle
            {
                Name = "Example Company",
                // Set other company properties...
            };

            Individual individual1 = new Individual
            {
                Name = "John Doe",
                // Set other individual properties...
                Employer = company
            };

            Individual individual2 = new Individual
            {
                Name = "Jane Smith",
                // Set other individual properties...
                Employer = company
            };

            company.Employees = new List<Individual> { individual1, individual2 };

            // Adding related companies to an individual
            individual1.RelatedCompanies = new List<Company> { company };

            // Adding related individuals to a company
            company.RelatedIndividuals = new List<Individual> { individual1, individual2 };

            Console.WriteLine(company.Name);
        }
    }
}
