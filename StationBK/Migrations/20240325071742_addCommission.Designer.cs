﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StationBK.Infrastructure.Data.Repository;

#nullable disable

namespace StationBK.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240325071742_addCommission")]
    partial class addCommission
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StationBK.Core.Entities.Station.DailyShift", b =>
                {
                    b.Property<string>("Date")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("CashMoney")
                        .HasColumnType("float");

                    b.Property<float>("CrediteMoney")
                        .HasColumnType("float");

                    b.Property<float>("ExpensesMony")
                        .HasColumnType("float");

                    b.Property<float>("FuelsMoney")
                        .HasColumnType("float");

                    b.Property<float>("OilsMoney")
                        .HasColumnType("float");

                    b.Property<float>("Teps")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Washing")
                        .HasColumnType("float");

                    b.Property<float>("deposit")
                        .HasColumnType("float");

                    b.HasKey("Date");

                    b.ToTable("DailyShifts");
                });

            modelBuilder.Entity("StationBK.Core.Entities.Station.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("ExpenseAmount")
                        .HasColumnType("float");

                    b.Property<string>("ExpenseName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("StationBK.Core.Entities.Station.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Amount")
                        .HasColumnType("float");

                    b.Property<float>("CurrentBalance")
                        .HasColumnType("float");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FuelName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("PreviousBalance")
                        .HasColumnType("float");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Fules");
                });

            modelBuilder.Entity("StationBK.Core.Entities.Station.FuelBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Commission")
                        .HasColumnType("float");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FuelName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("IncomeAmount")
                        .HasColumnType("float");

                    b.Property<float>("PreviousBalance")
                        .HasColumnType("float");

                    b.Property<float>("RemainAmount")
                        .HasColumnType("float");

                    b.Property<float>("SalesAmount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("FuelBalances");
                });

            modelBuilder.Entity("StationBK.Core.Entities.Station.MonthlyBalance", b =>
                {
                    b.Property<string>("Date")
                        .HasColumnType("varchar(255)");

                    b.Property<float>("Banzeen80Earns")
                        .HasColumnType("float");

                    b.Property<float>("Banzeen92Earns")
                        .HasColumnType("float");

                    b.Property<float>("OilEarns")
                        .HasColumnType("float");

                    b.Property<float>("SolarEarns")
                        .HasColumnType("float");

                    b.HasKey("Date");

                    b.ToTable("MonthlyBalances");
                });

            modelBuilder.Entity("StationBK.Core.Entities.Station.Oil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Commission")
                        .HasColumnType("float");

                    b.Property<float>("CurrentAmount")
                        .HasColumnType("float");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("IncomeAmount")
                        .HasColumnType("float");

                    b.Property<string>("OilName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("PreviousAmount")
                        .HasColumnType("float");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<float>("SoldAmount")
                        .HasColumnType("float");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Oils");
                });

            modelBuilder.Entity("StationBK.Core.Entities.Station.OilPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("bakm")
                        .HasColumnType("float");

                    b.Property<float>("coopFact20")
                        .HasColumnType("float");

                    b.Property<float>("coopFact4")
                        .HasColumnType("float");

                    b.Property<float>("coopFact5")
                        .HasColumnType("float");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("extra")
                        .HasColumnType("float");

                    b.Property<float>("hydraulic")
                        .HasColumnType("float");

                    b.Property<float>("mobil")
                        .HasColumnType("float");

                    b.Property<float>("shahm1")
                        .HasColumnType("float");

                    b.Property<float>("shahm2")
                        .HasColumnType("float");

                    b.Property<float>("shahm3")
                        .HasColumnType("float");

                    b.Property<float>("shell")
                        .HasColumnType("float");

                    b.Property<float>("sj")
                        .HasColumnType("float");

                    b.Property<float>("superStan20")
                        .HasColumnType("float");

                    b.Property<float>("superStan4")
                        .HasColumnType("float");

                    b.Property<float>("troosLarge")
                        .HasColumnType("float");

                    b.Property<float>("troosSmall")
                        .HasColumnType("float");

                    b.Property<float>("xpl")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("OilPrices");
                });

            modelBuilder.Entity("StationBK.Core.Entities.company.Balance", b =>
                {
                    b.Property<int>("BalanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("balance")
                        .HasColumnType("float");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.HasKey("BalanceId");

                    b.ToTable("Balances");
                });

            modelBuilder.Entity("StationBK.Core.Entities.company.Deposit", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("price")
                        .HasColumnType("float");

                    b.Property<string>("priceType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("StationBK.Core.Entities.company.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("petrol80Price")
                        .HasColumnType("float");

                    b.Property<float>("petrol92Price")
                        .HasColumnType("float");

                    b.Property<float>("solarPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("StationBK.Core.Entities.company.Purchace", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("price")
                        .HasColumnType("float");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Purchaces");
                });
#pragma warning restore 612, 618
        }
    }
}
