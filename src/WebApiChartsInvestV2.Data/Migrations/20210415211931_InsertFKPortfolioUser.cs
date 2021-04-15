using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiChartsInvestV2.Data.Migrations
{
    public partial class InsertFKPortfolioUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Portfolio",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfolio_UserId",
                table: "Portfolio",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_AspNetUsers_UserId",
                table: "Portfolio",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolio_AspNetUsers_ApplicationUserId",
                table: "Portfolio");

            migrationBuilder.DropIndex(
                name: "IX_Portfolio_ApplicationUserId",
                table: "Portfolio");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Portfolio");
        }
    }
}
