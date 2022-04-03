using SchoolManagement.DB.Models;

namespace SchoolManagement.DB
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolManagementContext _context;

        public UnitOfWork(SchoolManagementContext context)
        {
            _context = context;
            Managers = new ManagerRepository(_context);
            Teachers = new TeacherRepository(_context);
            Account = new AccountRepository(_context);
        }
        public IManagerRepository Managers { get; private set; }

        public ICrewMemberRepository Teachers { get; private set; }

        public IAccountRepository Account { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
