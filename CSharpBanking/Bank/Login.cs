using CSharpBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Bank
{
   public class Login : ILogin
    {
        private readonly UserContent _userContent;
        private readonly ApplicationDbContext _db;

        public Login(UserContent userContent, ApplicationDbContext db)
        {
            _userContent = userContent;
            _db = db;
        }

       public void Enter()
        {
            Console.WriteLine("Enter your Social Number to login");
            var number = Convert.ToInt32(Console.ReadLine());
            var result = _db.Customers.Where(x => x.PinCode == number).Any();
            
            if (_db == null)
            {
                Console.WriteLine($"No customer with {number} was found");
                return;
            }
            if (result == true)
            {
               
                _userContent.BankContent(number);
            }
            else
            {
                Console.WriteLine($"No customer with {number} was found!");
            }


          
        }
    }
}
