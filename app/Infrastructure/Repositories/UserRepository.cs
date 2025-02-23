using _30github.app.Domain.Entities;
using _30github.app.Domain.Repositories;

namespace _30github.app.Infrastructure.Repositories
{
    class UserRepository : IUserRepositoryInterface
    {
        public void Create(UserEntity user)
        {
            // create user
        }

        public void Update(UserEntity user)
        {
            // update user
        }

        public UserEntity FindById(Int64 id)
        {
            return new UserEntity();
        }
    }
}
