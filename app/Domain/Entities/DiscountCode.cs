namespace _30github.app.Domain.Entities
{
    public struct DiscountCode
    {
        public DiscountCode(string code, float amount, string type)
        {
            Code = code;
            Amount = amount;
            Type = type;
        }

        public string Code { get; }
        public float Amount { get; }

        public string Type { get; }
    }
}
