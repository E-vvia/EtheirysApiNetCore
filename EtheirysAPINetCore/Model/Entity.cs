using System.Text.Json.Serialization;

namespace EtheirysAPINetCore.Model
{
    public abstract record Entity
    {
        public int Id { get; set; }
    }
}