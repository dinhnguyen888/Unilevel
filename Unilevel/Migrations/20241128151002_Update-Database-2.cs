using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributors_Distributor_DistributorId",
                table: "SaleDistributors");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitCalendar_Distributor_DistributorId",
                table: "VisitCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distributor",
                table: "Distributor");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18a5d4ed-87cd-48d9-96ab-1cfe76a1128d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41da2aa3-d04f-4415-8740-9e931ebf6056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "586c713c-672a-46df-9b1b-ca866ee8b994");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dabd8bd-c17d-4a4e-bf57-1ab8b7cac286");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8eee0adb-a1ef-4b43-9ac9-4c67a551e09f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991f521b-8bf0-4e58-962e-eac5173c7995");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9922500e-f20c-4ab6-b8bd-b52668eb978b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf72db1d-c01d-4851-889e-00f6945264cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d26fc17b-182e-4fb4-b54c-32119f9087b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5990ea8-722b-4d11-bdfe-0214fbc9a43f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef08cd3d-7f1e-4e34-972c-0964aa6b8b4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff4b3bb0-142d-4554-992f-9ca51892c8d1");

            migrationBuilder.RenameTable(
                name: "Distributor",
                newName: "Distributors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distributors",
                table: "Distributors",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Distributors_AspNetUsers_Id",
                table: "Distributors",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDistributors_Distributors_DistributorId",
                table: "SaleDistributors",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitCalendar_Distributors_DistributorId",
                table: "VisitCalendar",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distributors_AspNetUsers_Id",
                table: "Distributors");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributors_Distributors_DistributorId",
                table: "SaleDistributors");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitCalendar_Distributors_DistributorId",
                table: "VisitCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distributors",
                table: "Distributors");

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

            migrationBuilder.RenameTable(
                name: "Distributors",
                newName: "Distributor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distributor",
                table: "Distributor",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18a5d4ed-87cd-48d9-96ab-1cfe76a1128d", "66d6093e-15b9-4183-8a7c-7449534eac07", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "41da2aa3-d04f-4415-8740-9e931ebf6056", "c01e103b-ee6b-4791-a220-e3f60fa53dde", 2, "ASM", "ASM" },
                    { "586c713c-672a-46df-9b1b-ca866ee8b994", "aa47816a-e4db-4bb2-a1ef-5a663d64e193", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "8dabd8bd-c17d-4a4e-bf57-1ab8b7cac286", "de3201d7-45c9-4c57-9313-cd90949225e6", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "8eee0adb-a1ef-4b43-9ac9-4c67a551e09f", "e226f9c1-a0b9-4b7c-88b2-d0891b5dbe98", 2, "BAM", "BAM" },
                    { "991f521b-8bf0-4e58-962e-eac5173c7995", "00529fe7-6fdb-4846-9aff-6f5aebdf3b7d", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "9922500e-f20c-4ab6-b8bd-b52668eb978b", "77d0497b-82db-434d-8488-cbc19b4c126a", 2, "VPCD", "VPCD" },
                    { "cf72db1d-c01d-4851-889e-00f6945264cf", "9351fee9-11cd-4412-be40-5cb544478a29", 4, "Guest", "GUEST" },
                    { "d26fc17b-182e-4fb4-b54c-32119f9087b5", "7b5fcaf1-313d-4490-8f91-ffd613a747d4", 1, "Administrator", "ADMINISTRATOR" },
                    { "d5990ea8-722b-4d11-bdfe-0214fbc9a43f", "f1c3bbdf-b32b-4689-b138-f8e4b1fc7bcb", 2, "BM", "BM" },
                    { "ef08cd3d-7f1e-4e34-972c-0964aa6b8b4b", "4fedacd9-7483-4f25-9d6f-97e1e5b3e43e", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "ff4b3bb0-142d-4554-992f-9ca51892c8d1", "87a5af42-4fdc-46e7-9b3c-c546d04d95d7", 1, "Owner", "OWNER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDistributors_Distributor_DistributorId",
                table: "SaleDistributors",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitCalendar_Distributor_DistributorId",
                table: "VisitCalendar",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
