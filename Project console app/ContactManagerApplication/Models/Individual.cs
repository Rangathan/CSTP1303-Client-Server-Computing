using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Individual : Contact
    {
        // Additional properties specific to an individual
        public Company Employer { get; set; }
    }
}
