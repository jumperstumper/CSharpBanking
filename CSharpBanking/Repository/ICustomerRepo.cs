using CSharpBanking.Models;

namespace CSharpBanking.Repository
{
    public interface ICustomerRepo
    {
        void UserRegistration(Customer customer);

        void DeleteCustomer(int id);

        void GetCustomer();
    }
}