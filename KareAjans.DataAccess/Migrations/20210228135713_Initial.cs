using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KareAjans.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    ExpenseTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 40, nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.ExpenseTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    OrganizationName = table.Column<string>(maxLength: 40, nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    EndingDate = table.Column<DateTime>(nullable: false),
                    IsLocal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UserType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionID);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalDegrees",
                columns: table => new
                {
                    ProfessionalDegreeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 40, nullable: false),
                    DailyWage = table.Column<decimal>(type: "money", nullable: false),
                    DailyPercentage = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalDegrees", x => x.ProfessionalDegreeID);
                });

            migrationBuilder.CreateTable(
                name: "SiteContents",
                columns: table => new
                {
                    SiteContentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    SiteContentType = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteContents", x => x.SiteContentID);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    IncomeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.IncomeID);
                    table.ForeignKey(
                        name: "FK_Incomes_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 40, nullable: false),
                    LastName = table.Column<string>(maxLength: 40, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Password = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelEmployees",
                columns: table => new
                {
                    ModelEmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ProfessionalDegreeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 40, nullable: false),
                    LastName = table.Column<string>(maxLength: 40, nullable: false),
                    Address = table.Column<string>(maxLength: 400, nullable: false),
                    PhoneNo1 = table.Column<string>(maxLength: 11, nullable: false),
                    PhoneNo2 = table.Column<string>(maxLength: 11, nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    Weight = table.Column<byte>(type: "tinyint", nullable: false),
                    Height = table.Column<byte>(type: "tinyint", nullable: false),
                    ShoeSize = table.Column<int>(nullable: false),
                    EyeColor = table.Column<int>(nullable: false),
                    HairColor = table.Column<int>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    BodySize = table.Column<int>(nullable: false),
                    DrivingLicence = table.Column<bool>(nullable: false),
                    WorkingOutsideTheCity = table.Column<bool>(nullable: false),
                    ForeignLanguage = table.Column<string>(maxLength: 40, nullable: true),
                    Speciality = table.Column<string>(maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelEmployees", x => x.ModelEmployeeID);
                    table.ForeignKey(
                        name: "FK_ModelEmployees_ProfessionalDegrees_ProfessionalDegreeId",
                        column: x => x.ProfessionalDegreeId,
                        principalTable: "ProfessionalDegrees",
                        principalColumn: "ProfessionalDegreeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelEmployees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModelEmployeeId = table.Column<int>(nullable: false),
                    Message = table.Column<string>(maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_ModelEmployees_ModelEmployeeId",
                        column: x => x.ModelEmployeeId,
                        principalTable: "ModelEmployees",
                        principalColumn: "ModelEmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModelEmployeeOrganizations",
                columns: table => new
                {
                    ModelEmployeeId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelEmployeeOrganizations", x => new { x.ModelEmployeeId, x.OrganizationId });
                    table.ForeignKey(
                        name: "FK_ModelEmployeeOrganizations_ModelEmployees_ModelEmployeeId",
                        column: x => x.ModelEmployeeId,
                        principalTable: "ModelEmployees",
                        principalColumn: "ModelEmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelEmployeeOrganizations_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    PictureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModelEmployeeId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PictureID);
                    table.ForeignKey(
                        name: "FK_Pictures_ModelEmployees_ModelEmployeeId",
                        column: x => x.ModelEmployeeId,
                        principalTable: "ModelEmployees",
                        principalColumn: "ModelEmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ExpenseTypeId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    ModelEmployeeOrganizationModelEmployeeId = table.Column<int>(nullable: true),
                    ModelEmployeeOrganizationOrganizationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseID);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "ExpenseTypes",
                        principalColumn: "ExpenseTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_ModelEmployeeOrganizations_ModelEmployeeOrganizationModelEmployeeId_ModelEmployeeOrganizationOrganizationId",
                        columns: x => new { x.ModelEmployeeOrganizationModelEmployeeId, x.ModelEmployeeOrganizationOrganizationId },
                        principalTable: "ModelEmployeeOrganizations",
                        principalColumns: new[] { "ModelEmployeeId", "OrganizationId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ExpenseTypes",
                columns: new[] { "ExpenseTypeID", "Amount", "CreatedDate", "Title" },
                values: new object[,]
                {
                    { 1, 10m, new DateTime(2021, 2, 28, 16, 57, 13, 415, DateTimeKind.Local).AddTicks(7252), "Yemek" },
                    { 2, 40m, new DateTime(2021, 2, 28, 16, 57, 13, 416, DateTimeKind.Local).AddTicks(2723), "Konaklama" },
                    { 3, 0m, new DateTime(2021, 2, 28, 16, 57, 13, 416, DateTimeKind.Local).AddTicks(2742), "Maas" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "CreatedDate", "UserType" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7858), 1 },
                    { 2, new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7889), 2 },
                    { 3, new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7891), 3 },
                    { 4, new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7893), 4 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionalDegrees",
                columns: new[] { "ProfessionalDegreeID", "CreatedDate", "DailyPercentage", "DailyWage", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(82), (byte)0, 40m, "Kategori1" },
                    { 2, new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(117), (byte)0, 100m, "Kategori2" },
                    { 3, new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(392), (byte)20, 0m, "Kategori3" }
                });

            migrationBuilder.InsertData(
                table: "SiteContents",
                columns: new[] { "SiteContentID", "CreatedDate", "SiteContentType", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 28, 16, 57, 13, 431, DateTimeKind.Local).AddTicks(8462), 0, "seed about" },
                    { 2, new DateTime(2021, 2, 28, 16, 57, 13, 431, DateTimeKind.Local).AddTicks(8494), 1, "seed references" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CreatedDate", "Email", "FirstName", "LastName", "Password", "PermissionId" },
                values: new object[] { 1, new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(8797), "ebru@gmail.com", "Ebru", "Burhan", "123", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ModelEmployeeId",
                table: "Comments",
                column: "ModelEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ModelEmployeeOrganizationModelEmployeeId_ModelEmployeeOrganizationOrganizationId",
                table: "Expenses",
                columns: new[] { "ModelEmployeeOrganizationModelEmployeeId", "ModelEmployeeOrganizationOrganizationId" });

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_OrganizationId",
                table: "Incomes",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelEmployeeOrganizations_OrganizationId",
                table: "ModelEmployeeOrganizations",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelEmployees_ProfessionalDegreeId",
                table: "ModelEmployees",
                column: "ProfessionalDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelEmployees_UserId",
                table: "ModelEmployees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_ModelEmployeeId",
                table: "Pictures",
                column: "ModelEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermissionId",
                table: "Users",
                column: "PermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "SiteContents");

            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "ModelEmployeeOrganizations");

            migrationBuilder.DropTable(
                name: "ModelEmployees");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "ProfessionalDegrees");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
