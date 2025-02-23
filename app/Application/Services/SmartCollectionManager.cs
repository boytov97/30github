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

        public CollectionEntity GetBy(string type)
        {
            return new CollectionEntity(7873842984324, "bingo-collection", type);
        }

        public CollectionEntity GetBy(Int64 id, string title)
        {
            return new CollectionEntity(7873842984324, title, "smart");
        }

        public CollectionEntity GetBy(Int64 id)
        {
            return new CollectionEntity(id, "bingo-collection", "smart");
        }
    }
}
