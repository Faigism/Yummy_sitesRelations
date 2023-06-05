﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yummy_RelationsSite_HomeTask_.DAL;

#nullable disable

namespace Yummy_RelationsSite_HomeTask_.Migrations
{
    [DbContext(typeof(DB_Context))]
    [Migration("20230604194442_createChefandProfessionandTestimonialandChefSocialMediaTables")]
    partial class createChefandProfessionandTestimonialandChefSocialMediaTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.Chef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.ChefSocialMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChefId")
                        .HasColumnType("int");

                    b.Property<int>("Chefİd")
                        .HasColumnType("int");

                    b.Property<string>("FbUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.ToTable("ChefSocialMedias");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChefId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChefId");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.Chef", b =>
                {
                    b.HasOne("Yummy_RelationsSite_HomeTask_.Entities.Profession", "Profession")
                        .WithMany("Chefs")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.ChefSocialMedia", b =>
                {
                    b.HasOne("Yummy_RelationsSite_HomeTask_.Entities.Chef", "Chef")
                        .WithMany("chefSocialMedias")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chef");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.Testimonial", b =>
                {
                    b.HasOne("Yummy_RelationsSite_HomeTask_.Entities.Chef", "Chef")
                        .WithMany("Testimonials")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chef");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.Chef", b =>
                {
                    b.Navigation("Testimonials");

                    b.Navigation("chefSocialMedias");
                });

            modelBuilder.Entity("Yummy_RelationsSite_HomeTask_.Entities.Profession", b =>
                {
                    b.Navigation("Chefs");
                });
#pragma warning restore 612, 618
        }
    }
}