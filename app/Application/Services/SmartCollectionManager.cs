using _30github.app.Domain.Entities;

namespace _30github.app.Application.Services
{
    class SmartCollectionManager : CollectionManager
    {
        public SmartCollectionManager()
        { }

        public override CollectionEntity GetById(Int64 id)
        {
            return new CollectionEntity(id, "bingo-collection", "smart");
        }
    }
}
