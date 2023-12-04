using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StianProsjektAPI.Models.Entities;

namespace StianProsjektAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<BlogPostComment> BlogPostComment { get; set; }
        public DbSet<BlogPostTag> BlogPostTag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>().ToTable("Blog");
            modelBuilder.Entity<BlogPost>().ToTable("BlogPost");
            modelBuilder.Entity<BlogPostComment>().ToTable("BlogPostComment");
            modelBuilder.Entity<BlogPostTag>().ToTable("BlogPostTag");

            // Seeding 

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    BlogId = 1,
                    BlogName = "Stian's Blog",
                    BlogDescription = "This is my blog. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    isOpenForExternalWriters = true
                },
                new Blog
                {
                    BlogId = 2,
                    BlogName = "Stian's Blog 2",
                    BlogDescription = "This is my second blog. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    isOpenForExternalWriters = true
                },
                new Blog
                {
                    BlogId = 3,
                    BlogName = "Stian's Blog 3",
                    BlogDescription = "This is my third blog. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    isOpenForExternalWriters = true
                }
            );
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    BlogPostId = 1,
                    BlogPostTitle = "BlogPost 1",
                    BlogPostContent = "This is my first blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 1
                },
                new BlogPost
                {
                    BlogPostId = 2,
                    BlogPostTitle = "BlogPost 2",
                    BlogPostContent = "This is my second blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 1
                },
                new BlogPost
                {
                    BlogPostId = 3,
                    BlogPostTitle = "BlogPost 3",
                    BlogPostContent = "This is my third blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 1
                },
                new BlogPost
                {
                    BlogPostId = 4,
                    BlogPostTitle = "BlogPost 4",
                    BlogPostContent = "This is my fourth blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 2
                },
                new BlogPost
                {
                    BlogPostId = 5,
                    BlogPostTitle = "BlogPost 5",
                    BlogPostContent = "This is my fifth blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 2
                },
                new BlogPost
                {
                    BlogPostId = 6,
                    BlogPostTitle = "BlogPost 6",
                    BlogPostContent = "This is my sixth blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 2
                },
                new BlogPost
                {
                    BlogPostId = 7,
                    BlogPostTitle = "BlogPost 7",
                    BlogPostContent = "This is my seventh blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 3
                },
                new BlogPost
                {
                    BlogPostId = 8,
                    BlogPostTitle = "BlogPost 8",
                    BlogPostContent = "This is my eighth blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 3
                },
                new BlogPost
                {
                    BlogPostId = 9,
                    BlogPostTitle = "BlogPost 9",
                    BlogPostContent = "This is my ninth blogpost. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogId = 3

                }

            );
            modelBuilder.Entity<BlogPostComment>().HasData(
                new BlogPostComment
                {
                    BlogPostCommentId = 1,
                    BlogPostCommentContent = "This is my first comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 1
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 2,
                    BlogPostCommentContent = "This is my second comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 1
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 3,
                    BlogPostCommentContent = "This is my third comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 1
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 4,
                    BlogPostCommentContent = "This is my fourth comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 2
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 5,
                    BlogPostCommentContent = "This is my fifth comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 2
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 6,
                    BlogPostCommentContent = "This is my sixth comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 2
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 7,
                    BlogPostCommentContent = "This is my seventh comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 3
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 8,
                    BlogPostCommentContent = "This is my eighth comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 3
                },
                new BlogPostComment
                {
                    BlogPostCommentId = 9,
                    BlogPostCommentContent = "This is my ninth comment. I write about stuff I like.",
                    TimeCreated = DateTime.Now,
                    BlogPostId = 3
                }
            );

            modelBuilder.Entity<BlogPostTag>().HasData(
                new BlogPostTag
                {
                    BlogPostTagId = 1,
                    BlogPostTagName = "Tag1",
                    BlogPostId = 1
                },
                new BlogPostTag
                {
                    BlogPostTagId = 2,
                    BlogPostTagName = "Tag2",
                    BlogPostId = 1
                },
                new BlogPostTag
                {
                    BlogPostTagId = 3,
                    BlogPostTagName = "Tag3",
                    BlogPostId = 1
                },
                new BlogPostTag
                {
                    BlogPostTagId = 4,
                    BlogPostTagName = "Tag4",
                    BlogPostId = 2
                },
                new BlogPostTag
                {
                    BlogPostTagId = 5,
                    BlogPostTagName = "Tag5",
                    BlogPostId = 2
                },
                new BlogPostTag
                {
                    BlogPostTagId = 6,
                    BlogPostTagName = "Tag6",
                    BlogPostId = 2
                },
                new BlogPostTag
                {
                    BlogPostTagId = 7,
                    BlogPostTagName = "Tag7",
                    BlogPostId = 3
                },
                new BlogPostTag
                {
                    BlogPostTagId = 8,
                    BlogPostTagName = "Tag8",
                    BlogPostId = 3
                },
                new BlogPostTag
                {
                    BlogPostTagId = 9,
                    BlogPostTagName = "Tag9",
                    BlogPostId = 3
                }
            );
        }
    }
}


