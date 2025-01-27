﻿using System;
using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Methods
{
    public class CustomerMethods
    {
        public void CreateCustomer()

        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Customer customer = new Customer();

            Console.WriteLine("Please, enter the First Name for a customer.");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please, enter the Last Name for a customer.");
            string LastName = Console.ReadLine();
            Console.WriteLine("Please, enter the Email for a customer.");
            string Email = Console.ReadLine();
            Console.WriteLine("Please, enter the Address for a customer.");
            string Address = Console.ReadLine();
          

            customer.FirstName = FirstName;
            customer.LastName = LastName;
            customer.Email = Email;
            customer.Address = Address;


            Console.WriteLine("Well done! A new customer with their properties has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Add(customer);
            try
            {
                bicycleRentalDBContext.SaveChanges();

            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}");
            }

            Console.ReadKey();


        }

        public void UpdateCustomer()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter CustomerId.");
            var customerId = Convert.ToInt32(Console.ReadLine());
            var customer = bicycleRentalDBContext.Customers.Find(customerId);

            Console.WriteLine("Please, enter the new First Name for a customer. Current First Name is:" + " " + customer.FirstName);
            string FirstName2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new Last Name for a customer. Current Last Name is:" + " " + customer.LastName);
            string LastName2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new Email for a customer. Current Email is:" + " " + customer.Email);
            string Email2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new Address for a customer. Current Address is:" + " " + customer.Address);
            string Address2 = Console.ReadLine();
            

            customer.FirstName = FirstName2;
            customer.LastName = LastName2;
            customer.Email = Email2;
            customer.Address = Address2; 
           

            Console.WriteLine("Well done! The updated Customer has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Update(customer);
            try
            {
                bicycleRentalDBContext.SaveChanges();

            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}"); //Save info about the error in the variable
            }

            Console.ReadKey();


        }

        public void DeleteCustomer()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext(); //Why do we need to create a new variable to represent the database?

            Console.WriteLine("Please, enter CustomerId.");
            var customerId = Convert.ToInt32(Console.ReadLine());
            var customer = bicycleRentalDBContext.Customers.Find(customerId); //Find always targeting PK

            try
            {

                bicycleRentalDBContext.Remove(customer);
                bicycleRentalDBContext.SaveChanges();
            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}"); 
            }

            Console.WriteLine("Oops, the Customer has been deleted now. Hope that's what you wanted :P. Press enter if you want to return to the main menu.");
            Console.ReadKey();


        }

        public void ReadCustomer()
        {

            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter CustomerId to find the right customer.");
            var customerId = Convert.ToInt32(Console.ReadLine());
            var customer = bicycleRentalDBContext.Customers.Find(customerId);

            if (customer == null)
            {

                Console.WriteLine("CustomerId was not found.");

            }

            if (customer != null)
            {
                Console.WriteLine("First Name is:" + " " + customer.FirstName);
                Console.WriteLine("Last Name is:" + " " + customer.LastName);
                Console.WriteLine("Email is:" + " " + customer.Email);
                Console.WriteLine("Address is:" + " " + customer.Address);
            }

            Console.ReadKey();
        }
    }
}
