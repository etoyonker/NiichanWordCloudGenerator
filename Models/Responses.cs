namespace NiichanWordCloudGenerator.Models
{

    internal class NiichanResponse
    {
        public Post[]? posts { get; set; }
        public Error? error { get; set; }
        public int? result { get; set; }
    }

    internal class Post
    {
        public string? comment { get; set; }
    }

    internal class Error
    {
        public int? code { get; set; }
        public string? message { get; set; }
    }
}
