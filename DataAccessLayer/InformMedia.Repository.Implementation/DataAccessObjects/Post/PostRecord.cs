namespace InformMedia.Repository.Implementation.DataAccessObjects
{
    public class PostRecord
    {
        public Guid Id { get; set; }

        public PostTagRecord[] Tags { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
