using _30github.app.Domain.Entities;

namespace _30github.app.Domain.Repositories
{
    interface IUserRepositoryInterface
    {
        void Create(UserEntity user);

        void Update(UserEntity user);

        UserEntity FindById(Int64 id);
    }
}
