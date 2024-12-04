using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class UpgradeSomeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1af14a1d-9a5f-443a-bbe6-cd0562f2d50b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cf499bb-fb89-4cdd-b148-73b43f7dccce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3846e67c-bea9-4162-bfab-a2795dbbb679");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dd56e77-b1ea-4e4b-8324-835747eef610");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e260814-1086-4e3c-95dc-513e0a5cfdf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50ae5421-8596-4135-a62c-8d129ce0a589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7663eb3d-784f-40a2-b238-5f1b00832e9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9829a5fa-041d-4d39-8e16-34ce2a53271b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fd973e-5ff5-4fda-b6b6-4ada25d559e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be1134c4-0d4b-4cfb-bef7-96828ca45a0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7b28a22-263b-44f8-b9d2-299c2aebe6b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0c9bc0d-19bd-4bac-9591-66a331d4f4a7");

            migrationBuilder.AddColumn<bool>(
                name: "IsRefuseInvitation",
                table: "Visitors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "VisitCalendarStatus",
                table: "VisitCalendar",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCreateNotify",
                table: "Notification",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TaskStar",
                table: "JobDetail",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsRefuseInvitation",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "UserCreateNotify",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "TaskStar",
                table: "JobDetail");

            migrationBuilder.AlterColumn<string>(
                name: "VisitCalendarStatus",
                table: "VisitCalendar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1af14a1d-9a5f-443a-bbe6-cd0562f2d50b", "6d3966aa-5885-4f7b-b58c-c1908d848b33", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "1cf499bb-fb89-4cdd-b148-73b43f7dccce", "fdf85cf8-9229-4a4d-8fd9-87344e0d3836", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "3846e67c-bea9-4162-bfab-a2795dbbb679", "714c3780-af7b-4080-859e-c8d5ee75c528", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "3dd56e77-b1ea-4e4b-8324-835747eef610", "9042dffb-73f9-4ad5-a584-18797e7ab31c", 1, "Owner", "OWNER" },
                    { "3e260814-1086-4e3c-95dc-513e0a5cfdf6", "a1369c38-1f3d-498e-bf0e-9ff1e716c004", 2, "VPCD", "VPCD" },
                    { "50ae5421-8596-4135-a62c-8d129ce0a589", "32379226-0b44-4bab-9945-23968e8e5fa7", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "7663eb3d-784f-40a2-b238-5f1b00832e9d", "84537f85-5ab5-4010-acdb-de9a50c273ec", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "9829a5fa-041d-4d39-8e16-34ce2a53271b", "78d082e9-bac5-4404-8d5d-ab6ae86360db", 4, "Guest", "GUEST" },
                    { "a0fd973e-5ff5-4fda-b6b6-4ada25d559e1", "9881b694-8ce2-41d9-ad32-421bae5cbf4e", 2, "BAM", "BAM" },
                    { "be1134c4-0d4b-4cfb-bef7-96828ca45a0c", "537b8706-8da4-4771-9912-9da1a77d609b", 2, "ASM", "ASM" },
                    { "e7b28a22-263b-44f8-b9d2-299c2aebe6b4", "9ad373e3-e7d1-4628-8121-44d29e0a27d4", 2, "BM", "BM" },
                    { "f0c9bc0d-19bd-4bac-9591-66a331d4f4a7", "721bea26-2264-40e8-8f8e-86175831663b", 1, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
