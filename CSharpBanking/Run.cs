using CSharpBanking.Bank;
using CSharpBanking.Models;
using CSharpBanking.Registration;
using CSharpBanking.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking
{
   public class Run : IRun
    {
        private readonly CustomerRepo _customerRepo;
        private readonly Customer customer;
        private readonly Login _login;
        private readonly UserRegistration _userRegistration;



        public Run(CustomerRepo customerRepo, Login login, UserRegistration userRegistration)
        {
            _customerRepo = customerRepo;
            _login = login;
            _userRegistration = userRegistration;

        }



        public void RunApp()
        {
            Console.WriteLine("Welcome to C# Banking!");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("Press 1 For Login");
            Console.WriteLine("Press 2 For Register");

            


            bool isNumber = int.TryParse(Console.ReadLine(), out int start);


            if (isNumber)
            {
                switch (start)
                {
                    case 1:
                        _login.Enter();
                        break;
                    case 2:
                        _userRegistration.Registration(customer);
                        break;
                    default:
                        Console.WriteLine("Please choose a valid number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter a number");
            }


        }
    }
}
