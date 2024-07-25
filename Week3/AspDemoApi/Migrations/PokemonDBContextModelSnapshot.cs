﻿// <auto-generated />
using AspDemoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspDemoApi.Migrations
{
    [DbContext(typeof(PokemonDBContext))]
    partial class PokemonDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspDemoApi.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PokemonId"));

                    b.Property<int>("DexId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerTrainerId")
                        .HasColumnType("int");

                    b.Property<string>("Type1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PokemonId");

                    b.HasIndex("OwnerTrainerId");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("AspDemoApi.Models.Trainer", b =>
                {
                    b.Property<int>("TrainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainerId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainerId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("AspDemoApi.Models.Pokemon", b =>
                {
                    b.HasOne("AspDemoApi.Models.Trainer", "Owner")
                        .WithMany("OwnedPokemon")
                        .HasForeignKey("OwnerTrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("AspDemoApi.Models.Trainer", b =>
                {
                    b.Navigation("OwnedPokemon");
                });
#pragma warning restore 612, 618
        }
    }
}
