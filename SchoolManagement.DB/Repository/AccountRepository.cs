using SchoolManagement.DB.Models;

namespace SchoolManagement.DB
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(SchoolManagementContext context) : base(context)
        {
        }

        public Account GetAccount(int id)
        {
            var account = _context.Accounts.Where(a => a.Id == id).Select(a => a).FirstOrDefault();
            return account;
        }

        public bool IsExist(string userName)
        {
            var userExist = _context.Accounts.Where(u => u.UserName == userName).Any();
            return userExist;
        }

        public Users Login(string userName, string password)
        {
            if (IsExist(userName))
            {
                Users users = new Users();
                var accountId = _context.Accounts.Where(a => a.UserName == userName && a.Password == password).Select(a => a.Id).FirstOrDefault();
                var member = _context.CrewMembers.Where(m => m.AccountId == accountId).Select(m => m).FirstOrDefault();
                if(member == null)
                {
                    var student = _context.Students.Where(s => s.AccountId == accountId).Select(s => s).FirstOrDefault();
                    users.Student = student;
                    return users;
                }
                users.crewMember = member;
                return users;
            }
            throw new UserNotExistException();
        }
    }
}
