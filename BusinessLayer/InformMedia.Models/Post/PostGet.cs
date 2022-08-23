namespace InformMedia.Models
{
    public class PostGet
    {
        public Guid Id { get; set; }

        public PostTag[] Tags { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
