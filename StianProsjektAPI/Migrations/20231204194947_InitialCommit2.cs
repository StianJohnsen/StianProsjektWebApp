using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StianProsjektAPI.Migrations
{
    public partial class InitialCommit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 4,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 5,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 6,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 7,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 8,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 9,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 4,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 5,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 6,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 7,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 8,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 9,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 49, 46, 980, DateTimeKind.Local).AddTicks(5243));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 4,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 5,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 6,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 7,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 8,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 9,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 4,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 5,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 6,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 7,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 8,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 9,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 20, 32, 1, 258, DateTimeKind.Local).AddTicks(2056));
        }
    }
}
