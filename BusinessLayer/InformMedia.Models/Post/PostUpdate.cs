﻿namespace InformMedia.Models
{
    public class PostUpdate
    {
        public PostTag[] Tags { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Content { get; set; }
    }
}
