using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace StationBK.Migrations
{
    /// <inheritdoc />
    public partial class addCommission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Commission",
                table: "Oils",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Commission",
                table: "FuelBalances",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "MonthlyBalances",
                columns: table => new
                {
                    Date = table.Column<string>(type: "varchar(255)", nullable: false),
                    OilEarns = table.Column<float>(type: "float", nullable: false),
                    SolarEarns = table.Column<float>(type: "float", nullable: false),
                    Banzeen80Earns = table.Column<float>(type: "float", nullable: false),
                    Banzeen92Earns = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyBalances", x => x.Date);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OilPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    extra = table.Column<float>(type: "float", nullable: false),
                    xpl = table.Column<float>(type: "float", nullable: false),
                    sj = table.Column<float>(type: "float", nullable: false),
                    coopFact4 = table.Column<float>(type: "float", nullable: false),
                    coopFact5 = table.Column<float>(type: "float", nullable: false),
                    coopFact20 = table.Column<float>(type: "float", nullable: false),
                    mobil = table.Column<float>(type: "float", nullable: false),
                    shell = table.Column<float>(type: "float", nullable: false),
                    bakm = table.Column<float>(type: "float", nullable: false),
                    shahm1 = table.Column<float>(type: "float", nullable: false),
                    shahm2 = table.Column<float>(type: "float", nullable: false),
                    shahm3 = table.Column<float>(type: "float", nullable: false),
                    superStan4 = table.Column<float>(type: "float", nullable: false),
                    superStan20 = table.Column<float>(type: "float", nullable: false),
                    hydraulic = table.Column<float>(type: "float", nullable: false),
                    troosSmall = table.Column<float>(type: "float", nullable: false),
                    troosLarge = table.Column<float>(type: "float", nullable: false),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OilPrices", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyBalances");

            migrationBuilder.DropTable(
                name: "OilPrices");

            migrationBuilder.DropColumn(
                name: "Commission",
                table: "Oils");

            migrationBuilder.DropColumn(
                name: "Commission",
                table: "FuelBalances");
        }
    }
}
