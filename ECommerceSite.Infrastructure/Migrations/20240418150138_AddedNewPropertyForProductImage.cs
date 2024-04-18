using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceSite.Infrastructure.Migrations
{
    public partial class AddedNewPropertyForProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/3f3e7049-5c99-428c-abcd-e246b086f2ed/air-force-1-07-shoes-SqKG2H.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.shooos.bg/media/catalog/product/cache/20/image/1350x778/9df78eab33525d08d6e5fb8d27136e95/b/b/bb54781.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_2000,h_2000/global/393540/01/sv04/fnd/DFA/fmt/png/PUMA-x-RIPNDIP-Tuff-Plus-Slippers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");
        }
    }
}
