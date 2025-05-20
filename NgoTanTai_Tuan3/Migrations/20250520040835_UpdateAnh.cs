using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NgoTanTai_Tuan3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAnh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "AspNetUsers");
        }
    }
}
