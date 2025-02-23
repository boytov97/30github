namespace _30github.app.Domain.Entities
{
    class AppleEntity(
        Int64 _id, string _handle, float _price, string variety, string? _title) : ProductEntity(_id, _handle, _price, _title)
    {
        public string Variety
        {
            get
            {
                return variety;
            }
            set
            {
                variety = value;
            }
        }
    }
}
