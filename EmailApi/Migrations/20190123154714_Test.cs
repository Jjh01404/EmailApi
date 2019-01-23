using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmailApi.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hellos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HelloName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hellos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hellos");
        }
    }
}
