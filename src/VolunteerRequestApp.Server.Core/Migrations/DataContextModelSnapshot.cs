﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolunteerRequestApp.Server.Core;

#nullable disable

namespace VolunteerRequestApp.Server.Core.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("RequestTag", b =>
                {
                    b.Property<int>("RequestsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagsTitle")
                        .HasColumnType("TEXT");

                    b.HasKey("RequestsId", "TagsTitle");

                    b.HasIndex("TagsTitle");

                    b.ToTable("RequestTag");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.CurrencyPair", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("СurrencyFrom")
                        .HasColumnType("TEXT");

                    b.Property<string>("СurrencyTo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CurrencyPairs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            СurrencyFrom = "UAH",
                            СurrencyTo = "USD"
                        },
                        new
                        {
                            Id = 2,
                            СurrencyFrom = "UAH",
                            СurrencyTo = "EUR"
                        });
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RequestId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Sum")
                        .HasColumnType("REAL");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.ExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrencyPairId")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyPairId");

                    b.ToTable("ExchangeRates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2022, 11, 14, 10, 0, 47, 872, DateTimeKind.Utc).AddTicks(7196),
                            CurrencyPairId = 1,
                            Value = 0.027076188000000001
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2022, 11, 14, 10, 0, 47, 872, DateTimeKind.Utc).AddTicks(7206),
                            CurrencyPairId = 2,
                            Value = 0.026223587
                        });
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Path")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RequestId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CloseDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<double?>("CurrentSum")
                        .HasColumnType("REAL");

                    b.Property<double?>("NeedSum")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("OpenDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TargetMilitary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Чорновик"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Активний"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Завершений"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Відмінений"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Архівний"
                        });
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Tag", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Title");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("RequestTag", b =>
                {
                    b.HasOne("VolunteerRequestApp.Server.Core.Request", null)
                        .WithMany()
                        .HasForeignKey("RequestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VolunteerRequestApp.Server.Core.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTitle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Donation", b =>
                {
                    b.HasOne("VolunteerRequestApp.Server.Core.Request", "Request")
                        .WithMany("Donations")
                        .HasForeignKey("RequestId");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.ExchangeRate", b =>
                {
                    b.HasOne("VolunteerRequestApp.Server.Core.CurrencyPair", "CurrenciesPair")
                        .WithMany("Records")
                        .HasForeignKey("CurrencyPairId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrenciesPair");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Photo", b =>
                {
                    b.HasOne("VolunteerRequestApp.Server.Core.Request", "Request")
                        .WithMany("Photos")
                        .HasForeignKey("RequestId");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Request", b =>
                {
                    b.HasOne("VolunteerRequestApp.Server.Core.Status", "Status")
                        .WithMany("Requests")
                        .HasForeignKey("StatusId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.CurrencyPair", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Request", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("VolunteerRequestApp.Server.Core.Status", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
