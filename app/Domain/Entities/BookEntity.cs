namespace _30github.app.Domain.Entities
{
    class BookEntity : ProductEntity
    {
        private string cover;

        public BookEntity(Int64 _id, string _handle, float _price, string _cover, string? _title) : base(_id, _handle, _price, _title)
        {
            cover = _cover;
        }

        public string Cover
        {
            get
            {
                return cover;
            }
            set
            {
                cover = value;
            }
        }
    }
}
