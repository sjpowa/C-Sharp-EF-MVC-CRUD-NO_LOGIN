// <auto-generated />
using CeLaFaremoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CeLaFaremoMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211111114639_iSwearThisWillBeMyLastMigration")]
    partial class iSwearThisWillBeMyLastMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("CeLaFaremoMVC.Models.Electronic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Electronics");
                });

            modelBuilder.Entity("CeLaFaremoMVC.Models.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<int>("ElectronicId")
                        .HasColumnType("int");

                    b.Property<string>("Modello")
                        .HasColumnType("longtext");

                    b.Property<int>("RamMemory")
                        .HasColumnType("int");

                    b.Property<int>("SsdMemory")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ElectronicId");

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("CeLaFaremoMVC.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<int>("Categories")
                        .HasColumnType("int");

                    b.Property<int>("ElectronicId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ElectronicId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("CeLaFaremoMVC.Models.Laptop", b =>
                {
                    b.HasOne("CeLaFaremoMVC.Models.Electronic", null)
                        .WithMany("Laptops")
                        .HasForeignKey("ElectronicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CeLaFaremoMVC.Models.Phone", b =>
                {
                    b.HasOne("CeLaFaremoMVC.Models.Electronic", null)
                        .WithMany("Phones")
                        .HasForeignKey("ElectronicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CeLaFaremoMVC.Models.Electronic", b =>
                {
                    b.Navigation("Laptops");

                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
