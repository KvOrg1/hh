using hh.Domain.Entities;
using hh.Infrastructure.Contexts;

namespace hh.Infrastructure.Repository
{
    public class UserRepository : GenericRepository<User,Guid> , IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) 
            : base(appDbContext)
        {
        }
    }
}
