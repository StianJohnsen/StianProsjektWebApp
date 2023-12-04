using Microsoft.AspNetCore.Identity;

namespace StianProsjektAPI.Models.Entities
{
    public class BlogPost
    {
        public virtual ApplicationUser Owner { get; set; }
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; }
        public string BlogPostContent { get; set; }
        public DateTime TimeCreated { get; set; }
        public List<BlogPostComment> BlogPostComments { get; set; }
        public List<BlogPostTag> BlogPostTags { get; set; }
        public Boolean isOpenForExternalWriters { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
