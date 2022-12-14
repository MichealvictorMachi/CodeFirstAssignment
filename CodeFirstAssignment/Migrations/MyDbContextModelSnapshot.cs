// <auto-generated />
using System;
using CodeFirstAssignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstAssignment.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MySchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirstAssignment.Models.Admission", b =>
                {
                    b.Property<string>("AdmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AdmissionFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UtmeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AdmissionId");

                    b.HasIndex("StudentId");

                    b.ToTable("Audiences");
                });

            modelBuilder.Entity("CodeFirstAssignment.Models.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatricNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SchoolFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UniType")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodeFirstAssignment.Models.Admission", b =>
                {
                    b.HasOne("CodeFirstAssignment.Models.Students", "Students")
                        .WithMany("Audiences")
                        .HasForeignKey("StudentId");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("CodeFirstAssignment.Models.Students", b =>
                {
                    b.Navigation("Audiences");
                });
#pragma warning restore 612, 618
        }
    }
}
