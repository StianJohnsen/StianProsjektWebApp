using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StianProsjektAPI.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isOpenForExternalWriters = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlogPost",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogPostTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogPostContent = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TimeCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    isOpenForExternalWriters = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.BlogPostId);
                    table.ForeignKey(
                        name: "FK_BlogPost_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogPost_Blog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blog",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlogPostComment",
                columns: table => new
                {
                    BlogPostCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogPostCommentContent = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogPostId = table.Column<int>(type: "int", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostComment", x => x.BlogPostCommentId);
                    table.ForeignKey(
                        name: "FK_BlogPostComment_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogPostComment_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlogPostTag",
                columns: table => new
                {
                    BlogPostTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BlogPostTagName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostTag", x => x.BlogPostTagId);
                    table.ForeignKey(
                        name: "FK_BlogPostTag_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "BlogPostId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogDescription", "BlogName", "OwnerId", "TimeCreated", "isOpenForExternalWriters" },
                values: new object[] { 1, "This is my blog. I write about stuff I like.", "Stian's Blog", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3638), true });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogDescription", "BlogName", "OwnerId", "TimeCreated", "isOpenForExternalWriters" },
                values: new object[] { 2, "This is my second blog. I write about stuff I like.", "Stian's Blog 2", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3730), true });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogDescription", "BlogName", "OwnerId", "TimeCreated", "isOpenForExternalWriters" },
                values: new object[] { 3, "This is my third blog. I write about stuff I like.", "Stian's Blog 3", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3732), true });

            migrationBuilder.InsertData(
                table: "BlogPost",
                columns: new[] { "BlogPostId", "BlogId", "BlogPostContent", "BlogPostTitle", "OwnerId", "TimeCreated", "isOpenForExternalWriters" },
                values: new object[,]
                {
                    { 1, 1, "This is my first blogpost. I write about stuff I like.", "BlogPost 1", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3848), false },
                    { 2, 1, "This is my second blogpost. I write about stuff I like.", "BlogPost 2", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3850), false },
                    { 3, 1, "This is my third blogpost. I write about stuff I like.", "BlogPost 3", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3851), false },
                    { 4, 2, "This is my fourth blogpost. I write about stuff I like.", "BlogPost 4", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3852), false },
                    { 5, 2, "This is my fifth blogpost. I write about stuff I like.", "BlogPost 5", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3854), false },
                    { 6, 2, "This is my sixth blogpost. I write about stuff I like.", "BlogPost 6", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3855), false },
                    { 7, 3, "This is my seventh blogpost. I write about stuff I like.", "BlogPost 7", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3856), false },
                    { 8, 3, "This is my eighth blogpost. I write about stuff I like.", "BlogPost 8", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3858), false },
                    { 9, 3, "This is my ninth blogpost. I write about stuff I like.", "BlogPost 9", null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3859), false }
                });

            migrationBuilder.InsertData(
                table: "BlogPostComment",
                columns: new[] { "BlogPostCommentId", "BlogPostCommentContent", "BlogPostId", "OwnerId", "TimeCreated" },
                values: new object[,]
                {
                    { 1, "This is my first comment. I write about stuff I like.", 1, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3869) },
                    { 2, "This is my second comment. I write about stuff I like.", 1, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3871) },
                    { 3, "This is my third comment. I write about stuff I like.", 1, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3872) },
                    { 4, "This is my fourth comment. I write about stuff I like.", 2, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3873) },
                    { 5, "This is my fifth comment. I write about stuff I like.", 2, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3874) },
                    { 6, "This is my sixth comment. I write about stuff I like.", 2, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3875) },
                    { 7, "This is my seventh comment. I write about stuff I like.", 3, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3876) },
                    { 8, "This is my eighth comment. I write about stuff I like.", 3, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3878) },
                    { 9, "This is my ninth comment. I write about stuff I like.", 3, null, new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3879) }
                });

            migrationBuilder.InsertData(
                table: "BlogPostTag",
                columns: new[] { "BlogPostTagId", "BlogPostId", "BlogPostTagName" },
                values: new object[,]
                {
                    { 1, 1, "Tag1" },
                    { 2, 1, "Tag2" },
                    { 3, 1, "Tag3" },
                    { 4, 2, "Tag4" },
                    { 5, 2, "Tag5" },
                    { 6, 2, "Tag6" },
                    { 7, 3, "Tag7" },
                    { 8, 3, "Tag8" },
                    { 9, 3, "Tag9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_OwnerId",
                table: "Blog",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogId",
                table: "BlogPost",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_OwnerId",
                table: "BlogPost",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComment_BlogPostId",
                table: "BlogPostComment",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostComment_OwnerId",
                table: "BlogPostComment",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostTag_BlogPostId",
                table: "BlogPostTag",
                column: "BlogPostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BlogPostComment");

            migrationBuilder.DropTable(
                name: "BlogPostTag");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BlogPost");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
