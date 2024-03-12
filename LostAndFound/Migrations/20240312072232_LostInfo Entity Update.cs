using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LostAndFound.Migrations
{
    /// <inheritdoc />
    public partial class LostInfoEntityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "LostInfos",
                newName: "OwnerName");

            migrationBuilder.AddColumn<string>(
                name: "AcquirerName",
                table: "LostInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LostLocation",
                table: "LostInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcquirerName",
                table: "LostInfos");

            migrationBuilder.DropColumn(
                name: "LostLocation",
                table: "LostInfos");

            migrationBuilder.RenameColumn(
                name: "OwnerName",
                table: "LostInfos",
                newName: "Location");
        }
    }
}
