using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class ChangeSomeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "061043bc-97d4-4fb8-a610-de551e1f189d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a76abee-15a8-45bb-87ec-b6297855e6d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f56493f-0f31-4cce-82e1-71baa86216f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14ac3eb5-7e82-4806-9298-fb8ea26b5e0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1df601d5-b835-40fb-9fd4-3a67b8531dfd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "225a86f9-b27f-49ee-ba9d-899e5f62f233");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67905a5f-1702-499e-92ed-776ecf905e5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e2ac51-39be-4b80-b925-3088b8426d2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75c49e6e-8f4c-4ad0-aac1-bffa2025caae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bbc1253-7768-469a-a331-9ab5cbca62c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9346bba2-d9af-4b52-b615-1284fbc3483d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8d8dff2-1e55-4f5a-b1d4-d7301b3a53b5");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                defaultValue: "Unknown",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GroupRoleId",
                table: "AspNetRoles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GroupRole",
                columns: table => new
                {
                    GroupRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupRoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRole", x => x.GroupRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "UserPermission",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermission", x => new { x.UserId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_UserPermission_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GroupRole",
                columns: new[] { "GroupRoleId", "GroupRoleName" },
                values: new object[,]
                {
                    { 1, "SystemUser" },
                    { 2, "Sale" },
                    { 3, "Distributor" },
                    { 4, "Guest" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04254319-bd83-4ae0-ab15-e668d8ec2d60", "a4c22144-5db8-4283-810e-bc12443a4bfb", "Role", 2, "BM", "BM" },
                    { "08635918-20b8-40d9-8a32-687bffab632c", "7da8f71f-b67f-4634-a2fc-51bd39bd154c", "Role", 1, "Owner", "OWNER" },
                    { "1398f135-30a4-4312-a83c-893bca742d2e", "290b3856-c605-478a-b34e-070b17cf72a3", "Role", 3, "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "4f684f94-d893-4928-8756-563fc1b012db", "0435b00f-39fc-4356-9ebc-e974d269bc3b", "Role", 4, "Guest", "GUEST" },
                    { "7bf3818c-0c6d-4967-b8ed-e59f234f6df4", "9ba66be1-b5b7-47d0-85b1-ee7e16684fd4", "Role", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "9401aa7c-11ad-4a83-a905-214e6e18e041", "5e42e06a-e318-467e-9666-0ede9e7bc379", "Role", 2, "BAM", "BAM" },
                    { "b0a34ef7-39f5-40a2-8b0c-535c428fcab4", "9df06dd6-f7bc-4554-a4ad-0b79b50eedf3", "Role", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "bba507ea-8af0-42e4-b5c3-0e845c1092be", "1664c1e2-1025-4b88-9a67-4ad9887c9b65", "Role", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "bba6d57f-58c5-48fc-975d-6194f94c092d", "ddda53a4-66b7-4513-8429-fa193e922c7f", "Role", 2, "VPCD", "VPCD" },
                    { "cf10eda2-ec57-448c-8efc-060e9d8b3c4c", "a0b6fe6b-7c85-4949-aefe-4df08292a6a2", "Role", 1, "Administrator", "ADMINISTRATOR" },
                    { "d795568c-c96c-4c9d-a72a-fdfa4ef9ea04", "e197449d-52d6-434d-affa-d0c10b09eb23", "Role", 2, "ASM", "ASM" },
                    { "ff9447e2-44af-4af4-ab0f-58624c59d666", "d35de113-6d07-4cf6-9bae-227f5e2540f4", "Role", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_GroupRoleId",
                table: "AspNetRoles",
                column: "GroupRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermission_PermissionId",
                table: "UserPermission",
                column: "PermissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_GroupRole_GroupRoleId",
                table: "AspNetRoles",
                column: "GroupRoleId",
                principalTable: "GroupRole",
                principalColumn: "GroupRoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_GroupRole_GroupRoleId",
                table: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GroupRole");

            migrationBuilder.DropTable(
                name: "UserPermission");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_GroupRoleId",
                table: "AspNetRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04254319-bd83-4ae0-ab15-e668d8ec2d60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08635918-20b8-40d9-8a32-687bffab632c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1398f135-30a4-4312-a83c-893bca742d2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f684f94-d893-4928-8756-563fc1b012db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf3818c-0c6d-4967-b8ed-e59f234f6df4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9401aa7c-11ad-4a83-a905-214e6e18e041");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0a34ef7-39f5-40a2-8b0c-535c428fcab4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bba507ea-8af0-42e4-b5c3-0e845c1092be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bba6d57f-58c5-48fc-975d-6194f94c092d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf10eda2-ec57-448c-8efc-060e9d8b3c4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d795568c-c96c-4c9d-a72a-fdfa4ef9ea04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff9447e2-44af-4af4-ab0f-58624c59d666");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "GroupRoleId",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true,
                oldDefaultValue: "Unknown");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "061043bc-97d4-4fb8-a610-de551e1f189d", "d24e3ad2-188a-4e00-a602-4861ab14f3f6", "BM", "BM" },
                    { "0a76abee-15a8-45bb-87ec-b6297855e6d7", "c02b4789-1416-4158-8bb5-439144c75af7", "Administrator", "ADMINISTRATOR" },
                    { "0f56493f-0f31-4cce-82e1-71baa86216f3", "e4f03eb4-7675-48a0-8889-d76d2191757e", "BAM", "BAM" },
                    { "14ac3eb5-7e82-4806-9298-fb8ea26b5e0b", "4f303f55-e029-467b-bd4a-316f2de1d5e8", "ASM", "ASM" },
                    { "1df601d5-b835-40fb-9fd4-3a67b8531dfd", "a065eec0-5909-4485-ad61-47148d9c321e", "OtherDepartment", "OTHER DEPARTMENT" },
                    { "225a86f9-b27f-49ee-ba9d-899e5f62f233", "aea0c564-08f6-4486-84b7-c052a6f5a928", "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "67905a5f-1702-499e-92ed-776ecf905e5c", "12850b4b-e590-4e0b-8f0a-3d939be098ce", "Guest", "GUEST" },
                    { "73e2ac51-39be-4b80-b925-3088b8426d2e", "1ec20d12-f52b-49a9-b475-c0a5edda681d", "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "75c49e6e-8f4c-4ad0-aac1-bffa2025caae", "f2e9c402-89c1-4f6b-bce8-e5e83054acc2", "Owner", "OWNER" },
                    { "7bbc1253-7768-469a-a331-9ab5cbca62c4", "b6f308b8-d373-45f1-92b7-0044d6d7e570", "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "9346bba2-d9af-4b52-b615-1284fbc3483d", "20125dac-9e5b-4327-87b3-6c5a1cff49f9", "Distributor-OM/TL", "DISTRIBUTOR - OM/TL" },
                    { "f8d8dff2-1e55-4f5a-b1d4-d7301b3a53b5", "86465365-f013-49d4-a96b-b54d59fc47cd", "VPCD", "VPCD" }
                });
        }
    }
}
