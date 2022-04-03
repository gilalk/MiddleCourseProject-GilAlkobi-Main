namespace SchoolManagement.DB
{
    public interface IUnitOfWork : IDisposable
    {
        IManagerRepository Managers { get; }
        ICrewMemberRepository Teachers { get; }
        IAccountRepository Account { get; }
        int Complete();
    }
}
