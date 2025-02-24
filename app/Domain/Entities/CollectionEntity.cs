using _30github.app.Application.Enums;

namespace _30github.app.Domain.Entities
{
    class CollectionEntity
    {
        private readonly Int64 id;

        private string title;

        private CollectionType type;

        public CollectionEntity(Int64 _id, string _title, CollectionType _type)
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

        public CollectionType Type
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
