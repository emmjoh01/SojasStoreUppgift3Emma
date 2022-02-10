using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class MentorAndTraineeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MentorEmployeeId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "LastCheckedDate" },
                values: new object[] { new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "LastCheckedDate" },
                values: new object[] { new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MentorEmployeeId",
                table: "Employees",
                column: "MentorEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_MentorEmployeeId",
                table: "Employees",
                column: "MentorEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_MentorEmployeeId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MentorEmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MentorEmployeeId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "LastCheckedDate" },
                values: new object[] { new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "LastCheckedDate" },
                values: new object[] { new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
