using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace StationBK.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterDatabase()
            //    .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Balances",
            //    columns: table => new
            //    {
            //        BalanceId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        balance = table.Column<float>(type: "float", nullable: false),
            //        month = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Balances", x => x.BalanceId);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DailyShifts",
                columns: table => new
                {
                    Date = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "longtext", nullable: false),
                    Teps = table.Column<float>(type: "float", nullable: false),
                    Washing = table.Column<float>(type: "float", nullable: false),
                    FuelsMoney = table.Column<float>(type: "float", nullable: false),
                    OilsMoney = table.Column<float>(type: "float", nullable: false),
                    ExpensesMony = table.Column<float>(type: "float", nullable: false),
                    CashMoney = table.Column<float>(type: "float", nullable: false),
                    CrediteMoney = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyShifts", x => x.Date);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Deposits",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        price = table.Column<float>(type: "float", nullable: false),
            //        date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        priceType = table.Column<string>(type: "longtext", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Deposits", x => x.id);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Expenses",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        Date = table.Column<string>(type: "longtext", nullable: false),
            //        ExpenseName = table.Column<string>(type: "longtext", nullable: false),
            //        ExpenseAmount = table.Column<float>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Expenses", x => x.Id);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "FuelBalances",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        Date = table.Column<string>(type: "longtext", nullable: false),
            //        FuelName = table.Column<string>(type: "longtext", nullable: false),
            //        PreviousBalance = table.Column<float>(type: "float", nullable: false),
            //        IncomeAmount = table.Column<float>(type: "float", nullable: false),
            //        SalesAmount = table.Column<float>(type: "float", nullable: false),
            //        RemainAmount = table.Column<float>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FuelBalances", x => x.Id);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Fules",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        Date = table.Column<string>(type: "longtext", nullable: false),
            //        FuelName = table.Column<string>(type: "longtext", nullable: false),
            //        PreviousBalance = table.Column<float>(type: "float", nullable: false),
            //        CurrentBalance = table.Column<float>(type: "float", nullable: false),
            //        Amount = table.Column<float>(type: "float", nullable: false),
            //        Price = table.Column<float>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Fules", x => x.Id);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Oils",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        Date = table.Column<string>(type: "longtext", nullable: false),
            //        OilName = table.Column<string>(type: "longtext", nullable: false),
            //        PreviousAmount = table.Column<float>(type: "float", nullable: false),
            //        IncomeAmount = table.Column<float>(type: "float", nullable: false),
            //        Price = table.Column<float>(type: "float", nullable: false),
            //        SoldAmount = table.Column<float>(type: "float", nullable: false),
            //        TotalPrice = table.Column<float>(type: "float", nullable: false),
            //        CurrentAmount = table.Column<float>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Oils", x => x.Id);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Prices",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        solarPrice = table.Column<float>(type: "float", nullable: false),
            //        petrol80Price = table.Column<float>(type: "float", nullable: false),
            //        petrol92Price = table.Column<float>(type: "float", nullable: false),
            //        date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Prices", x => x.Id);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Purchaces",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        quantity = table.Column<int>(type: "int", nullable: false),
            //        date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        productName = table.Column<string>(type: "longtext", nullable: false),
            //        price = table.Column<float>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Purchaces", x => x.id);
            //    })
            //    .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balances");

            migrationBuilder.DropTable(
                name: "DailyShifts");

            migrationBuilder.DropTable(
                name: "Deposits");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "FuelBalances");

            migrationBuilder.DropTable(
                name: "Fules");

            migrationBuilder.DropTable(
                name: "Oils");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Purchaces");
        }
    }
}
