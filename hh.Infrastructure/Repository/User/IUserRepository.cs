using hh.Domain.Entities;

namespace hh.Infrastructure.Repository
{
    public interface IUserRepository : IGenericRepository<User,Guid>
    {
    }
}
