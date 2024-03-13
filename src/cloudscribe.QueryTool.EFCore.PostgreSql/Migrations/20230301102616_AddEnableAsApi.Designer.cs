﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cloudscribe.QueryTool.EFCore.PostgreSql;

#nullable disable

namespace cloudscribe.QueryTool.EFCore.PostgreSql.Migrations
{
    [DbContext(typeof(QueryToolDbContext))]
    [Migration("20230301102616_AddEnableAsApi")]
    partial class AddEnableAsApi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("cloudscribe.QueryTool.Models.SavedQuery", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("CreatedUtc")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_utc");

                    b.Property<bool>("EnableAsApi")
                        .HasColumnType("boolean")
                        .HasColumnName("enable_as_api");

                    b.Property<Guid>("LastModifiedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("last_modified_by");

                    b.Property<DateTime>("LastModifiedUtc")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_modified_utc");

                    b.Property<Guid>("LastRunBy")
                        .HasColumnType("uuid")
                        .HasColumnName("last_run_by");

                    b.Property<DateTime>("LastRunUtc")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_run_utc");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Statement")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("statement");

                    b.HasKey("Id")
                        .HasName("pk_csqt_saved_query");

                    b.ToTable("csqt_saved_query", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
