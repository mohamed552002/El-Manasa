using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutureEducationalPlatform.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditHomeworkTableAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActived",
                table: "Homeworks",
                newName: "IsActive");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Homeworks",
                newName: "IsActived");
        }
    }
}
