using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.DAL.IdentityMigrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c0d1f12c-71da-4e2f-b993-49ba6d87f6a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "685f6b38-89ad-49fa-b8be-fa737139fc62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Path", "SecurityStamp" },
                values: new object[] { "10662aff-f7c8-4150-9365-799721161851", "AQAAAAEAACcQAAAAEM0j1fOgpoiKxfpqhyAfgqWCG8g5vsKU9UkPjN83/4trm4xS9kaP2duGEeAr9TTzuA==", "user-images/kullanici.png", "fc63f582-5725-4cc7-a378-bfd1c76d2c16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Path", "SecurityStamp" },
                values: new object[] { "1f31f886-b44a-43c4-bc30-275d88084e66", "AQAAAAEAACcQAAAAEM13MXQlxDM8ujJ51ufk4Idt/IgEECMyZ79/zRedCaqMd6jI+45Y0mb2MFSANkBZ0Q==", "user-images/kullanici.png", "be9543cf-5922-4c1d-aba9-07906cb1b7a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "405d1d8f-c74f-42d9-9ff6-78eed9c2fb5a", "AQAAAAEAACcQAAAAEPqMy6yrbPW/D5xKxweG7328X9MIvYvo4UGtzyEJnyMjsvvLAJc4KkJw9z+OxHoelA==", "ca49a832-df07-4338-b742-7d5cca65e8ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "983daf3f-da17-4c9e-90f5-0d96e73400a1", "AQAAAAEAACcQAAAAEHF/a9UOThMdyhgDhaSGgdBvdYKt7WyUg/feiHf1VjxBhnT1o0MMHoV8VRV2vPMqaQ==", "fb7acd0f-c3e7-41c2-bcc9-1ab8b2b0d5cd" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 3, 0, 10, 33, 831, DateTimeKind.Local).AddTicks(7266));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 314, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 314, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 314, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d37b0ddf-988d-4699-a5b6-77f3a49d0f9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "968d8faa-d35f-49a9-aba1-ace9cebbdbd5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Path", "SecurityStamp" },
                values: new object[] { "14e73f8d-c867-4e72-81e2-cb032236a010", "AQAAAAEAACcQAAAAECwxUL4akBZnKMZorMWFRA4wrrvyIxuj7pzd41zS9YY3vveWZVAD2LlAgiiPqxU8ZQ==", "user-images/ErdenTimur.jgp", "f0ea4088-29b7-41f3-8944-bfe2360d3a19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Path", "SecurityStamp" },
                values: new object[] { "71c89f95-f662-4efc-80eb-8fe5f7f9dac5", "AQAAAAEAACcQAAAAEFesBmqyJJzaasD8smE7lIUFPjcPEqSwodWpH6rHkVeOHgdOuDS14fUlWjfvCx/JMg==", "user-images/UmutOncel.jgp", "830bc4d9-7b66-4818-9db7-065cc2e6363a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9f7f4ce-15ab-46dc-8723-c9592a5cebb9", "AQAAAAEAACcQAAAAEEY+SApq4zkAqaZ7CdXCrCFpIHQqhIQWNUX0cOTiLYhesVpN+BLIFxRvtU/YQTqzcw==", "6eaa3933-5e25-4030-99e3-343428343cfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47bf206c-c2f7-4ba9-ac0b-4dbbe0833dbf", "AQAAAAEAACcQAAAAEIAs2hrej4pBP//BKvX5/2e0UurVExD9Fwo9vPwHP7RxHcCLItyjg1xk7gOoRJ/6zA==", "dd69ebb9-6fe6-42a2-a38d-79372f50e046" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 315, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 315, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 315, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 315, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 315, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 23, 58, 58, 315, DateTimeKind.Local).AddTicks(4886));
        }
    }
}
