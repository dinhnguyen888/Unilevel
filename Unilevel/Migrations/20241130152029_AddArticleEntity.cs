using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddArticleEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d76a0f4-aa0a-4d54-8d11-c2e651073fb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ba4e024-4aeb-475c-bfd7-db17daf15ec0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c2cf265-41e0-4433-bf26-e6107f60652e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39226e26-fcb7-4406-99c1-03eadc961ff2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e2f770e-1339-400e-ab8f-cdbb5fea6a64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4234cea4-3e3a-478f-a225-001898fa6d35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f5968e6-fa1f-4977-881c-9ea2a8ee7fc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "987ddc74-9c11-4835-930d-99f40f976cf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b98ad349-d936-4eda-971d-79a192335407");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5bccff-2d37-46a7-bc53-c8d0eacafca4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8567502-f984-4fc5-8acc-01cf6b092532");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8b82b68-9ca3-4321-b542-34a6f755a2b3");

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00e3858e-e285-47dc-bda7-7fbbbb60e3ba", "eb8904cb-2b72-4ad3-ae64-2487ea96fded", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "03209c93-41ea-4d7a-a16e-2a822f9b06f6", "ce6d3356-e680-41f0-96f8-2588a57460f9", 2, "BM", "BM" },
                    { "19d0dd72-85c0-4a4b-a3e9-a0ae34f4fdc7", "bf6e63dc-c9a8-4902-828c-a9914716dadf", 1, "Owner", "OWNER" },
                    { "1dc413e7-ae63-45c3-a796-e4bcef5f89e0", "74342dd4-7cab-4d85-9c25-a9e6fde92cbf", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "26a1b693-bea1-4dee-9ee0-42a1975be4a5", "38dca20c-6c18-41f9-b324-d56682a1ad33", 2, "BAM", "BAM" },
                    { "88ba39a3-2b98-4274-8b04-8a6cd9a14e70", "cde26c41-b2d0-4242-80a3-16d1603adcd1", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "96185493-b5ce-439f-a88c-98d9ca4f5224", "fdf0198f-983e-42dd-b33e-87130fd49dce", 1, "Administrator", "ADMINISTRATOR" },
                    { "ae27b93f-c6ef-47ca-8ac3-160c8ffb0fbe", "8a691668-33a4-4930-99a0-f95509cedb0e", 4, "Guest", "GUEST" },
                    { "aff65079-8b04-4865-8482-9a22bfbb598e", "b4f4c082-93be-416f-9656-d0ec6673a6b8", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "be09425d-91b9-4a64-9b5e-2bfee35760c9", "cd1b8f73-cc35-4b20-9ed6-51787a6820b3", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "c513521f-9246-4d6f-9fd1-99fe9ec08bd3", "3bb31ef6-5d78-4fc6-b006-e2c210d50fce", 2, "ASM", "ASM" },
                    { "f8a26f3d-75d5-4084-acd9-5053ef29570f", "f38bafa4-a848-4720-9726-acc4d920d65b", 2, "VPCD", "VPCD" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00e3858e-e285-47dc-bda7-7fbbbb60e3ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03209c93-41ea-4d7a-a16e-2a822f9b06f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19d0dd72-85c0-4a4b-a3e9-a0ae34f4fdc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc413e7-ae63-45c3-a796-e4bcef5f89e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26a1b693-bea1-4dee-9ee0-42a1975be4a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ba39a3-2b98-4274-8b04-8a6cd9a14e70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96185493-b5ce-439f-a88c-98d9ca4f5224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae27b93f-c6ef-47ca-8ac3-160c8ffb0fbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aff65079-8b04-4865-8482-9a22bfbb598e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be09425d-91b9-4a64-9b5e-2bfee35760c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c513521f-9246-4d6f-9fd1-99fe9ec08bd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8a26f3d-75d5-4084-acd9-5053ef29570f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d76a0f4-aa0a-4d54-8d11-c2e651073fb0", "86383b76-95a4-4b4e-a0d8-48dc3553e60a", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "2ba4e024-4aeb-475c-bfd7-db17daf15ec0", "62476140-efd7-4827-a20f-66442e650a65", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "2c2cf265-41e0-4433-bf26-e6107f60652e", "a7c781a2-8347-4e1a-ae55-4243e00927a9", 1, "Administrator", "ADMINISTRATOR" },
                    { "39226e26-fcb7-4406-99c1-03eadc961ff2", "fbd28827-ca8e-4c8d-a4ce-d60b0abfbc42", 2, "BAM", "BAM" },
                    { "3e2f770e-1339-400e-ab8f-cdbb5fea6a64", "e4830fbd-8236-4af1-94db-3322346711a4", 1, "Owner", "OWNER" },
                    { "4234cea4-3e3a-478f-a225-001898fa6d35", "42aeb3d4-c615-4746-a07b-3801d9e1fdf2", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "4f5968e6-fa1f-4977-881c-9ea2a8ee7fc9", "69fcd274-a624-4f09-ba2e-cdd86a1ef682", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "987ddc74-9c11-4835-930d-99f40f976cf6", "03f24c6a-f490-4942-965d-f12c9ce1a705", 2, "BM", "BM" },
                    { "b98ad349-d936-4eda-971d-79a192335407", "a2e2a1e8-9820-4246-b431-c8c700fd6ade", 4, "Guest", "GUEST" },
                    { "ba5bccff-2d37-46a7-bc53-c8d0eacafca4", "97297e6a-9a9c-4681-82a2-7ab18aa610f6", 2, "VPCD", "VPCD" },
                    { "d8567502-f984-4fc5-8acc-01cf6b092532", "75fadcd2-f3c6-49a6-8c04-aed071b9194d", 2, "ASM", "ASM" },
                    { "d8b82b68-9ca3-4321-b542-34a6f755a2b3", "f1da2299-45d7-48f6-b91e-190f0fd2611f", 2, "CE", "CE – CAPABILITY EXECUTIVE" }
                });
        }
    }
}
