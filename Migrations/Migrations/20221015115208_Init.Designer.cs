﻿// <auto-generated />
using System;
using DataAccess.Relational;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Migrations.Migrations
{
    [DbContext(typeof(DbServiceContext))]
    [Migration("20221015115208_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Relational.Abonnement.Entities.AbonnementEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<float>("BasePrice")
                        .HasColumnType("real")
                        .HasColumnName("base_price");

                    b.Property<byte>("Discount")
                        .HasColumnType("smallint")
                        .HasColumnName("discount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<byte>("NumberOfVisits")
                        .HasColumnType("smallint")
                        .HasColumnName("number_of_visits");

                    b.Property<byte>("Validity")
                        .HasColumnType("smallint")
                        .HasColumnName("validity");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("abonnement");
                });

            modelBuilder.Entity("DataAccess.Relational.Abonnement.Entities.SoldAbonnementEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<float>("BasePrice")
                        .HasColumnType("real")
                        .HasColumnName("base_price");

                    b.Property<long>("DateExpiration")
                        .HasColumnType("bigint")
                        .HasColumnName("date_expiration");

                    b.Property<long>("DateSale")
                        .HasColumnType("bigint")
                        .HasColumnName("date_sale");

                    b.Property<byte>("Discount")
                        .HasColumnType("smallint")
                        .HasColumnName("discount");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<byte>("NumberOfVisits")
                        .HasColumnType("smallint")
                        .HasColumnName("number_of_visits");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint")
                        .HasColumnName("person_id");

                    b.Property<float>("PriceSold")
                        .HasColumnType("real")
                        .HasColumnName("price_sold");

                    b.Property<byte>("Validity")
                        .HasColumnType("smallint")
                        .HasColumnName("validity");

                    b.Property<int>("VisitCounter")
                        .HasColumnType("integer")
                        .HasColumnName("visit_counter");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("sold_abonnement");
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.AuthEntity", b =>
                {
                    b.Property<long>("PersonId")
                        .HasColumnType("bigint")
                        .HasColumnName("person_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Hash")
                        .HasColumnType("text")
                        .HasColumnName("hash");

                    b.Property<byte>("Role")
                        .HasColumnType("smallint")
                        .HasColumnName("role");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("bytea")
                        .HasColumnName("salt");

                    b.Property<byte>("Status")
                        .HasColumnType("smallint")
                        .HasColumnName("status");

                    b.HasKey("PersonId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("auth");
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.ConfirmationCodeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("DateCreate")
                        .HasColumnType("bigint")
                        .HasColumnName("date_create");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint")
                        .HasColumnName("person_id");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("token");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("confirm_code");
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.PersonEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<bool>("HaveAuth")
                        .HasColumnType("boolean")
                        .HasColumnName("have_auth");

                    b.Property<bool>("IsTrainer")
                        .HasColumnType("boolean")
                        .HasColumnName("is_trainer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.HasKey("Id");

                    b.ToTable("person");
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.RefreshTokenEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("boolean")
                        .HasColumnName("is_revoked");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint")
                        .HasColumnName("person_id");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("refresh_token");
                });

            modelBuilder.Entity("DataAccess.Relational.Lesson.Entities.LessonEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<float>("BasePrice")
                        .HasColumnType("real")
                        .HasColumnName("base_price");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("DurationMinute")
                        .HasColumnType("integer")
                        .HasColumnName("duration_minute");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<long>("TrainerId")
                        .HasColumnType("bigint")
                        .HasColumnName("trainer_id");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("TrainerId");

                    b.ToTable("lesson");
                });

            modelBuilder.Entity("DataAccess.Relational.Relations.AbonnementsLessonsEntity", b =>
                {
                    b.Property<long>("AbonnementId")
                        .HasColumnType("bigint")
                        .HasColumnName("abonnement_id");

                    b.Property<long>("LessonId")
                        .HasColumnType("bigint")
                        .HasColumnName("lesson_id");

                    b.HasKey("AbonnementId", "LessonId");

                    b.HasIndex("LessonId");

                    b.ToTable("abonnements_lessons");
                });

            modelBuilder.Entity("DataAccess.Relational.Relations.SoldAbonnementsLessonsEntity", b =>
                {
                    b.Property<long>("LessonId")
                        .HasColumnType("bigint")
                        .HasColumnName("lesson_id");

                    b.Property<long>("SoldAbonnementId")
                        .HasColumnType("bigint")
                        .HasColumnName("abonnement_id");

                    b.HasKey("LessonId", "SoldAbonnementId");

                    b.HasIndex("SoldAbonnementId");

                    b.ToTable("sold_abonnements_lessons");
                });

            modelBuilder.Entity("DataAccess.Relational.Room.Entities.RoomEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("room");
                });

            modelBuilder.Entity("DataAccess.Relational.Abonnement.Entities.SoldAbonnementEntity", b =>
                {
                    b.HasOne("DataAccess.Relational.Auth.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.AuthEntity", b =>
                {
                    b.HasOne("DataAccess.Relational.Auth.Entities.PersonEntity", null)
                        .WithOne("Auth")
                        .HasForeignKey("DataAccess.Relational.Auth.Entities.AuthEntity", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.ConfirmationCodeEntity", b =>
                {
                    b.HasOne("DataAccess.Relational.Auth.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.RefreshTokenEntity", b =>
                {
                    b.HasOne("DataAccess.Relational.Auth.Entities.PersonEntity", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataAccess.Relational.Lesson.Entities.LessonEntity", b =>
                {
                    b.HasOne("DataAccess.Relational.Auth.Entities.PersonEntity", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("DataAccess.Relational.Relations.AbonnementsLessonsEntity", b =>
                {
                    b.HasOne("DataAccess.Relational.Abonnement.Entities.AbonnementEntity", null)
                        .WithMany()
                        .HasForeignKey("AbonnementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Relational.Lesson.Entities.LessonEntity", null)
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Relational.Relations.SoldAbonnementsLessonsEntity", b =>
                {
                    b.HasOne("DataAccess.Relational.Lesson.Entities.LessonEntity", null)
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Relational.Abonnement.Entities.SoldAbonnementEntity", null)
                        .WithMany()
                        .HasForeignKey("SoldAbonnementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Relational.Auth.Entities.PersonEntity", b =>
                {
                    b.Navigation("Auth");
                });
#pragma warning restore 612, 618
        }
    }
}
