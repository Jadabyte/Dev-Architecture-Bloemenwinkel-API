using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace FlowerStoreAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 120, nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "ABC Street 1, Antwerp", "john.swan@example.com", "John", "Swan", "JohnSwan123" },
                    { 2, "DEF Street 2, Ghent", "jack.shoveler@example.com", "Jack", "Shoveler", "Js!123" },
                    { 3, "GHI Street 3, Brussels", "jason.sparrow@example.com", "Jason", "Sparrow", "SparrowIsMyName456" },
                    { 4, "JKL Street 4, Bruges", "justin.starling@example.com", "Justin", "Starling", "JustinWho?13" },
                    { 5, "MNO Street 5, Ostend", "joseph.swift@example.com", "Joseph", "Swift", "EasyPassword$9" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Flowering plant", "Rose", 4.50m },
                    { 2, "Spring-blooming", "Tulip", 2.50m },
                    { 3, "Flowering plant", "Orchid", 2.50m },
                    { 4, "Flowering plant", "Iris", 1.50m },
                    { 5, "Flowering plant", "Sunflower", 3.50m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "City", "Email", "Number", "Phone", "Street" },
                values: new object[,]
                {
                    { 1, "Brussels", "brussels@flowerstore.com", "12", "02 123 456", "Nieuwstraat" },
                    { 2, "Antwerp", "antwerp@flowerstore.com", "130", "03 123 456", "Meir" },
                    { 3, "Ghent", "ghent@flowerstore.com", "28", "09 123 456", "Veldstraat" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "Date", "ProductId", "StoreId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2020, 10, 18, 9, 30, 28, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 5, 4, new DateTime(2020, 10, 21, 10, 2, 13, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 2, 1, new DateTime(2020, 10, 18, 10, 15, 33, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 3, 2, new DateTime(2020, 10, 18, 11, 58, 12, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 4, 5, new DateTime(2020, 10, 21, 9, 45, 46, 0, DateTimeKind.Unspecified), 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
