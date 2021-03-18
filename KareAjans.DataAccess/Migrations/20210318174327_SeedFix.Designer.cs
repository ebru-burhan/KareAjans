﻿// <auto-generated />
using System;
using KareAjans.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KareAjans.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210318174327_SeedFix")]
    partial class SeedFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KareAjans.Entity.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<int>("ModelEmployeeId")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("ModelEmployeeId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("KareAjans.Entity.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelEmployeeOrganizationModelEmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("ModelEmployeeOrganizationOrganizationId")
                        .HasColumnType("int");

                    b.HasKey("ExpenseID");

                    b.HasIndex("ExpenseTypeId");

                    b.HasIndex("ModelEmployeeOrganizationModelEmployeeId", "ModelEmployeeOrganizationOrganizationId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("KareAjans.Entity.ExpenseType", b =>
                {
                    b.Property<int>("ExpenseTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("ExpenseTypeID");

                    b.ToTable("ExpenseTypes");

                    b.HasData(
                        new
                        {
                            ExpenseTypeID = 1,
                            Amount = 10m,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 435, DateTimeKind.Local).AddTicks(993),
                            Title = "Yemek"
                        },
                        new
                        {
                            ExpenseTypeID = 2,
                            Amount = 40m,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 435, DateTimeKind.Local).AddTicks(6407),
                            Title = "Konaklama"
                        },
                        new
                        {
                            ExpenseTypeID = 3,
                            Amount = 0m,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 435, DateTimeKind.Local).AddTicks(6425),
                            Title = "Maas"
                        });
                });

            modelBuilder.Entity("KareAjans.Entity.Income", b =>
                {
                    b.Property<int>("IncomeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("IncomeID");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("KareAjans.Entity.ModelEmployee", b =>
                {
                    b.Property<int>("ModelEmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<int>("BodySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DrivingLicence")
                        .HasColumnType("bit");

                    b.Property<int>("EyeColor")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("ForeignLanguage")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("HairColor")
                        .HasColumnType("int");

                    b.Property<byte>("Height")
                        .HasColumnType("tinyint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("PhoneNo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("PhoneNo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int>("ProfessionalDegreeId")
                        .HasColumnType("int");

                    b.Property<int>("ShoeSize")
                        .HasColumnType("int");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<byte>("Weight")
                        .HasColumnType("tinyint");

                    b.Property<bool>("WorkingOutsideTheCity")
                        .HasColumnType("bit");

                    b.HasKey("ModelEmployeeID");

                    b.HasIndex("ProfessionalDegreeId");

                    b.HasIndex("UserId");

                    b.ToTable("ModelEmployees");
                });

            modelBuilder.Entity("KareAjans.Entity.ModelEmployeeOrganization", b =>
                {
                    b.Property<int>("ModelEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ModelEmployeeId", "OrganizationId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ModelEmployeeOrganizations");
                });

            modelBuilder.Entity("KareAjans.Entity.Organization", b =>
                {
                    b.Property<int>("OrganizationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsLocal")
                        .HasColumnType("bit");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrganizationID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("KareAjans.Entity.Permission", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("PermissionID");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermissionID = 1,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 440, DateTimeKind.Local).AddTicks(1656),
                            UserType = 1
                        },
                        new
                        {
                            PermissionID = 2,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 440, DateTimeKind.Local).AddTicks(1686),
                            UserType = 2
                        },
                        new
                        {
                            PermissionID = 3,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 440, DateTimeKind.Local).AddTicks(1688),
                            UserType = 3
                        });
                });

            modelBuilder.Entity("KareAjans.Entity.Picture", b =>
                {
                    b.Property<int>("PictureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PictureID");

                    b.HasIndex("ModelEmployeeId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("KareAjans.Entity.ProfessionalDegree", b =>
                {
                    b.Property<int>("ProfessionalDegreeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("DailyPercentage")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("DailyWage")
                        .HasColumnType("money");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("ProfessionalDegreeID");

                    b.ToTable("ProfessionalDegrees");

                    b.HasData(
                        new
                        {
                            ProfessionalDegreeID = 1,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 441, DateTimeKind.Local).AddTicks(3604),
                            DailyPercentage = (byte)0,
                            DailyWage = 40m,
                            Title = "Kategori1"
                        },
                        new
                        {
                            ProfessionalDegreeID = 2,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 441, DateTimeKind.Local).AddTicks(3639),
                            DailyPercentage = (byte)0,
                            DailyWage = 100m,
                            Title = "Kategori2"
                        },
                        new
                        {
                            ProfessionalDegreeID = 3,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 441, DateTimeKind.Local).AddTicks(3901),
                            DailyPercentage = (byte)20,
                            DailyWage = 0m,
                            Title = "Kategori3"
                        });
                });

            modelBuilder.Entity("KareAjans.Entity.SiteContent", b =>
                {
                    b.Property<int>("SiteContentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SiteContentType")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SiteContentID");

                    b.ToTable("SiteContents");

                    b.HasData(
                        new
                        {
                            SiteContentID = 1,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 451, DateTimeKind.Local).AddTicks(961),
                            SiteContentType = 0,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc efficitur mauris ac metus molestie, eu aliquet nisi ornare. Praesent ultricies erat quis enim molestie mollis. Phasellus in nunc ut justo efficitur sagittis id nec nisi. Aliquam erat volutpat. Phasellus posuere odio ut nulla tincidunt tincidunt."
                        },
                        new
                        {
                            SiteContentID = 2,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 451, DateTimeKind.Local).AddTicks(999),
                            SiteContentType = 1,
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc efficitur mauris ac metus molestie, eu aliquet nisi ornare. Praesent ultricies erat quis enim molestie mollis. Phasellus in nunc ut justo efficitur sagittis id nec nisi. Aliquam erat volutpat. Phasellus posuere odio ut nulla tincidunt tincidunt."
                        });
                });

            modelBuilder.Entity("KareAjans.Entity.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("PermissionId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 442, DateTimeKind.Local).AddTicks(1770),
                            Email = "yonetici@kareajans.com",
                            FirstName = "Ebru",
                            LastName = "Burhan",
                            Password = "1234",
                            PermissionId = 1
                        },
                        new
                        {
                            UserID = 2,
                            CreatedDate = new DateTime(2021, 3, 18, 20, 43, 27, 442, DateTimeKind.Local).AddTicks(1810),
                            Email = "muhasebe@kareajans.com",
                            FirstName = "Muhasebeci",
                            LastName = "Insan",
                            Password = "1234",
                            PermissionId = 3
                        });
                });

            modelBuilder.Entity("KareAjans.Entity.Comment", b =>
                {
                    b.HasOne("KareAjans.Entity.ModelEmployee", "ModelEmployee")
                        .WithMany("Comments")
                        .HasForeignKey("ModelEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KareAjans.Entity.Expense", b =>
                {
                    b.HasOne("KareAjans.Entity.ExpenseType", "ExpenseType")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KareAjans.Entity.ModelEmployeeOrganization", "ModelEmployeeOrganization")
                        .WithMany("Expenses")
                        .HasForeignKey("ModelEmployeeOrganizationModelEmployeeId", "ModelEmployeeOrganizationOrganizationId");
                });

            modelBuilder.Entity("KareAjans.Entity.Income", b =>
                {
                    b.HasOne("KareAjans.Entity.Organization", "Organization")
                        .WithMany("Incomes")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KareAjans.Entity.ModelEmployee", b =>
                {
                    b.HasOne("KareAjans.Entity.ProfessionalDegree", "ProfessionalDegree")
                        .WithMany("ModelEmployees")
                        .HasForeignKey("ProfessionalDegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KareAjans.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KareAjans.Entity.ModelEmployeeOrganization", b =>
                {
                    b.HasOne("KareAjans.Entity.ModelEmployee", "ModelEmployee")
                        .WithMany("ModelEmployeeOrganizations")
                        .HasForeignKey("ModelEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KareAjans.Entity.Organization", "Organization")
                        .WithMany("ModelEmployeeOrganizations")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KareAjans.Entity.Picture", b =>
                {
                    b.HasOne("KareAjans.Entity.ModelEmployee", "ModelEmployee")
                        .WithMany("Pictures")
                        .HasForeignKey("ModelEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KareAjans.Entity.User", b =>
                {
                    b.HasOne("KareAjans.Entity.Permission", "Permission")
                        .WithMany("Users")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
