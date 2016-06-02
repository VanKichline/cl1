using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using cl1;

namespace cl1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20160602164558_LogEntry")]
    partial class LogEntry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20896");

            modelBuilder.Entity("cl1.LogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.Property<DateTime>("When");

                    b.HasKey("Id");

                    b.ToTable("LogEntries");
                });
        }
    }
}
