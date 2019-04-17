﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fr34kyn01535.GlobalBan;

namespace fr34kyn01535.GlobalBan.Migrations
{
    [DbContext(typeof(GlobalBanDbContext))]
    [Migration("20190417192634_GlobalBan1")]
    partial class GlobalBan1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("fr34kyn01535.GlobalBan.Models.Ban", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("AdminName")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("BanTime");

                    b.Property<int>("Duration");

                    b.Property<string>("PlayerId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("PlayerName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Reason")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("bans");
                });
#pragma warning restore 612, 618
        }
    }
}
