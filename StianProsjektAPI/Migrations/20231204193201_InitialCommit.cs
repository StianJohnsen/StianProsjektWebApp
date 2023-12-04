using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StianProsjektAPI.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 4,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 5,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 6,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 7,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 8,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "BlogPost",
                keyColumn: "BlogPostId",
                keyValue: 9,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 1,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 2,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 3,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 4,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 5,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 6,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 7,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 8,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "BlogPostComment",
                keyColumn: "BlogPostCommentId",
                keyValue: 9,
                column: "TimeCreated",
                value: new DateTime(2023, 12, 4, 14, 48, 39, 435, DateTimeKind.Local).AddTicks(3879));
        }
    }
}
