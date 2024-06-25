using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutureEducationalPlatform.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addUserRoleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId_UserId",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                unique: true,
                filter: "[IsDeleted] = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_RoleId_UserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" });
        }
    }
}
