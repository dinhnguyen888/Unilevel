using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPermissions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15ab421d-fbf8-4232-8388-3537537c5b47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16e7f67b-4a27-4723-8299-e548479c8e14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3885a48f-9691-428a-9472-8f0dcbd0f75f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e3529e7-7a9f-4754-bb22-15f8ebc04c74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53983ae8-01eb-4c96-a6e4-561546c905a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d412212-4633-4c21-ab89-4c9e61a79ec0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cb50ef7-2ec7-40e3-8f48-e8d34bb9092b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9206f116-51c4-47c4-8b91-a3ccad08f0d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd5a6f4-d667-4008-bb7c-6aff12cdcc9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8cc526d-0a9c-4100-a7d2-8f50544448d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1e0a3ad-11a4-493d-8802-5a005b15a0ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb56fd0d-bfb8-4510-bb22-b1af894e0ca1");

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "JobForVisitation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "100292c1-6d98-4ed0-b4c6-7fc897303fcf", "efedf32e-5fae-47f5-a20b-544b64305752", 2, "BAM", "BAM" },
                    { "233159d2-e565-42bb-8eb2-8779b9cfcd2f", "550b7ab5-11cf-4680-a0fd-eebb82fdf39d", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "25132ac7-fe2a-4817-ab54-e0d7c078229b", "1192fdc3-07bb-470f-b297-68fa5c732280", 4, "Guest", "GUEST" },
                    { "37541fda-74f6-4222-a876-d902af4945b3", "f4e3410e-a763-4f04-8a76-db85d6e81f55", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "509e3ef2-3563-4d17-9de7-e6cb3fc8912c", "ac7f8a5e-476a-4b95-b89a-8cbca3bc9f38", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "727507c8-fa79-41bd-ab9f-b37de6c9bf5f", "4998e2c3-c203-42db-ac02-cfbddbedab52", 2, "VPCD", "VPCD" },
                    { "7ef72b6b-c04e-4f60-9120-e5f43918af25", "095389a2-a258-40c8-a247-f4af19e61e3e", 2, "ASM", "ASM" },
                    { "a8cebde4-ff2f-4681-8e21-151ec87a1276", "497ff1b6-1c65-4e14-82f4-4ffb3c1a1b53", 1, "Administrator", "ADMINISTRATOR" },
                    { "abcec270-dff2-48ab-89bd-fd7a3da826e5", "947ffc97-b60e-4c5a-8760-1157b4faa0c2", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "de724f9e-796d-4828-818e-3196937aeb7c", "ce6c9905-338a-4880-a39c-1eaabba28b9a", 2, "BM", "BM" },
                    { "eed61f2d-3e17-44cb-91aa-f7a8801d6750", "ac288481-eb07-4ed3-bcbf-317f5df2a447", 1, "Owner", "OWNER" },
                    { "fc721b15-7c26-4ffb-9c68-fb1ac72a2dab", "d4b3ea38-7988-45d6-a213-7dde4602d511", 4, "OtherDepartment", "OTHER DEPARTMENT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "100292c1-6d98-4ed0-b4c6-7fc897303fcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "233159d2-e565-42bb-8eb2-8779b9cfcd2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25132ac7-fe2a-4817-ab54-e0d7c078229b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37541fda-74f6-4222-a876-d902af4945b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "509e3ef2-3563-4d17-9de7-e6cb3fc8912c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "727507c8-fa79-41bd-ab9f-b37de6c9bf5f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ef72b6b-c04e-4f60-9120-e5f43918af25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8cebde4-ff2f-4681-8e21-151ec87a1276");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abcec270-dff2-48ab-89bd-fd7a3da826e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de724f9e-796d-4828-818e-3196937aeb7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eed61f2d-3e17-44cb-91aa-f7a8801d6750");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc721b15-7c26-4ffb-9c68-fb1ac72a2dab");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "JobForVisitation");

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_UserPermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPermissions_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15ab421d-fbf8-4232-8388-3537537c5b47", "9808c592-7611-4875-ad7e-3d15ef36ab83", 2, "BAM", "BAM" },
                    { "16e7f67b-4a27-4723-8299-e548479c8e14", "1b020eee-19df-49c7-b11c-c6d8134da132", 1, "Administrator", "ADMINISTRATOR" },
                    { "3885a48f-9691-428a-9472-8f0dcbd0f75f", "6807fe54-14e8-4988-bc6e-88d69252d283", 2, "VPCD", "VPCD" },
                    { "4e3529e7-7a9f-4754-bb22-15f8ebc04c74", "949b6ccc-7e5b-43c5-8348-0182fe534a84", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "53983ae8-01eb-4c96-a6e4-561546c905a4", "2c8be1af-c265-4db7-8980-64c0dbce2fb7", 1, "Owner", "OWNER" },
                    { "5d412212-4633-4c21-ab89-4c9e61a79ec0", "00dd6fc9-d91a-4cc6-945d-a601c97ce584", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "8cb50ef7-2ec7-40e3-8f48-e8d34bb9092b", "739fd024-b5a7-40e8-b21f-121c6dabe5f3", 4, "Guest", "GUEST" },
                    { "9206f116-51c4-47c4-8b91-a3ccad08f0d6", "98ea1050-d9af-4dd2-b830-b2e2acf0607d", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "9dd5a6f4-d667-4008-bb7c-6aff12cdcc9c", "a068aaca-0c62-4370-9a8a-48152a9734c1", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "a8cc526d-0a9c-4100-a7d2-8f50544448d6", "8f632ace-5872-48e5-b95b-a9fd08185cc4", 2, "BM", "BM" },
                    { "f1e0a3ad-11a4-493d-8802-5a005b15a0ea", "1b437557-14ab-4df1-bfa9-f0354cc0453a", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "fb56fd0d-bfb8-4510-bb22-b1af894e0ca1", "271738cd-9519-4412-b1d0-4c1e87c30747", 2, "ASM", "ASM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPermissions_PermissionId",
                table: "UserPermissions",
                column: "PermissionId");
        }
    }
}
