using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutureEducationalPlatform.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                column: "Name",
                values: new [] { "Parent" , "Admin" , "Student" , "SuperAdmin", "QRUser" }
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From [Roles]");
        }
    }
}
