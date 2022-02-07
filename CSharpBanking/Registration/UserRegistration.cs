using CSharpBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Registration
{
   public class UserRegistration : IUserRegistration
    {
        private readonly ApplicationDbContext _db;
        private readonly Customer _customer;

        public UserRegistration(ApplicationDbContext db, Customer customer)
        {
            _db = db;
            _customer = customer;
        }

        public void Registration(Customer customer)
        {
            Console.WriteLine("Enter First Name");
            _customer.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            _customer.LastName = Console.ReadLine();
            Console.WriteLine("Enter a Pin Code with 4 numbers");
            _customer.PinCode = Convert.ToInt32(Console.ReadLine());
            _customer.BankAccount = new BankAccount();

            _db.Add(_customer);
            _db.SaveChanges();

        }
    }
}
