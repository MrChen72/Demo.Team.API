using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo3s.Migrations
{
    public partial class qaz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MCategoryModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCategoryModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MCityModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityTid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MCityModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MFileImg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MFileImg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MGoodsModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Specification = table.Column<int>(type: "int", nullable: false),
                    GoodsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GoodsImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsImgTid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsParticulars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsInventory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsState = table.Column<int>(type: "int", nullable: false),
                    GoodsTid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsCategoryTid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodssPecification = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGoodsModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MLogisticsModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LogisticsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MLogisticsModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MOrderFormModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoodsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consignee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOrderFormModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MShoppingModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoodsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsPrice = table.Column<float>(type: "real", nullable: false),
                    GoodsImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    Specificationid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MShoppingModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MSpecificationModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecificationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MSpecificationModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RPowerModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PowerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPowerModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RPowerRoleModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PowerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPowerRoleModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RRoleModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RRoleModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RTreeModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeTid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TreeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTreeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RUserModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSex = table.Column<int>(type: "int", nullable: false),
                    UserAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPwd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserHeadPortrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAge = table.Column<int>(type: "int", nullable: false),
                    UserState = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUserModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RUserRoleModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUserRoleModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MCategoryModel");

            migrationBuilder.DropTable(
                name: "MCityModel");

            migrationBuilder.DropTable(
                name: "MFileImg");

            migrationBuilder.DropTable(
                name: "MGoodsModel");

            migrationBuilder.DropTable(
                name: "MLogisticsModel");

            migrationBuilder.DropTable(
                name: "MOrderFormModel");

            migrationBuilder.DropTable(
                name: "MShoppingModel");

            migrationBuilder.DropTable(
                name: "MSpecificationModel");

            migrationBuilder.DropTable(
                name: "RPowerModel");

            migrationBuilder.DropTable(
                name: "RPowerRoleModel");

            migrationBuilder.DropTable(
                name: "RRoleModel");

            migrationBuilder.DropTable(
                name: "RTreeModel");

            migrationBuilder.DropTable(
                name: "RUserModel");

            migrationBuilder.DropTable(
                name: "RUserRoleModel");
        }
    }
}
