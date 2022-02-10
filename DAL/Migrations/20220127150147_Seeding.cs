using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PercentPriceDrop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSN = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_Emails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    PhoneNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastCheckedByEmployeeId = table.Column<int>(type: "int", nullable: false),
                    AmountInStore = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastCheckedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOnCampaignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Campaigns_IsOnCampaignId",
                        column: x => x.IsOnCampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId");
                    table.ForeignKey(
                        name: "FK_Products_Employees_LastCheckedByEmployeeId",
                        column: x => x.LastCheckedByEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentProducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentProducts", x => new { x.DepartmentId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_DepartmentProducts_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartmentProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductIngredients",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductIngredients", x => new { x.ProductId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_ProductIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductIngredients_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "CampaignId", "PercentPriceDrop" },
                values: new object[,]
                {
                    { 1, 20 },
                    { 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "SSN" },
                values: new object[,]
                {
                    { 1, "Axel", "Oxenstierna", 158306166430L },
                    { 2, "Klonky", "Donky", 191243568790L },
                    { 3, "Hugo Bosse", "Malmberg", 196901011234L },
                    { 4, "Fialotta", "Galén", 197303172143L },
                    { 5, "Klas", "Muckberg", 198412136718L },
                    { 6, "Emil", "Lime", 199304302112L },
                    { 7, "Emma", "Klohonen Johansson", 200108214763L },
                    { 8, "Emmsan", "Johanssonskan", 200108245261L }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Mjöl" },
                    { 2, "Jäst" },
                    { 3, "Salt" },
                    { 4, "Vatten" },
                    { 5, "Mjölk" },
                    { 6, "Smör" },
                    { 7, "Socker" },
                    { 8, "Aromer" },
                    { 9, "Passionsfrukt" },
                    { 10, "Gröna äpplen" },
                    { 11, "Oxfilé" },
                    { 12, "Fläskfilé" },
                    { 13, "Smulat bröd" },
                    { 14, "Vanilj" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "EmployeeId", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Bröd" },
                    { 2, 4, "Dryck" },
                    { 3, 1, "Frukt" },
                    { 4, 1, "Kött" },
                    { 5, 6, "Mejeri" },
                    { 6, 3, "Skafferi" }
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AmountInStore", "ExpirationDate", "IsOnCampaignId", "LastCheckedByEmployeeId", "LastCheckedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunnbröd", 29 },
                    { 2, 23, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Korvbröd", 24 },
                    { 3, 73, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "RedBull", 16 },
                    { 4, 58, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CocaCola", 11 },
                    { 5, 2, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), null, 4, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Passionsfrukt", 4 },
                    { 6, 49, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), null, 2, new DateTime(2022, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), "Gröna äpplen, Granny Smith", 6 },
                    { 7, 3, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oxfilé", 399 },
                    { 8, 17, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fläskfilé", 199 },
                    { 9, 0, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mjölk", 14 },
                    { 10, 35, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vispgrädde", 25 },
                    { 11, 2, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ströbröd", 14 },
                    { 12, 13, new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mjöl", 23 },
                    { 13, 17, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vanillinsocker", 34 }
                });

            migrationBuilder.InsertData(
                table: "DepartmentProducts",
                columns: new[] { "DepartmentId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 11 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 13 },
                    { 4, 2 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 6, 11 },
                    { 6, 12 },
                    { 6, 13 }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 3, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 7, 4 },
                    { 8, 4 },
                    { 9, 4 },
                    { 9, 5 },
                    { 10, 6 },
                    { 11, 7 },
                    { 12, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 14, 11 },
                    { 1, 12 },
                    { 7, 13 },
                    { 14, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentProducts_ProductId",
                table: "DepartmentProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeId",
                table: "Departments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_EmployeeId",
                table: "Emails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_EmployeeId",
                table: "PhoneNumbers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredients_IngredientId",
                table: "ProductIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IsOnCampaignId",
                table: "Products",
                column: "IsOnCampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LastCheckedByEmployeeId",
                table: "Products",
                column: "LastCheckedByEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentProducts");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "ProductIngredients");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
