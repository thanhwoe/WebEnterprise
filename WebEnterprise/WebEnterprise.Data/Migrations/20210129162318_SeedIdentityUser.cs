using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEnterprise.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_SchoolYears_SchoolYearID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SchoolYearID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GroupUserID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SchoolYearID",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "SchoolYears",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Megazines",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GroupUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DateFile",
                table: "Documents",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DepartmentCatelogorys",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NameStreet",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApartmentNumber",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1"), new Guid("9936b153-37a9-41d8-9781-f0532c25e732") });

            migrationBuilder.InsertData(
                table: "GroupUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("9936b153-37a9-41d8-9781-f0532c25e732"), "bfd4b872-223d-4306-80f7-05dfe881552c", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactID", "CreateOn", "DateOfBirth", "DepartmentCatelogoryID", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sex", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1"), 0, "cf53790e-e5ae-440e-b3c6-f29f9e6330fd", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "minhvu09033@gmail.com", true, "Tran Van", "Minh Vu", false, null, "minhvu09033@gmail.com", "admin", "AQAAAAEAACcQAAAAEKOig9PeN+y77FvGGb8k4kAmYZUxZY20wa14yod3TMsv7yoWkw00KO3KHkPOu4BAPw==", null, false, "", false, false, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYears_UserID",
                table: "SchoolYears",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolYears_Users_UserID",
                table: "SchoolYears",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolYears_Users_UserID",
                table: "SchoolYears");

            migrationBuilder.DropIndex(
                name: "IX_SchoolYears_UserID",
                table: "SchoolYears");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1"), new Guid("9936b153-37a9-41d8-9781-f0532c25e732") });

            migrationBuilder.DeleteData(
                table: "GroupUsers",
                keyColumn: "Id",
                keyValue: new Guid("9936b153-37a9-41d8-9781-f0532c25e732"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a0626e5f-0945-425c-9135-421ce9ffd4a1"));

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "SchoolYears");

            migrationBuilder.AddColumn<int>(
                name: "GroupUserID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SchoolYearID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Megazines",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "GroupUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateFile",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DepartmentCatelogorys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameStreet",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApartmentNumber",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SchoolYearID",
                table: "Users",
                column: "SchoolYearID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SchoolYears_SchoolYearID",
                table: "Users",
                column: "SchoolYearID",
                principalTable: "SchoolYears",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
