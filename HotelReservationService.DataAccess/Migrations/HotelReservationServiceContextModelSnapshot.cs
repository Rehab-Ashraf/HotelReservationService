﻿// <auto-generated />
using System;
using HotelReservationService.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelReservationService.DataAccess.Migrations
{
    [DbContext(typeof(HotelReservationServiceContext))]
    partial class HotelReservationServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Permission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.ToTable("Permissions", "UserManagement");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = 1,
                            Name = "Reservation Add"
                        },
                        new
                        {
                            Id = 2L,
                            Code = 2,
                            Name = "Reservation Edit"
                        },
                        new
                        {
                            Id = 3L,
                            Code = 3,
                            Name = "Reservation View"
                        },
                        new
                        {
                            Id = 4L,
                            Code = 4,
                            Name = "Reservation List"
                        },
                        new
                        {
                            Id = 5L,
                            Code = 5,
                            Name = "ReservationDelete"
                        });
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Reservation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FirstModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FirstModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("LastModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("MustDeletedPhysical")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<long?>("RoomId1")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<long?>("UserId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoomId1");

                    b.HasIndex("UserId1");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Roles", "UserManagement");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.RolePermission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<long?>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions", "UserManagement");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            PermissionId = 1L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            PermissionId = 2L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            PermissionId = 3L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            PermissionId = 4L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            PermissionId = 5L,
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 6L,
                            PermissionId = 1L,
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 7L,
                            PermissionId = 2L,
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 8L,
                            PermissionId = 3L,
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 9L,
                            PermissionId = 4L,
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 10L,
                            PermissionId = 5L,
                            RoleId = 2L
                        });
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FirstModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FirstModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("LastModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("MustDeletedPhysical")
                        .HasColumnType("bit");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "A1"
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "A2"
                        },
                        new
                        {
                            Id = 3L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "A3"
                        },
                        new
                        {
                            Id = 4L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "B1"
                        },
                        new
                        {
                            Id = 5L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "B2"
                        },
                        new
                        {
                            Id = 6L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "B3"
                        },
                        new
                        {
                            Id = 7L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "C1"
                        },
                        new
                        {
                            Id = 8L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "C2"
                        },
                        new
                        {
                            Id = 9L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "C3"
                        },
                        new
                        {
                            Id = 10L,
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            RoomNumber = "D1"
                        });
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedByUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("FirstModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FirstModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("LastModifiedByUserId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("MustDeletedPhysical")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username");

                    b.ToTable("Users", "UserManagement");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2024, 5, 6, 13, 15, 24, 581, DateTimeKind.Local),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "admin",
                            Password = "APZcOAa54g9YCy+oVymFVwiI0vj9SxbWQOpP4se8fRSObtaPDjWMVatj4walQXbL9w==",
                            RoleId = 1L,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2L,
                            CreationDate = new DateTime(2024, 5, 6, 13, 15, 24, 581, DateTimeKind.Local),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "User",
                            Password = "APidiwoLV/Sks9Iuq7JKpOshH4GOx45unMhLC7/BSy/flsyGn2W80GnPFNV2uTEPGw==",
                            RoleId = 2L,
                            Username = "User"
                        });
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Reservation", b =>
                {
                    b.HasOne("HotelReservationService.Entity.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId1");

                    b.HasOne("HotelReservationService.Entity.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId1");

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.RolePermission", b =>
                {
                    b.HasOne("HotelReservationService.Entity.Entities.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId");

                    b.HasOne("HotelReservationService.Entity.Entities.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId");

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.User", b =>
                {
                    b.HasOne("HotelReservationService.Entity.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.Room", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("HotelReservationService.Entity.Entities.User", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}