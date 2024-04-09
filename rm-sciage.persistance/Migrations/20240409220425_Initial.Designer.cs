﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rm_sciage.persistance;

#nullable disable

namespace rm_sciage.persistance.Migrations
{
    [DbContext(typeof(RmsciageDbContext))]
    [Migration("20240409220425_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("rm_sciage.domain.Entities.Pointing.ClockingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CLK_ID");

                    b.Property<TimeSpan>("ArrivalTime")
                        .HasColumnType("time")
                        .HasColumnName("CLK_ARRIVAL_TIME");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("CLK_CREATED_DATE");

                    b.Property<TimeSpan>("DepartureTime")
                        .HasColumnType("time")
                        .HasColumnName("CLK_DEPARTURE_TIME");

                    b.Property<bool>("IsAm")
                        .HasColumnType("bit")
                        .HasColumnName("CLK_IS_AM");

                    b.Property<DateTime?>("LastModifiedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("CLK_LAST_MODIFIED_DATE");

                    b.Property<Guid>("PointingId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CLK_POINTING_ID");

                    b.HasKey("Id");

                    b.HasIndex("PointingId");

                    b.ToTable("RMS_T_CLOCKING_CLK", (string)null);
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.Pointing.PointingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PTG_ID");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("PTG_CREATED_DATE");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("PTG_DATE");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PTG_DESCRIPTION");

                    b.Property<bool>("IsDriver")
                        .HasColumnType("bit")
                        .HasColumnName("PTG_IS_DRIVER");

                    b.Property<DateTime?>("LastModifiedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("PTG_LAST_MODIFIED_DATE");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USR_ID");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RMS_T_POINTING_PTG", (string)null);
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.Pointing.PointingSiteEntity", b =>
                {
                    b.Property<Guid>("PointingId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PTG_ID");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SITE_ID");

                    b.HasKey("PointingId", "SiteId");

                    b.HasIndex("SiteId");

                    b.ToTable("RMS_TR_POINTING_SITE", (string)null);
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.Site.SiteEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("STE_ID");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STE_ADDRESS");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STE_CITY");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("STE_CREATED_DATE");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STE_DESCRIPTION");

                    b.Property<DateTime?>("LastModifiedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("STE_LAST_MODIFIED_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STE_NAME");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STE_STATUS");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int")
                        .HasColumnName("STE_ZIP_CODE");

                    b.HasKey("Id");

                    b.ToTable("RMS_T_SITE_STE", (string)null);
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.User.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USR_ID");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("USR_BIRTH_DATE");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("USR_CREATED_DATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_EMAIL");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_FIRST_NAME");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("USR_IS_ADMIN");

                    b.Property<DateTime?>("LastModifiedDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("USR_UPDATED_DATE");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_LAST_NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_PASSWORD");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_PHONE");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_SKILLS");

                    b.HasKey("Id");

                    b.ToTable("RMS_T_USER_USR", (string)null);
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.Pointing.ClockingEntity", b =>
                {
                    b.HasOne("rm_sciage.domain.Entities.Pointing.PointingEntity", "Pointing")
                        .WithMany("Clockings")
                        .HasForeignKey("PointingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pointing");
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.Pointing.PointingEntity", b =>
                {
                    b.HasOne("rm_sciage.domain.Entities.User.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.Pointing.PointingSiteEntity", b =>
                {
                    b.HasOne("rm_sciage.domain.Entities.Pointing.PointingEntity", "Pointing")
                        .WithMany()
                        .HasForeignKey("PointingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rm_sciage.domain.Entities.Site.SiteEntity", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pointing");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("rm_sciage.domain.Entities.Pointing.PointingEntity", b =>
                {
                    b.Navigation("Clockings");
                });
#pragma warning restore 612, 618
        }
    }
}
