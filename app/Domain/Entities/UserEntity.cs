namespace _30github.app.Domain.Entities
{
    class UserEntity
    {
        private readonly Int64 id;

        private string? name;

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
