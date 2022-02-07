using CSharpBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Bank.Utillities
{
    public class AddAmmount : IAddAmmount
    {
        private readonly ApplicationDbContext _db;

        public AddAmmount(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Insert(int number)
        {
            

                try
                {

                //_db.Customers.Where(z => z.PinCode == number).Select(x => x.FirstName).FirstOrDefault();
                //var addUser = _db.Customers.SingleOrDefault(x => x.PinCode == number);
                Console.WriteLine("Add your amount you would like to insert: ");
                var add = Convert.ToInt32(Console.ReadLine());
                var addUser = _db.Customers.Where(x => x.PinCode == number).Select(x => x.BankAccount.Amount == add).FirstOrDefault();

                _db.Add(addUser);
                _db.SaveChanges();

                

                }
                catch (Exception)
                {

                    throw;
                }
        }

    }
}
