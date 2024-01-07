using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckManagement.Migrations
{
    public partial class userid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Delivery",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_UserID",
                table: "Delivery",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_User_UserID",
                table: "Delivery",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_User_UserID",
                table: "Delivery");

            migrationBuilder.DropIndex(
                name: "IX_Delivery_UserID",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Delivery");
        }
    }
}
