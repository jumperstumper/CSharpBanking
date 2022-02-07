using CSharpBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly ApplicationDbContext _db;
        
        public CustomerRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public void UserRegistration(Customer customer)
        {
            _db.Add(customer);
            _db.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var obj = _db.Customers.FirstOrDefault(x => x.Id == id);
            _db.Remove(obj);
            _db.SaveChanges();
        }

        public void GetCustomer()
        {
            var c = _db.Customers.ToList();

            foreach (var item in c)
            {
                //Console.WriteLine(item.FirstName + item.LastName + item.Ammount);
            }
            
        }
    }
}
