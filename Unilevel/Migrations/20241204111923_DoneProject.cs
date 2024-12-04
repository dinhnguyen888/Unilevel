using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class DoneProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f312417-7300-4c78-8be3-074ccbfc239c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f94cf3d-a9a3-455b-abac-54b1bfcc51cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "767a4634-5cd9-41fa-b7dd-529c273b4cf1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80b94c9a-e402-4f78-8340-d0f0190b0160");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a65e07fe-1637-4349-8f97-0744898d36d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7e0e6f1-5096-42bd-b285-bf04d11684a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb069022-373f-448b-aa64-a00bc08221dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3785ee4-bd9a-459b-9f4f-8689384f53fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dca97fe0-ead8-4426-b137-651e9de7cfdd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcb2a331-98cf-487b-9b9c-812351e0b9c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcdb40ff-fbc4-4f29-953b-d19598ff26f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec4df5f4-952a-4945-a44b-ff585e2c579a");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f312417-7300-4c78-8be3-074ccbfc239c", "9f1113e0-ed72-4b07-9ead-a923769ffa03", 2, "BAM", "BAM" },
                    { "6f94cf3d-a9a3-455b-abac-54b1bfcc51cd", "779b90b1-b064-4fcd-b9fc-04711439c3de", 1, "Owner", "OWNER" },
                    { "767a4634-5cd9-41fa-b7dd-529c273b4cf1", "db01bd65-f500-480e-9297-57f6e879ed97", 2, "BM", "BM" },
                    { "80b94c9a-e402-4f78-8340-d0f0190b0160", "e7c00c29-b85d-4af6-a748-a997ff02f072", 4, "Guest", "GUEST" },
                    { "a65e07fe-1637-4349-8f97-0744898d36d2", "b277c70c-dca5-4acd-9053-c18488041f79", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "c7e0e6f1-5096-42bd-b285-bf04d11684a5", "43ed5867-26d6-46cb-95c4-37de0593c0ee", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "cb069022-373f-448b-aa64-a00bc08221dc", "59ea34ef-c0f7-49c7-8105-5e7620c62ddc", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "d3785ee4-bd9a-459b-9f4f-8689384f53fa", "ced66377-55cb-4b4d-b931-17817f620d81", 1, "Administrator", "ADMINISTRATOR" },
                    { "dca97fe0-ead8-4426-b137-651e9de7cfdd", "f4b45683-1c1a-4d27-b9aa-7c23d94d8c86", 2, "ASM", "ASM" },
                    { "dcb2a331-98cf-487b-9b9c-812351e0b9c7", "06f1f328-acb7-4d11-87d8-b08f0ee989e2", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "dcdb40ff-fbc4-4f29-953b-d19598ff26f0", "02e343d7-9ea2-47fc-ae02-4e57ae716eb8", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "ec4df5f4-952a-4945-a44b-ff585e2c579a", "ad9a5fef-15f8-4d10-be23-d72f51b2add0", 2, "VPCD", "VPCD" }
                });
        }
    }
}
