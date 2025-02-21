using _30github.app.Domain.Entities;

namespace _30github.app.Application.Services
{
    class BookProductProvider : ProductProvider
    {
        public override ProductEntity GetById(long id)
        {
            //return base.getById(id);

            return new BookEntity(id, "book-entity", 79878f, "hard", null);
        }
    }
}
