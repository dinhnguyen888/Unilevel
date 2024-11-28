using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddJobDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "JobStatus",
                table: "JobForVisitation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "JobDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LinkFileForCreatorReporter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkFileForWorkingPerson = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobDetail_JobForVisitation_Id",
                        column: x => x.Id,
                        principalTable: "JobForVisitation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentForJob",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentForJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentForJob_JobDetail_JobId",
                        column: x => x.JobId,
                        principalTable: "JobDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c64b432-184f-489b-be3f-8e8989e36824", "9e43e593-19b8-4a03-b6c3-2ee287af2676", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "2f40c06b-6ab6-4095-b58f-84547e6da106", "df5aea54-37db-4692-9fc7-0b200b97fc37", 2, "BM", "BM" },
                    { "4c19c4df-fde1-4710-9e6d-e2fca2f54d97", "21b156e9-de4c-4d0b-9f41-29560f2dda03", 2, "BAM", "BAM" },
                    { "4f9a1d5c-4d10-4e06-b903-eafe16ceefa5", "2e46d502-8f32-466a-a886-5adb38ab03ce", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "596d2795-7455-42bf-8b05-848571d7dcaf", "bbba0016-be18-4bca-b10e-8bdc5a28fd81", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "5ed7ee27-541f-48bf-9c83-ae0e43811177", "da146bf2-08c4-4c0e-907a-6e6e7178cf7f", 2, "ASM", "ASM" },
                    { "887a8ffb-3e7d-4701-8b2d-0fadf2c494af", "4eaef77a-9adf-473f-b4df-551a2e073bb9", 1, "Owner", "OWNER" },
                    { "95158ebb-cb91-4482-880e-d9e959bc0d14", "28276521-863c-4dd2-a92c-4a957402b834", 1, "Administrator", "ADMINISTRATOR" },
                    { "acc5f234-5edb-4af1-bf2b-2d4bae086580", "c787647f-282a-40a2-b4f1-81395e5e69ef", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "dbeb0c99-3d16-4d11-be9e-54d692dc9c09", "574ec10c-418b-4c1d-988b-4540c232e9ac", 2, "VPCD", "VPCD" },
                    { "e41d02b8-99e5-4b54-afa1-c291f45a1217", "90731fb7-97b1-4214-a7ba-d49e45af3131", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "eddb3ed5-b23f-4684-b079-afaf64565b15", "0f30c933-9548-4563-9c38-014c7df156f6", 4, "Guest", "GUEST" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentForJob_JobId",
                table: "CommentForJob",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentForJob");

            migrationBuilder.DropTable(
                name: "JobDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c64b432-184f-489b-be3f-8e8989e36824");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f40c06b-6ab6-4095-b58f-84547e6da106");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c19c4df-fde1-4710-9e6d-e2fca2f54d97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f9a1d5c-4d10-4e06-b903-eafe16ceefa5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "596d2795-7455-42bf-8b05-848571d7dcaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ed7ee27-541f-48bf-9c83-ae0e43811177");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "887a8ffb-3e7d-4701-8b2d-0fadf2c494af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95158ebb-cb91-4482-880e-d9e959bc0d14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acc5f234-5edb-4af1-bf2b-2d4bae086580");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbeb0c99-3d16-4d11-be9e-54d692dc9c09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e41d02b8-99e5-4b54-afa1-c291f45a1217");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eddb3ed5-b23f-4684-b079-afaf64565b15");

            migrationBuilder.DropColumn(
                name: "JobStatus",
                table: "JobForVisitation");

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
        }
    }
}
