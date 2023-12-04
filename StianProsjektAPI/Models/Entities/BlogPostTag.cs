namespace StianProsjektAPI.Models.Entities
{
    public class BlogPostTag
    {
        public int BlogPostTagId { get; set; }
        public string BlogPostTagName { get; set; }
        public int BlogPostId { get; set; }
        public virtual BlogPost BlogPost { get; set; }
    }
}
