namespace ef.Models.App
{
    public class Post : Entity
    {
        public string Content { get; set; }
        public int AuthorId { get; set; }
    }
}