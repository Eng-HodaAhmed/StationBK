using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StationBK.Migrations
{
    /// <inheritdoc />
    public partial class addDeposit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "deposit",
                table: "DailyShifts",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deposit",
                table: "DailyShifts");
        }
    }
}
