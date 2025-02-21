using _30github.app.Domain.Entities;

namespace _30github.app.Application.Services
{
    class ProductProvider
    {
        public virtual ProductEntity GetById(Int64 id)
        {
            return new ProductEntity(id, "product-entity", 789f, null);
        }
    }
}
