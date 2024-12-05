namespace EtheirysAPINetCore.Model
{
    public class Paginated<T> where T : Entity
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }
        public IEnumerable<T> Data { get; set; } = [];
    }
}
