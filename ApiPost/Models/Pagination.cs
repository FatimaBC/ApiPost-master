namespace ApiPost.Models
{
    public class Pagination
    {
        public string? searchText { get; set; }
        public int? page { get; set; }
        public int? limit { get; set; }
        public int? total { get; set; }
    }
}
