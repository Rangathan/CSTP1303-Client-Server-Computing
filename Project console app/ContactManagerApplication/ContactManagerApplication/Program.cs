﻿using ContactStorageDiskService;
using Abstractions;
using Abstractions;
using Models;
using System;
using System.Collections.Generic;

namespace ContactManagerApplication
{
    internal class Program
    {
        private IStorage contactStorage = new Storage(10, 2);
        static void Main(string[] args)
        {

           
            int choice;
            Program program = new Program();
            do
            {
                Console.WriteLine("Welcome to Contact Manager Service");
                Console.WriteLine("__________________________________");
                Console.WriteLine("Please Choose an option:\n1) Create a new Contact\n2) Search for a Contact\n3) List all Contacts" +
                    "\n4) Save and Load from Server\n5) Quit Application");
                Console.WriteLine("__________________________________");
                string input = Console.ReadLine();

                int.TryParse(input, out choice);
                switch (choice)
                {
                    case 1:
                        program.createContact();
                        break;
                    case 2:
                        program.searchContact();
                        break;
                    case 3:
                        program.listAllContacts(); 
                        break;
                    case 4:

                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

            }
            while (choice != 5);
        }

        public void createContact()
        {
            int choice;
            do
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Choose an option for Contact Creation");
                Console.WriteLine("1) Company\n2) An individual\n3) Quit");
                Console.WriteLine("_____________________________________");
                string input = Console.ReadLine();
                int.TryParse(input, out choice);
                switch (choice)
                {
                    case 1:
                        createCompanyContact();
                        break;
                    case 2:
                        createIndividualContact();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 3);
        }

        public void createCompanyContact()
        {
            Console.WriteLine("Enter Company Contact Details:");
            Console.WriteLine("ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Address:");
            // Add more properties as needed.
            string address = Console.ReadLine();
            // Create a new company contact object
            IContact companyContact = new Company(id, name, address);

        // Add the company contact to the storage
            contactStorage.Create(companyContact);

            Console.WriteLine("Company Contact created successfully!");
        }

        public void createIndividualContact()
        {
            Console.WriteLine("Enter Individual Contact Details:");
            Console.WriteLine("ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Address:");
            // Add more properties as needed.
            string address = Console.ReadLine();
            // Add more properties as needed.

            // Create a new individual contact object
            IContact individualContact = new Individual(id, name, address);


            // Add the individual contact to the storage
            contactStorage.Create(individualContact);

            Console.WriteLine("Individual Contact created successfully!");
        }

        public void searchContact()
        {
            Console.WriteLine("Enter the ID of the Contact to search:");
            string idToSearch = Console.ReadLine();
            IContact contact = contactStorage.Retrieve(idToSearch);
            if (contact != null)
            {
                Console.WriteLine("Contact Found:");
                Console.WriteLine($"ID: {contact.Id}, Name: {contact.Name}, Address: {contact.Address}");
                // Print other properties if needed.
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
        }

        public void listAllContacts()
        {
            List<IContact> allContacts = contactStorage.ListAll();
            if (allContacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                Console.WriteLine("All Contacts:");
                foreach (var contact in allContacts)
                {
                    Console.WriteLine($"ID: {contact.Id}, Name: {contact.Name}");
                    // Print other properties if needed.
                }
            }
        }




    }
}
