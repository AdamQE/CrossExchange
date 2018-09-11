﻿// <auto-generated />
using System;
using CrossExchange;
using CrossExchange.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrossExchange.Migrations
{
    [DbContext(typeof(ExchangeContext))]
    [Migration("20180818121317_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrossExchange.HourlyShareRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Rate");

                    b.Property<string>("Symbol")
                        .IsRequired();

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("Shares");

                    b.HasData(
                        new { Id = 1, Rate = 90m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 2, Rate = 95m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 3, Rate = 100m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 3, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 4, Rate = 89m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 4, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 5, Rate = 110m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 6, Rate = 96m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 7, Rate = 97m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 8, Rate = 99m, Symbol = "REL", TimeStamp = new DateTime(2018, 8, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 9, Rate = 91m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 10, Rate = 96m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 11, Rate = 105m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 3, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 12, Rate = 87m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 4, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 13, Rate = 100m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 14, Rate = 98m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 15, Rate = 95m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 16, Rate = 92m, Symbol = "CBI", TimeStamp = new DateTime(2018, 8, 13, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });

            modelBuilder.Entity("CrossExchange.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Portfolios");

                    b.HasData(
                        new { Id = 1, Name = "John Doe" }
                    );
                });

            modelBuilder.Entity("CrossExchange.Trade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action");

                    b.Property<int>("NoOfShares");

                    b.Property<int>("PortfolioId");

                    b.Property<decimal>("Price");

                    b.Property<string>("Symbol");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("Trades");

                    b.HasData(
                        new { Id = 1, Action = "BUY", NoOfShares = 50, PortfolioId = 1, Price = 5000.0m, Symbol = "REL" },
                        new { Id = 2, Action = "BUY", NoOfShares = 100, PortfolioId = 1, Price = 10000.0m, Symbol = "REL" },
                        new { Id = 3, Action = "BUY", NoOfShares = 150, PortfolioId = 1, Price = 14250.0m, Symbol = "CBI" },
                        new { Id = 4, Action = "SELL", NoOfShares = 70, PortfolioId = 1, Price = 6790.0m, Symbol = "CBI" }
                    );
                });

            modelBuilder.Entity("CrossExchange.Trade", b =>
                {
                    b.HasOne("CrossExchange.Portfolio")
                        .WithMany("Trade")
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
