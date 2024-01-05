using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagement.Migrations
{
    public partial class Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusID",
                table: "Delivery",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_StatusID",
                table: "Delivery",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Status_StatusID",
                table: "Delivery",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Status_StatusID",
                table: "Delivery");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Delivery_StatusID",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "StatusID",
                table: "Delivery");
        }
    }
}
