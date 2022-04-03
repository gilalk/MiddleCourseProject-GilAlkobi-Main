using SchoolManagement.DB.Models;

namespace SchoolManagement.DB
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        bool IsExist(string userName);
        Users Login(string userName, string password);
        Account GetAccount(int id);
    }
}
