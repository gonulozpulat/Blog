namespace Blog.Entities.DTO
{
    public class CommentDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int ArticleId { get; set; }
    }
}
