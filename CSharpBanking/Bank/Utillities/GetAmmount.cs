using CSharpBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Bank.Utillities
{
   public class GetAmmount : IGetAmmount
    {
        private readonly ApplicationDbContext _db;

        public GetAmmount(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Check(int number)
        {
            var balance = _db.Customers.Include(x => x.BankAccount).Where(z => z.PinCode == number);

            foreach (var account in balance)
            {
                Console.WriteLine("Your account balance is: " + account.BankAccount.Amount + " $");
            }
        }
    }
}
