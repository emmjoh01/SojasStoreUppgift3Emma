using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class FixedAfterResponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Emails");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeEmail",
                table: "Emails",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PercentPriceDrop",
                table: "Campaigns",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                columns: new[] { "EmployeeEmail", "EmployeeId" });

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "CampaignId",
                keyValue: 1,
                column: "PercentPriceDrop",
                value: 0.8m);

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "CampaignId",
                keyValue: 2,
                column: "PercentPriceDrop",
                value: 0.9m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "LastCheckedDate" },
                values: new object[] { new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "LastCheckedDate" },
                values: new object[] { new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SSN",
                table: "Employees",
                column: "SSN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_SSN",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "emillime@sojas.se", 6 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "emmatheclone@sojas.se", 7 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "f.galen@sojas.se", 4 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "fiaargalen@sojas.se", 4 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "haringenmail@sojas.se", 1 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "hugobossemalm@sojas.se", 3 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "hugoisboss@sojas.se", 3 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "johoemm@sojas.se", 8 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "kalasklas@sojas.se", 5 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "klonk@donk.se", 2 });

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumns: new[] { "EmployeeEmail", "EmployeeId" },
                keyValues: new object[] { "klonkydonk@sojas.se", 2 });

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeEmail",
                table: "Emails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Emails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "PercentPriceDrop",
                table: "Campaigns",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "EmailId");

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "CampaignId",
                keyValue: 1,
                column: "PercentPriceDrop",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Campaigns",
                keyColumn: "CampaignId",
                keyValue: 2,
                column: "PercentPriceDrop",
                value: 10);

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmployeeEmail", "EmployeeId" },
                values: new object[,]
                {
                    { 1, "haringenmail@sojas.se", 1 },
                    { 2, "klonk@donk.se", 2 },
                    { 3, "klonkydonk@sojas.se", 2 },
                    { 4, "hugoisboss@sojas.se", 3 },
                    { 5, "hugobossemalm@sojas.se", 3 },
                    { 6, "fiaargalen@sojas.se", 4 },
                    { 7, "f.galen@sojas.se", 4 },
                    { 8, "kalasklas@sojas.se", 5 },
                    { 9, "emillime@sojas.se", 6 },
                    { 10, "emmatheclone@sojas.se", 7 },
                    { 11, "johoemm@sojas.se", 8 }
                });

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
        }
    }
}
