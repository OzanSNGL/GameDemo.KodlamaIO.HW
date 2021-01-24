using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Abstract;
using GameDemo.KodlamaIO.HW.Entities;
using GameDemo.KodlamaIO.HW;

namespace GameDemo.KodlamaIO.HW.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void Delete(string customerPassword)
        {
            Console.WriteLine("Please enter your password again:");
        pass: string password = null;
            password = Console.ReadLine();
            if (password == customerPassword)
            {
                Console.WriteLine("Customer delete successful.");
            }
            else
            {
                Console.WriteLine("You have entered an invalid password. Please try again.\r\n");
                goto pass;
            }

        }

        public void SignUp(Customer customer)
        {
            Console.WriteLine("Please enter a new username: ");
            Console.ReadLine().ToString();
            Console.WriteLine("Please enter a new password: ");
            Console.ReadLine().ToString();
            Console.WriteLine("Customer sign up successful.\r\n");
        }

        public void Update()
        {
            Console.WriteLine("Please enter a new name: ");
            Console.ReadLine().ToString();
            Console.WriteLine("Please enter a new last name: ");
            Console.ReadLine().ToString();
            Console.WriteLine("You have successfully updated your account.\r\n");
        }
    }
}
