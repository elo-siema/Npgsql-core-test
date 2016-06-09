using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql_core_test.Models;

namespace Npgsqlcoretest.Migrations
{
    [DbContext(typeof(DomainModelPostgreSqlContext))]
    [Migration("20160609203759_testMigration")]
    partial class testMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901");

            modelBuilder.Entity("Npgsql_core_test.Models.DataEventRecord", b =>
                {
                    b.Property<long>("DataEventRecordId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("SourceInfoId");

                    b.Property<long?>("SourceInfoId1");

                    b.Property<DateTime>("Timestamp");

                    b.Property<DateTime>("UpdatedTimestamp");

                    b.HasKey("DataEventRecordId");

                    b.HasIndex("SourceInfoId1");

                    b.ToTable("DataEventRecord");
                });

            modelBuilder.Entity("Npgsql_core_test.Models.SourceInfo", b =>
                {
                    b.Property<long>("SourceInfoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Timestamp");

                    b.Property<DateTime>("UpdatedTimestamp");

                    b.HasKey("SourceInfoId");

                    b.ToTable("SourceInfo");
                });

            modelBuilder.Entity("Npgsql_core_test.Models.DataEventRecord", b =>
                {
                    b.HasOne("Npgsql_core_test.Models.SourceInfo")
                        .WithMany()
                        .HasForeignKey("SourceInfoId1");
                });
        }
    }
}
