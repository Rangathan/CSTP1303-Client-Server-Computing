using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class PhoneNumber
    {
        public string Number { get; set; }
        public string Title { get; set; }
    }

    public class Email
    {
        public string Address { get; set; }
        public string Title { get; set; }
    }
    public abstract class Contact
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<Email> Emails { get; set; }
        public List<Company> RelatedCompanies { get; set; }
        public List<Individual> RelatedIndividuals { get; set; }
    }
}
