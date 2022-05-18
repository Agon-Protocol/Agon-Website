namespace Agon.Website.Models
{
    public class KeplrKey
    {
        public string? Name { get; set; }
        public string? Algo { get; set; }
        public string? Bech32Address { get; set; }
        public bool IsNanoLedger { get; set; }
    }
}
