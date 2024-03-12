using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LostAndFound.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lost_infos",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lost_item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lost_location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    acquirer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lost_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    owner_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    found_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lost_infos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lost_infos");
        }
    }
}
