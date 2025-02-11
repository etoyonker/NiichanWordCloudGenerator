namespace NiichanWordCloudGenerator.Models
{
    public class NiichanResponse
    {
        public Post[]? posts { get; set; }
        public Error? error { get; set; }
        public int? result { get; set; }
    }

    public class Post
    {
        public string? comment { get; set; }
    }

    public class Error
    {
        public int? code { get; set; }
        public string? message { get; set; }
    }
}
