using Microsoft.AspNetCore.Identity;

namespace StianProsjektAPI.Models.Entities
{
    public class BlogPostComment
    {
        public virtual ApplicationUser Owner { get; set; }
        public int BlogPostCommentId { get; set; }
        public string BlogPostCommentContent { get; set; }
        public int BlogPostId { get; set; }
        public virtual BlogPost BlogPost { get; set; }
        public DateTime TimeCreated { get; set; }

    }
}
