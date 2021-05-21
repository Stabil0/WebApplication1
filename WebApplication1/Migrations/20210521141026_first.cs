using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    check = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    FGS_employer = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false),
                    dish_1ID = table.Column<long>(nullable: true),
                    dish_2ID = table.Column<long>(nullable: true),
                    dish_3ID = table.Column<long>(nullable: true),
                    employeesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FGS = table.Column<string>(nullable: true),
                    Old = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Telefon = table.Column<int>(nullable: false),
                    Pasport = table.Column<string>(nullable: true),
                    PositionsID = table.Column<long>(nullable: true),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employee_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Volume_Ingredient_1 = table.Column<int>(nullable: false),
                    Cooking_time = table.Column<DateTime>(nullable: false),
                    Name_dish = table.Column<string>(nullable: true),
                    Volume_Ingredient_2 = table.Column<int>(nullable: false),
                    Volume_Ingredient_3 = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Ingredient_1ID = table.Column<long>(nullable: true),
                    Ingredient_2ID = table.Column<long>(nullable: true),
                    Ingredient_3ID = table.Column<long>(nullable: true),
                    OrderID = table.Column<long>(nullable: true),
                    OrderID1 = table.Column<long>(nullable: true),
                    OrderID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menu_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Menu_Order_OrderID1",
                        column: x => x.OrderID1,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Menu_Order_OrderID2",
                        column: x => x.OrderID2,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Positions = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Responsibilities = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    EmployeeID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Position_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shelf_life = table.Column<DateTime>(nullable: false),
                    Name_Ingredient = table.Column<string>(nullable: true),
                    Incept_date = table.Column<string>(nullable: true),
                    Volume = table.Column<int>(nullable: false),
                    Producer = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    MenuID = table.Column<long>(nullable: true),
                    MenuID1 = table.Column<long>(nullable: true),
                    MenuID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Warehouse_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warehouse_Menu_MenuID1",
                        column: x => x.MenuID1,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Warehouse_Menu_MenuID2",
                        column: x => x.MenuID2,
                        principalTable: "Menu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OrderID",
                table: "Employee",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_OrderID",
                table: "Menu",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_OrderID1",
                table: "Menu",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_OrderID2",
                table: "Menu",
                column: "OrderID2");

            migrationBuilder.CreateIndex(
                name: "IX_Position_EmployeeID",
                table: "Position",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_MenuID",
                table: "Warehouse",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_MenuID1",
                table: "Warehouse",
                column: "MenuID1");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouse_MenuID2",
                table: "Warehouse",
                column: "MenuID2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
