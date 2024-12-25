namespace TheHybridWatchStore.Server.Data.DTOs
{
    public class WatchDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Gender { get; set; }
        public string Movement { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<string> Features { get; set; }
        public List<string> ImagePaths { get; set; }


    }
}
