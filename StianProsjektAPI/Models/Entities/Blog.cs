using Microsoft.AspNetCore.Identity;

namespace StianProsjektAPI.Models.Entities
{
    public class Blog
    {
        public virtual ApplicationUser Owner { get; set; }
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogDescription { get; set; }

        public List<BlogPost> BlogPosts { get; set; }

        public bool isOpenForExternalWriters { get; set; }

        public DateTime TimeCreated { get; set; }
    }
}