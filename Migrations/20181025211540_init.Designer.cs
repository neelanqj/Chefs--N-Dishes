﻿// <auto-generated />
using System;
using Chefs__N_Dishes.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChefsNDishes.Migrations
{
    [DbContext(typeof(ChefsNDishesDbContext))]
    [Migration("20181025211540_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Chefs__N_Dishes.Models.Chef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("Chefs__N_Dishes.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Calories")
                        .IsRequired();

                    b.Property<int>("ChefId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Tastiness");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Chefs__N_Dishes.Models.Dish", b =>
                {
                    b.HasOne("Chefs__N_Dishes.Models.Chef", "Chef")
                        .WithMany("Dishes")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}