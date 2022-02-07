using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Models
{
    public class Customer
    {

        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PinCode { get; set; }

        //public int BankAccount_Id { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
