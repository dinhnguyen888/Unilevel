using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unilevel.Migrations
{
    public partial class AddSurvey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1de05086-75f2-481a-9720-b32d0feb34d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bac841d-f2ad-44e8-b5f8-179b30c5d191");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a9f6c08-4644-48d6-affc-041a93476fc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "404b9b70-2688-4641-bcf5-86f4e2dc71ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43fcbc55-62f6-4a6f-b5e3-f022d3a786af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69257004-2ce1-49d2-9c55-06448658946d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86e9eb6c-2448-4469-bab7-dca03c15656f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9db239e1-53c1-4006-9dbb-1f1801e8f722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a20d4863-29f7-44ff-b25a-f187728263e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1005c22-2911-448a-9812-f0fefa7c774e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4d5594d-57e7-4206-a783-32bf35340ab1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3b06b85-f565-4cbe-821e-d25fde97a530");

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAnswerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12aadad0-92c1-4fca-94c2-a10efe345a25", "aa21f099-2e7b-4645-848a-36e0d723536e", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "30e1cc9f-f452-4e51-a3d1-b7e63f72e181", "e9012593-c9b1-483c-8fc6-233a566270d7", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "442a5e84-6ae2-4b25-b749-a4b7ff322eff", "33f9e4d7-ceff-4192-9b90-baf3b82c97b9", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" },
                    { "4b54e1bd-62b0-47a7-82e6-a4964df40b64", "b83bdafe-5b0e-4477-b5c1-5aed785d62fa", 4, "Guest", "GUEST" },
                    { "55a46a8f-158a-449f-8ec6-e401a753a00f", "cc301bd3-73fa-430c-aa68-252a5d9966bf", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "687e9edf-20c0-441b-98a5-c6d054115879", "eb79e171-6e70-4ff3-b5b3-d62b9d4c3c71", 2, "BM", "BM" },
                    { "6a32ccea-5c06-4769-9371-92a8e8da440f", "825d6c6a-3e10-4436-933b-c7fed271c386", 2, "ASM", "ASM" },
                    { "a8a8f428-6cd8-43ca-84fb-221059009c0c", "9060ccea-a93c-47d9-bb71-134d96080446", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "b54d9043-f47d-4f22-b4a1-0445071936ab", "fab2cc16-9ce4-437c-882f-7f5fe4eda975", 1, "Administrator", "ADMINISTRATOR" },
                    { "b7d49737-48bc-45fa-9110-7a0d877bc6d6", "4a7c783a-756e-49fb-8827-7079e73b27c1", 2, "VPCD", "VPCD" },
                    { "e1240fa3-fa73-462d-924c-b8f30e3605c4", "921550fe-b154-43f9-b29b-0f707d578473", 2, "BAM", "BAM" },
                    { "ea4b2368-c902-4479-82a1-761111d82178", "9bac9cd9-bf87-4e10-b434-9522976039f6", 1, "Owner", "OWNER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserId",
                table: "Answers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyId",
                table: "Questions",
                column: "SurveyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12aadad0-92c1-4fca-94c2-a10efe345a25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30e1cc9f-f452-4e51-a3d1-b7e63f72e181");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "442a5e84-6ae2-4b25-b749-a4b7ff322eff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b54e1bd-62b0-47a7-82e6-a4964df40b64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55a46a8f-158a-449f-8ec6-e401a753a00f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "687e9edf-20c0-441b-98a5-c6d054115879");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a32ccea-5c06-4769-9371-92a8e8da440f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8a8f428-6cd8-43ca-84fb-221059009c0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b54d9043-f47d-4f22-b4a1-0445071936ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7d49737-48bc-45fa-9110-7a0d877bc6d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1240fa3-fa73-462d-924c-b8f30e3605c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea4b2368-c902-4479-82a1-761111d82178");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "GroupRoleId", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1de05086-75f2-481a-9720-b32d0feb34d6", "955d6aa9-cf75-45c0-8657-a388563f8421", 4, "OtherDepartment", "OTHER DEPARTMENT" },
                    { "2bac841d-f2ad-44e8-b5f8-179b30c5d191", "c2889cec-c649-46ac-baa7-4160ed0c62c2", 4, "Guest", "GUEST" },
                    { "3a9f6c08-4644-48d6-affc-041a93476fc4", "2de1966f-34a6-42a3-925d-e88dbbcc3d64", 1, "Administrator", "ADMINISTRATOR" },
                    { "404b9b70-2688-4641-bcf5-86f4e2dc71ff", "9052d320-0be0-45b1-84df-70a1f3814b24", 2, "BAM", "BAM" },
                    { "43fcbc55-62f6-4a6f-b5e3-f022d3a786af", "f3d9181e-8329-4b35-94c8-0874ef38102b", 1, "Owner", "OWNER" },
                    { "69257004-2ce1-49d2-9c55-06448658946d", "a649fcb8-34f0-4f8c-b126-539b41167fcf", 2, "VPCD", "VPCD" },
                    { "86e9eb6c-2448-4469-bab7-dca03c15656f", "70d8d824-5e35-46cf-807d-d271d99d0991", 2, "ASM", "ASM" },
                    { "9db239e1-53c1-4006-9dbb-1f1801e8f722", "d7ddc588-e2bc-45da-a5a4-efdd72b7e096", 3, "distributorOMTL", "DISTRIBUTOROMTL" },
                    { "a20d4863-29f7-44ff-b25a-f187728263e0", "6e1fb461-1e4d-45d0-9772-4ac9086db5d8", 2, "CE", "CE – CAPABILITY EXECUTIVE" },
                    { "b1005c22-2911-448a-9812-f0fefa7c774e", "240c8f99-f299-4b06-ad34-8bbd6f7deb31", 2, "SaleSUP", "SALE SUP – SALE SUPERVISOR" },
                    { "d4d5594d-57e7-4206-a783-32bf35340ab1", "3016db24-bd69-4173-af1f-da3319379956", 2, "BM", "BM" },
                    { "f3b06b85-f565-4cbe-821e-d25fde97a530", "9dc4d723-3c68-431f-b8f4-d99bcac953fd", 2, "ChannelActivationHead", "CHANNEL ACTIVATION HEAD" }
                });
        }
    }
}
