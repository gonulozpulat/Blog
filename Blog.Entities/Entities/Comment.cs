namespace Blog.Entities.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
