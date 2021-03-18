using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KareAjans.DataAccess.Migrations
{
    public partial class SeedFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 435, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 435, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 435, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 440, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 440, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 440, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 441, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 441, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 18, 20, 43, 27, 441, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "SiteContents",
                keyColumn: "SiteContentID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Text" },
                values: new object[] { new DateTime(2021, 3, 18, 20, 43, 27, 451, DateTimeKind.Local).AddTicks(961), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc efficitur mauris ac metus molestie, eu aliquet nisi ornare. Praesent ultricies erat quis enim molestie mollis. Phasellus in nunc ut justo efficitur sagittis id nec nisi. Aliquam erat volutpat. Phasellus posuere odio ut nulla tincidunt tincidunt." });

            migrationBuilder.UpdateData(
                table: "SiteContents",
                keyColumn: "SiteContentID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Text" },
                values: new object[] { new DateTime(2021, 3, 18, 20, 43, 27, 451, DateTimeKind.Local).AddTicks(999), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc efficitur mauris ac metus molestie, eu aliquet nisi ornare. Praesent ultricies erat quis enim molestie mollis. Phasellus in nunc ut justo efficitur sagittis id nec nisi. Aliquam erat volutpat. Phasellus posuere odio ut nulla tincidunt tincidunt." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Email", "Password" },
                values: new object[] { new DateTime(2021, 3, 18, 20, 43, 27, 442, DateTimeKind.Local).AddTicks(1770), "yonetici@kareajans.com", "1234" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "CreatedDate", "Email", "FirstName", "LastName", "Password", "PermissionId" },
                values: new object[] { 2, new DateTime(2021, 3, 18, 20, 43, 27, 442, DateTimeKind.Local).AddTicks(1810), "muhasebe@kareajans.com", "Muhasebeci", "Insan", "1234", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 887, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 888, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 888, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 892, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 892, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 892, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionID", "CreatedDate", "UserType" },
                values: new object[] { 4, new DateTime(2021, 3, 6, 15, 5, 28, 892, DateTimeKind.Local).AddTicks(9437), 4 });

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 894, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 894, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 894, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "SiteContents",
                keyColumn: "SiteContentID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Text" },
                values: new object[] { new DateTime(2021, 3, 6, 15, 5, 28, 903, DateTimeKind.Local).AddTicks(9198), "seed about" });

            migrationBuilder.UpdateData(
                table: "SiteContents",
                keyColumn: "SiteContentID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Text" },
                values: new object[] { new DateTime(2021, 3, 6, 15, 5, 28, 903, DateTimeKind.Local).AddTicks(9227), "seed references" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Email", "Password" },
                values: new object[] { new DateTime(2021, 3, 6, 15, 5, 28, 894, DateTimeKind.Local).AddTicks(9730), "ebru@gmail.com", "123" });
        }
    }
}
