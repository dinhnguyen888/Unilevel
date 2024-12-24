using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class ChangeEntitySaleStaffAndDistributor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distributors_AspNetUsers_Id",
                table: "Distributors");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributors_Distributors_DistributorId",
                table: "SaleDistributors");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStaff_AspNetUsers_Id",
                table: "SaleStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitCalendar_Distributors_DistributorId",
                table: "VisitCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distributors",
                table: "Distributors");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00c18958-6561-44bd-80b1-970ea255e98a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "165f315d-337b-4732-ba7b-1d09f0fb735a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cf39519-423d-453e-bed5-65d47beb1df3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "456a7e40-6826-4304-b58c-84fdb6fc1262");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55379a41-451a-4e9e-b32d-327cd080e104");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ff214d-4406-49f5-a31f-d6f648981ff6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b93289f-7c13-4941-9d67-5d6a6d04afdf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e438858-a5e2-4499-9714-62a937f1e858");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70ac695a-1135-4dab-a606-78dc10e616c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b2401d7-eb7b-42b5-b347-ec2bd5e8dbde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9412bf47-32e4-4d5a-b5d8-08c35a400649");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cec17867-4957-4550-abcc-a52c310a9eac");

            migrationBuilder.RenameTable(
                name: "Distributors",
                newName: "Distributor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SaleStaff",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Distributor",
                newName: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distributor",
                table: "Distributor",
                column: "UserId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c4c1433-a4b2-4a74-9914-4671270b554d", "2ba6d6e7-518a-4503-a32c-9c20b47d2f32", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "0f829664-8427-4785-b56d-2033a6244ee1", "132e8b1b-2d9b-41ca-8991-5e397585cd92", 2, "BAM", "BAM" },
                    { "1bcc5a8a-be60-4d3c-8492-37086158160f", "41673641-9f2e-4021-920b-57937018a17c", 2, "BM", "BM" },
                    { "4cfa4316-941b-4f88-8853-53334dcb7c51", "4aa92ecc-c307-4575-9abc-c95140f1a511", 4, "Guest", "GUEST" },
                    { "5f9ae651-c7f6-4dba-963b-03bee2b3877a", "89f6e865-c9c7-47d4-871e-9eb7c9b5aa71", 1, "Administrator", "ADMINISTRATOR" },
                    { "5ff59d00-1a4c-4eea-98ba-fb83f501aa78", "e031d34a-99d8-4ab6-967a-db897aa6d455", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "76d6822d-9716-4ae9-bacd-937a960a869e", "e73602b3-48c7-4314-8718-24dd0e6a44a8", 2, "ASM", "ASM" },
                    { "8696e5ba-357d-4dd3-b966-c1f7c9106633", "8267ffb0-ca8c-4e03-99d5-64bb850a3dfd", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "8f910f9e-3a78-4fe7-96b4-57d0ea50c2ff", "d23c873b-dcf8-4a67-82de-4715a3c1b258", 2, "VPCD", "VPCD" },
                    { "96b3cce0-089c-489a-85fb-2282c37c4e38", "daeb1ff0-10b3-45ed-9f76-e6ddd3eca6e1", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "b42ed5c8-1d55-4c83-8132-4e847e3afe8b", "94fe590d-2934-42ae-95b8-697bac1df228", 1, "Owner", "OWNER" },
                    { "b55e0c63-ad66-45bc-8e2c-8180e5875474", "3e936f91-c528-4b81-b4a7-cf4d22650e7a", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Distributor_AspNetUsers_UserId",
                table: "Distributor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleDistributors_Distributor_DistributorId",
                table: "SaleDistributors",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleStaff_AspNetUsers_UserId",
                table: "SaleStaff",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitCalendar_Distributor_DistributorId",
                table: "VisitCalendar",
                column: "DistributorId",
                principalTable: "Distributor",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distributor_AspNetUsers_UserId",
                table: "Distributor");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleDistributors_Distributor_DistributorId",
                table: "SaleDistributors");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleStaff_AspNetUsers_UserId",
                table: "SaleStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitCalendar_Distributor_DistributorId",
                table: "VisitCalendar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Distributor",
                table: "Distributor");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c4c1433-a4b2-4a74-9914-4671270b554d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f829664-8427-4785-b56d-2033a6244ee1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bcc5a8a-be60-4d3c-8492-37086158160f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cfa4316-941b-4f88-8853-53334dcb7c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f9ae651-c7f6-4dba-963b-03bee2b3877a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ff59d00-1a4c-4eea-98ba-fb83f501aa78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76d6822d-9716-4ae9-bacd-937a960a869e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8696e5ba-357d-4dd3-b966-c1f7c9106633");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f910f9e-3a78-4fe7-96b4-57d0ea50c2ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96b3cce0-089c-489a-85fb-2282c37c4e38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b42ed5c8-1d55-4c83-8132-4e847e3afe8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b55e0c63-ad66-45bc-8e2c-8180e5875474");

            migrationBuilder.RenameTable(
                name: "Distributor",
                newName: "Distributors");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SaleStaff",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Distributors",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distributors",
                table: "Distributors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00c18958-6561-44bd-80b1-970ea255e98a", "ae027a86-7fb2-4a8c-85d6-adeb7887aa7f", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "165f315d-337b-4732-ba7b-1d09f0fb735a", "35d98d15-deac-4282-8166-02de330fa4ac", 2, "BAM", "BAM" },
                    { "2cf39519-423d-453e-bed5-65d47beb1df3", "4f114014-1fe6-4476-a654-84a0bc2e1731", 1, "Owner", "OWNER" },
                    { "456a7e40-6826-4304-b58c-84fdb6fc1262", "f5630f2e-9613-4daf-82aa-4b0ec7852533", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "55379a41-451a-4e9e-b32d-327cd080e104", "7eddab04-b941-499b-97ca-a6b1850a9331", 2, "ASM", "ASM" },
                    { "61ff214d-4406-49f5-a31f-d6f648981ff6", "59f547c9-4e0a-462a-9b32-300be16f455d", 4, "Guest", "GUEST" },
                    { "6b93289f-7c13-4941-9d67-5d6a6d04afdf", "21d5ef99-618c-4965-b775-3c16023a6c11", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "6e438858-a5e2-4499-9714-62a937f1e858", "d4b89cdc-e2ab-4e88-b484-f1f44bac8eb5", 2, "BM", "BM" },
                    { "70ac695a-1135-4dab-a606-78dc10e616c9", "0816d424-06ee-4058-852f-abae29f4ba0e", 1, "Administrator", "ADMINISTRATOR" },
                    { "7b2401d7-eb7b-42b5-b347-ec2bd5e8dbde", "ff30b6d4-d6a1-4c26-80eb-a13f9e83b422", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "9412bf47-32e4-4d5a-b5d8-08c35a400649", "4197a667-4832-44c1-a136-029ab6fdcd59", 2, "VPCD", "VPCD" },
                    { "cec17867-4957-4550-abcc-a52c310a9eac", "c28400cb-6389-49b4-b9b8-bebadf270e5b", 4, "OtherDepartment", "OTHER DEPARTMENT" }
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
                name: "FK_SaleStaff_AspNetUsers_Id",
                table: "SaleStaff",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitCalendar_Distributors_DistributorId",
                table: "VisitCalendar",
                column: "DistributorId",
                principalTable: "Distributors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
