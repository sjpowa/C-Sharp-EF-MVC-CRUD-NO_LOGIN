using Microsoft.EntityFrameworkCore.Migrations;

namespace CeLaFaremoMVC.Migrations
{
    public partial class migrazionEnums0500 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElectronicId",
                table: "Phones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ElectronicId",
                table: "Phones",
                column: "ElectronicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Electronics_ElectronicId",
                table: "Phones",
                column: "ElectronicId",
                principalTable: "Electronics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Electronics_ElectronicId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_ElectronicId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ElectronicId",
                table: "Phones");
        }
    }
}
