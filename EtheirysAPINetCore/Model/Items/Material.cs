using EtheirysAPINetCore.Endpoints;

namespace EtheirysAPINetCore.Model.Items
{
    [Endpoint("materials")]
    public record Material : Item
    {
        public int AetherialReduce { get; set; }
        public bool AlwaysCollectable { get; set; }
    }
}
