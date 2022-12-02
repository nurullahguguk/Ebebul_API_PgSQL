using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ebebul.Repository.Migrations
{
    /// <inheritdoc />
    public partial class one : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatDate",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                type: "timestamp without time zone",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Categories",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatDate",
                table: "Categories",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreatDate" },
                values: new object[] { new DateTime(2022, 12, 2, 10, 4, 52, 37, DateTimeKind.Local).AddTicks(4613), new DateTime(2022, 12, 2, 10, 4, 52, 37, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreatDate" },
                values: new object[] { new DateTime(2022, 12, 2, 10, 4, 52, 37, DateTimeKind.Local).AddTicks(4629), new DateTime(2022, 12, 2, 10, 4, 52, 37, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "CreatDate" },
                values: new object[] { new DateTime(2022, 12, 2, 10, 4, 52, 37, DateTimeKind.Local).AddTicks(4632), new DateTime(2022, 12, 2, 10, 4, 52, 37, DateTimeKind.Local).AddTicks(4633) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthdate",
                table: "Users",
                type: "timestamp with time zone",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatDate",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Birthdate", "CreatDate" },
                values: new object[] { new DateTime(2022, 11, 29, 3, 14, 33, 57, DateTimeKind.Local).AddTicks(4807), new DateTime(2022, 11, 29, 3, 14, 33, 57, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CreatDate" },
                values: new object[] { new DateTime(2022, 11, 29, 3, 14, 33, 57, DateTimeKind.Local).AddTicks(4821), new DateTime(2022, 11, 29, 3, 14, 33, 57, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "CreatDate" },
                values: new object[] { new DateTime(2022, 11, 29, 3, 14, 33, 57, DateTimeKind.Local).AddTicks(4823), new DateTime(2022, 11, 29, 3, 14, 33, 57, DateTimeKind.Local).AddTicks(4824) });
        }
    }
}
