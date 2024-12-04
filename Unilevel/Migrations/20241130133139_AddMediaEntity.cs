using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddMediaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1add0713-46b2-429b-927c-b699f02c836e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2512d810-b264-46de-8bd9-0163f4b424c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dc822e3-2e11-4361-acfc-8e36277c4023");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ed7a655-0d21-4fc8-90c7-2680c2d4ad35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3eda5566-8215-4347-ad46-0feaff022490");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cbe0878-83a8-4fee-90b0-32b3bbe89f6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56d11230-8af1-450b-b956-03a60e445253");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84544bd0-d0c3-4ca9-b20e-f0355dca77ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2880422-7eb6-46f9-9e85-5fa965ef7446");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c13ad8e5-e4cd-44ab-bd8f-b710e640ddb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caf4a8d4-6c93-4c6f-bd18-dff913dd996e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e044fa61-ddb3-433e-a9c0-ccb80ea024a5");

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1add0713-46b2-429b-927c-b699f02c836e", "95f9cd71-412d-4546-9991-b5d591856410", 2, "BM", "BM" },
                    { "2512d810-b264-46de-8bd9-0163f4b424c5", "6905a8c5-cf7f-41be-b92c-adb2b5f08d1d", 2, "VPCD", "VPCD" },
                    { "2dc822e3-2e11-4361-acfc-8e36277c4023", "98c3595f-a1d1-4e5e-a2f7-1df4d06c26cd", 2, "BAM", "BAM" },
                    { "2ed7a655-0d21-4fc8-90c7-2680c2d4ad35", "c76d2312-651b-4a57-9347-8b5127aa26f5", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "3eda5566-8215-4347-ad46-0feaff022490", "c94d7850-7921-4668-9bec-4e27473c0b2d", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "4cbe0878-83a8-4fee-90b0-32b3bbe89f6f", "fc0b80c7-f570-4632-9707-fe6be1b0700c", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "56d11230-8af1-450b-b956-03a60e445253", "ccd062bd-48c2-44dc-aa65-5b4afd247d36", 1, "Administrator", "ADMINISTRATOR" },
                    { "84544bd0-d0c3-4ca9-b20e-f0355dca77ca", "bda764b9-c98c-4383-962c-c80d6388af34", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "b2880422-7eb6-46f9-9e85-5fa965ef7446", "3c848f29-3933-4de2-9b02-0679e04fff4f", 1, "Owner", "OWNER" },
                    { "c13ad8e5-e4cd-44ab-bd8f-b710e640ddb0", "c574ddf8-3aaa-4fb9-b420-9866b72bccda", 2, "ASM", "ASM" },
                    { "caf4a8d4-6c93-4c6f-bd18-dff913dd996e", "c1723bc8-1e83-4bfa-ba3a-d35f43bd88cb", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "e044fa61-ddb3-433e-a9c0-ccb80ea024a5", "b9a1fdd0-ed95-45e6-98d2-1bbd9cb0d3dc", 4, "Guest", "GUEST" }
                });
        }
    }
}
