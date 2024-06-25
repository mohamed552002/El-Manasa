using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutureEducationalPlatform.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addConfigureCCT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CentersCourseTime",
                table: "CentersCourseTime");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CentersCourseTime",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CentersCourseTime",
                table: "CentersCourseTime",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CentersCourseTime_CenterId_CourseId",
                table: "CentersCourseTime",
                columns: new[] { "CenterId", "CourseId" },
                unique: true,
                filter: "[IsDeleted] = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CentersCourseTime",
                table: "CentersCourseTime");

            migrationBuilder.DropIndex(
                name: "IX_CentersCourseTime_CenterId_CourseId",
                table: "CentersCourseTime");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CentersCourseTime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CentersCourseTime",
                table: "CentersCourseTime",
                columns: new[] { "CenterId", "CourseId" });
        }
    }
}
