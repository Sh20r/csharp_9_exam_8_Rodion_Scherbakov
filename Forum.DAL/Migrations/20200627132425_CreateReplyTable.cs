using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.DAL.Migrations
{
    public partial class CreateReplyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reply_Blogs_BlogId",
                table: "Reply");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reply",
                table: "Reply");

            migrationBuilder.RenameTable(
                name: "Reply",
                newName: "Replies");

            migrationBuilder.RenameIndex(
                name: "IX_Reply_BlogId",
                table: "Replies",
                newName: "IX_Replies_BlogId");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Replies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Replies",
                maxLength: 2147483647,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Replies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Replies",
                table: "Replies",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_AuthorId",
                table: "Replies",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId",
                table: "Replies",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Blogs_BlogId",
                table: "Replies",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Blogs_BlogId",
                table: "Replies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Replies",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Replies_AuthorId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Replies");

            migrationBuilder.RenameTable(
                name: "Replies",
                newName: "Reply");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_BlogId",
                table: "Reply",
                newName: "IX_Reply_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reply",
                table: "Reply",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reply_Blogs_BlogId",
                table: "Reply",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
