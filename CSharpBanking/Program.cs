using CSharpBanking.Bank;
using CSharpBanking.Bank.Utillities;
using CSharpBanking.Models;
using CSharpBanking.Registration;
using CSharpBanking.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace CSharpBanking
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider services = new ServiceCollection()
           .AddDbContext<ApplicationDbContext>()
           .AddTransient<CustomerRepo>()
           .AddTransient<Run>()
           .AddTransient<Customer>()
           .AddTransient<UserRegistration>()
           .AddTransient<Login>()
           .AddTransient<UserContent>()
           .AddTransient<GetAmmount>()
           .AddTransient<AddAmmount>()
           .BuildServiceProvider();

            Run run = services.GetService<Run>();

            run.RunApp();
        }
    }
}
