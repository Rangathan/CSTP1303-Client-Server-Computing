using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Company : Contact
    {
        // Additional properties specific to a company
        public List<Individual> Employees { get; set; }
    }
}
