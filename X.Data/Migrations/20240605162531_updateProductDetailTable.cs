using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace X.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateProductDetailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 418, DateTimeKind.Local).AddTicks(6288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 133, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 419, DateTimeKind.Local).AddTicks(4471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 135, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 417, DateTimeKind.Local).AddTicks(6377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 131, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 420, DateTimeKind.Local).AddTicks(1396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 136, DateTimeKind.Local).AddTicks(2206));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 133, DateTimeKind.Local).AddTicks(5988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 418, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 135, DateTimeKind.Local).AddTicks(282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 419, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 131, DateTimeKind.Local).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 417, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 3, 16, 21, 52, 136, DateTimeKind.Local).AddTicks(2206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 5, 23, 25, 30, 420, DateTimeKind.Local).AddTicks(1396));
        }
    }
}
