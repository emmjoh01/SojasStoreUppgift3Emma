using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class FixedPhoneNumberPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberId",
                table: "PhoneNumbers");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeePhoneNumber",
                table: "PhoneNumbers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers",
                columns: new[] { "EmployeePhoneNumber", "EmployeeId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers");

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 6, "0106793264" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 7, "0704923456" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 3, "0705636178" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 3, "0726384950" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 5, "0734591435" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 8, "0736785437" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 6, "0768546326" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 2, "0792761426" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 4, "0794563832" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 5, "0824527501" });

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumns: new[] { "EmployeeId", "EmployeePhoneNumber" },
                keyValues: new object[] { 1, "1111111111" });

            migrationBuilder.AlterColumn<string>(
                name: "EmployeePhoneNumber",
                table: "PhoneNumbers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumberId",
                table: "PhoneNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers",
                column: "PhoneNumberId");

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "EmployeeId", "EmployeePhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, "1111111111" },
                    { 2, 2, "0792761426" },
                    { 3, 3, "0726384950" },
                    { 4, 3, "0705636178" },
                    { 5, 4, "0794563832" },
                    { 6, 5, "0734591435" },
                    { 7, 5, "0824527501" },
                    { 8, 6, "0768546326" },
                    { 9, 6, "0106793264" },
                    { 10, 7, "0704923456" },
                    { 11, 8, "0736785437" }
                });
        }
    }
}
