using CSharpBanking.Models;
using CSharpBanking.Repository;

namespace CSharpBanking.Registration
{
    internal interface IUserRegistration
    {
        void Registration(Customer customer);
    }
}