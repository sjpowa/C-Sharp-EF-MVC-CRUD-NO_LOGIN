using Microsoft.EntityFrameworkCore.Migrations;

namespace CeLaFaremoMVC.Migrations
{
    public partial class migrazionEnums666 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Electronics_ElectronicId",
                table: "Phones");

            migrationBuilder.RenameColumn(
                name: "ElectronicCategories",
                table: "Phones",
                newName: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "ElectronicId",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Categories",
                table: "Laptops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Electronics_ElectronicId",
                table: "Phones",
                column: "ElectronicId",
                principalTable: "Electronics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Electronics_ElectronicId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Categories",
                table: "Laptops");

            migrationBuilder.RenameColumn(
                name: "Categories",
                table: "Phones",
                newName: "ElectronicCategories");

            migrationBuilder.AlterColumn<int>(
                name: "ElectronicId",
                table: "Phones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Electronics_ElectronicId",
                table: "Phones",
                column: "ElectronicId",
                principalTable: "Electronics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
