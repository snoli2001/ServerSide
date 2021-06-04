﻿// <auto-generated />
using System;
using CarryDoggyGo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarryDoggyGo.Data.Migrations
{
    [DbContext(typeof(DbContextCarryDoggyGo))]
    partial class DbContextCarryDoggyGoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarryDoggyGo.Entities.Calification", b =>
                {
                    b.Property<int>("CalificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("calification_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Recomendations")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<int>("Starts")
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasColumnName("starts");

                    b.HasKey("CalificationId");

                    b.ToTable("calification");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.CareItem", b =>
                {
                    b.Property<int>("CareItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("care_item_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("CareItemId");

                    b.ToTable("care_item");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("dog_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Diseases")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("diseases");

                    b.Property<int>("DogOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("MedicalInformation")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("medical_information");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("race");

                    b.HasKey("DogId");

                    b.HasIndex("DogOwnerId");

                    b.ToTable("dogs");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogCareItem", b =>
                {
                    b.Property<int>("DogId")
                        .HasColumnType("int");

                    b.Property<int>("CareItemId")
                        .HasColumnType("int");

                    b.HasKey("DogId", "CareItemId");

                    b.HasIndex("CareItemId");

                    b.ToTable("DogCareItems");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogOwner", b =>
                {
                    b.Property<int>("DogOwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("dog_owner_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("phone");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("resgister_at");

                    b.HasKey("DogOwnerId");

                    b.ToTable("dog_owners");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogOwnerNotification", b =>
                {
                    b.Property<int>("DogOwnerNotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<int>("DogOwnerId")
                        .HasColumnType("int");

                    b.HasKey("DogOwnerNotificationId");

                    b.HasIndex("DogOwnerId");

                    b.ToTable("DogOwnerNotifications");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogWalk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AditionalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Calification")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DogOwnerId")
                        .HasColumnType("int");

                    b.Property<int>("DogWalkerId")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<string>("PaymentAmount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DogOwnerId");

                    b.HasIndex("DogWalkerId");

                    b.ToTable("DogWalk");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogWalker", b =>
                {
                    b.Property<int>("DogWalkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("dog_walker_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("birthdate");

                    b.Property<int>("Calification")
                        .HasColumnType("int")
                        .HasColumnName("calification");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("lastname");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("password");

                    b.Property<int>("PaymentAmount")
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasColumnName("payment_amount");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("phone");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("resgister_at");

                    b.HasKey("DogWalkerId");

                    b.ToTable("dog_walkers");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.NotificationDogWalker", b =>
                {
                    b.Property<int>("NotificationDogWalkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("notification_dogwalker_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AcceptDeny")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("accept_deny")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<int>("DogWalkerId")
                        .HasColumnType("int")
                        .HasColumnName("dog_walker_id");

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("shipping_date");

                    b.HasKey("NotificationDogWalkerId");

                    b.HasIndex("DogWalkerId");

                    b.ToTable("notification_dogwalker");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.Dog", b =>
                {
                    b.HasOne("CarryDoggyGo.Entities.DogOwner", "DogOwner")
                        .WithMany("Dogs")
                        .HasForeignKey("DogOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DogOwner");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogCareItem", b =>
                {
                    b.HasOne("CarryDoggyGo.Entities.CareItem", "CareItem")
                        .WithMany("DogCareItems")
                        .HasForeignKey("CareItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarryDoggyGo.Entities.Dog", "Dog")
                        .WithMany("DogCareItems")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CareItem");

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogOwnerNotification", b =>
                {
                    b.HasOne("CarryDoggyGo.Entities.DogOwner", "DogOwner")
                        .WithMany("DogOwnerNotifications")
                        .HasForeignKey("DogOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DogOwner");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogWalk", b =>
                {
                    b.HasOne("CarryDoggyGo.Entities.DogOwner", "DogOwner")
                        .WithMany("DogWalks")
                        .HasForeignKey("DogOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarryDoggyGo.Entities.DogWalker", "DogWalker")
                        .WithMany("DogWalks")
                        .HasForeignKey("DogWalkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DogOwner");

                    b.Navigation("DogWalker");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.NotificationDogWalker", b =>
                {
                    b.HasOne("CarryDoggyGo.Entities.DogWalker", "DogWalker")
                        .WithMany("NotificationDogWalkers")
                        .HasForeignKey("DogWalkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DogWalker");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.CareItem", b =>
                {
                    b.Navigation("DogCareItems");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.Dog", b =>
                {
                    b.Navigation("DogCareItems");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogOwner", b =>
                {
                    b.Navigation("DogOwnerNotifications");

                    b.Navigation("Dogs");

                    b.Navigation("DogWalks");
                });

            modelBuilder.Entity("CarryDoggyGo.Entities.DogWalker", b =>
                {
                    b.Navigation("DogWalks");

                    b.Navigation("NotificationDogWalkers");
                });
#pragma warning restore 612, 618
        }
    }
}
