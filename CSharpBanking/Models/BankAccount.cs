using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBanking.Models
{
   public class BankAccount
    {
        [Key]
        public int Id { get; set; }

        public int Amount { get; set; }

        public DateTime Inserted { get; set; }

        public int Customer_Id { get; set; }
        public Customer Customer { get; set; }


    }
}
