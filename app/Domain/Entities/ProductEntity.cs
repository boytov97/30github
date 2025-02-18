namespace _30github.app.Domain.Entities
{
    class ProductEntity
    {
        private readonly Int64 id;

        private string handle;

        private float price;

        private string? title;

        public ProductEntity(Int64 _id, string _handle, float _price, string? _title)
        {
            id = _id;
            handle = _handle;
            price = _price;
            title = _title;
        }

        public Int64 GetId()
        {
            return id;
        }

        public string GetHandle()
        {
            return this.handle;
        }

        public void SetHandle(string _handle)
        {
            handle = _handle;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float _price)
        {
            price = _price;
        }

        public string? GetTitle()
        {
            return title;
        }

        public void SetTitle(string? _title)
        {
            title = _title;
        }
    }

}
