namespace _30github.app.Domain.Entities
{
    class CollectionEntity
    {
        private readonly Int64 id;

        private string title;

        private string type;

        public CollectionEntity(Int64 _id, string _title, string _type)
        {
            id = _id;
            title = _title;
            type = _type;
        }

        public Int64 Id
        {
            get
            {
                return id;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}
