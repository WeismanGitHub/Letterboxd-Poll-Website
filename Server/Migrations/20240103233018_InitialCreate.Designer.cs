﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Database;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(LbPollContext))]
    [Migration("20240103233018_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Poll", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GuildId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("Vote", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChoiceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PollId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("PollId");

                    b.ToTable("Vote");
                });

            modelBuilder.Entity("Vote", b =>
                {
                    b.HasOne("Poll", null)
                        .WithMany("Votes")
                        .HasForeignKey("PollId");
                });

            modelBuilder.Entity("Poll", b =>
                {
                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
