namespace DomainDrivenDesign.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Available { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
