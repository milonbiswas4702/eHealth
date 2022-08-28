﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using feature_access_permission.Data;

namespace feature_access_permission.Migrations
{
    [DbContext(typeof(AccessPermissionContext))]
    partial class AccessPermissionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("feature_access_permission.Model.AccessPermission", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorizedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorizedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatePermission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletePermission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditPermission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserWebId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViewPermission")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AccessPermissions");
                });

            modelBuilder.Entity("feature_access_permission.Model.PageDefination", b =>
                {
                    b.Property<string>("PageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorizedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorizedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FunctionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PageId");

                    b.ToTable("PageDefinations");
                });
#pragma warning restore 612, 618
        }
    }
}
