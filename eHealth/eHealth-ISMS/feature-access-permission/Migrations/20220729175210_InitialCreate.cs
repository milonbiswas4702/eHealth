using Microsoft.EntityFrameworkCore.Migrations;

namespace feature_access_permission.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessPermissions",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserWebId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViewPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatePermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditPermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletePermission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPermissions", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PageDefinations",
                columns: table => new
                {
                    PageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizedDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageDefinations", x => x.PageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessPermissions");

            migrationBuilder.DropTable(
                name: "PageDefinations");
        }
    }
}
