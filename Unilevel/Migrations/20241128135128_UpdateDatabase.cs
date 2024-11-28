using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributor_Distributor_DistributorId",
                table: "SaleDistributor");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributor_SaleStaff_SaleStaffId",
                table: "SaleDistributor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleDistributor",
                table: "SaleDistributor");

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

            migrationBuilder.RenameTable(
                name: "SaleDistributor",
                newName: "SaleDistributors");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDistributor_SaleStaffId",
                table: "SaleDistributors",
                newName: "IX_SaleDistributors_SaleStaffId");

            migrationBuilder.AddColumn<string>(
                name: "UserComment",
                table: "CommentForJob",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleDistributors",
                table: "SaleDistributors",
                columns: new[] { "DistributorId", "SaleStaffId" });

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
                name: "FK_SaleDistributors_SaleStaff_SaleStaffId",
                table: "SaleDistributors",
                column: "SaleStaffId",
                principalTable: "SaleStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStaff_AspNetUsers_Id",
                table: "SaleStaff",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributors_Distributor_DistributorId",
                table: "SaleDistributors");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributors_SaleStaff_SaleStaffId",
                table: "SaleDistributors");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStaff_AspNetUsers_Id",
                table: "SaleStaff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleDistributors",
                table: "SaleDistributors");

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

            migrationBuilder.DropColumn(
                name: "UserComment",
                table: "CommentForJob");

            migrationBuilder.RenameTable(
                name: "SaleDistributors",
                newName: "SaleDistributor");

            migrationBuilder.RenameIndex(
                name: "IX_SaleDistributors_SaleStaffId",
                table: "SaleDistributor",
                newName: "IX_SaleDistributor_SaleStaffId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleDistributor",
                table: "SaleDistributor",
                columns: new[] { "DistributorId", "SaleStaffId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDistributor_Distributor_DistributorId",
                table: "SaleDistributor",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDistributor_SaleStaff_SaleStaffId",
                table: "SaleDistributor",
                column: "SaleStaffId",
                principalTable: "SaleStaff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
