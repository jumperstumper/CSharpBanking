using CSharpBanking.Bank.Utillities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Bank
{


    public class UserContent : IUserContent
    {
        private readonly ApplicationDbContext _db;
        private readonly GetAmmount _check;
        private readonly AddAmmount _insert;

        public UserContent(ApplicationDbContext db, GetAmmount check, AddAmmount insert)
        {
            _db = db;
            _check = check;
            _insert = insert;
        }

        public void BankContent(int number)
        {
            var name = _db.Customers.Where(z => z.PinCode == number).Select(x => x.FirstName).FirstOrDefault();

            Console.WriteLine("Welcome! " + name);
            Console.WriteLine("What would you like to do ?");
            Console.WriteLine("Press 1 for check your account");
            Console.WriteLine("Press 2 to insert money");
            Console.WriteLine("Press 3 to take out money");


            bool isNumber = int.TryParse(Console.ReadLine(), out int start);


            if (isNumber)
            {
                switch (start)
                {
                    case 1:
                        _check.Check(number);
                        break;
                    case 2:
                       _insert.Insert(number);
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
