using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSSchedule.Migrations.Users
{
    public partial class MyFirstMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    Fullname = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Fullname", "Username" },
                values: new object[] { 1, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azimbayev Edilzhan", "edilzhan12" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Fullname", "Username" },
                values: new object[] { 2, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azimbayeva Madina", "mxmadina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
