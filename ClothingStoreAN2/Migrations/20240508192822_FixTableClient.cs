using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClothingStoreAN2.Migrations
{
    /// <inheritdoc />
    public partial class FixTableClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientPhotoId",
                table: "Client");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientPhotoId",
                table: "Client",
                type: "int",
                nullable: true);
        }
    }
}
