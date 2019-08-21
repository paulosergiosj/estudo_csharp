using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetMVC.Migrations
{
    public partial class SellerFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerID",
                table: "SalesRecord");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "SalesRecord",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerID",
                table: "SalesRecord",
                column: "SellerID",
                principalTable: "Seller",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerID",
                table: "SalesRecord");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "SellerID",
                table: "SalesRecord",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerID",
                table: "SalesRecord",
                column: "SellerID",
                principalTable: "Seller",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
