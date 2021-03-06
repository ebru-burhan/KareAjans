using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KareAjans.DataAccess.Migrations
{
    public partial class modelEmployeeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "ModelEmployees");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "ModelEmployees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 892, DateTimeKind.Local).AddTicks(9437));

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
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 903, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "SiteContents",
                keyColumn: "SiteContentID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 903, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 3, 6, 15, 5, 28, 894, DateTimeKind.Local).AddTicks(9730));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "ModelEmployees");

            migrationBuilder.AddColumn<byte>(
                name: "Age",
                table: "ModelEmployees",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 415, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 416, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "ExpenseTypes",
                keyColumn: "ExpenseTypeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 416, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 420, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "ProfessionalDegrees",
                keyColumn: "ProfessionalDegreeID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "SiteContents",
                keyColumn: "SiteContentID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 431, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "SiteContents",
                keyColumn: "SiteContentID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 431, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 2, 28, 16, 57, 13, 422, DateTimeKind.Local).AddTicks(8797));
        }
    }
}
