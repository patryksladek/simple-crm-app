namespace External.TaxpayerListAPI.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public string StatusVat { get; set; }
        public IList<string> AccountNumbers { get; set; }
    }
}
