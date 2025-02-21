using _30github.app.Domain.Entities;

namespace _30github.app.Application.Services
{
    abstract class CollectionManager
    {
        public void Create(CollectionEntity collection)
        {
            Console.WriteLine($"Collection created {collection.Title}");
        }

        public void Update(CollectionEntity collection)
        {
            Console.WriteLine($"Collection updated {collection.Title}");
        }

        public abstract CollectionEntity GetById(Int64 id);
    }
}
