using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class SecondDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tb_departments",
                columns: new[] { "guid", "code", "created_date", "manager_guid", "modified_date", "name" },
                values: new object[,]
                {
                    { new Guid("7644ad73-57b6-4640-9e8d-f929ba01e694"), "1", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9718), null, new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9725), "Finance" },
                    { new Guid("9e0e4c05-cde2-4900-88f9-2a2b8ee0dad6"), "6", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9728), null, new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9728), "Information Technology" },
                    { new Guid("e8246140-6e0a-488e-b451-9321b6694736"), "7", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9730), null, new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9730), "Human Resources" }
                });

            migrationBuilder.InsertData(
                table: "tb_jobs",
                columns: new[] { "guid", "code", "created_date", "max_salary", "min_salary", "modified_date", "name" },
                values: new object[,]
                {
                    { new Guid("1105117d-ed96-4206-bd43-0e13b7342770"), "101", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9925), 7500000, 5000000, new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9926), "Financial Analyst" },
                    { new Guid("25abd2bc-c0fe-411a-ba24-f26cbae523c2"), "601", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9930), 8000000, 6000000, new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9930), "Software Developer" },
                    { new Guid("a3b9dd56-768a-45f7-99e1-8b42e9c8847f"), "701", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9933), 7000000, 5000000, new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9933), "Recruitment Specialist" }
                });

            migrationBuilder.InsertData(
                table: "tb_roles",
                columns: new[] { "guid", "created_date", "modified_date", "name" },
                values: new object[,]
                {
                    { new Guid("8d1da011-8574-4be4-9f64-657254f764d6"), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9956), "Manager" },
                    { new Guid("aad98c8c-c71e-46f4-99c1-2d073ecb467f"), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9953), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9953), "Staff" },
                    { new Guid("aca8df20-f7d1-464c-947a-b22bc96c2394"), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9958), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "tb_employees",
                columns: new[] { "guid", "birth_date", "created_date", "department_guid", "first_name", "gender", "hiring_date", "job_guid", "last_name", "modified_date", "phone_number" },
                values: new object[] { new Guid("03e53d0a-09fe-42d3-80eb-3a80339f679d"), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9976), new Guid("7644ad73-57b6-4640-9e8d-f929ba01e694"), "John", 1, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1105117d-ed96-4206-bd43-0e13b7342770"), "Doe", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9977), "+123456789" });

            migrationBuilder.InsertData(
                table: "tb_employees",
                columns: new[] { "guid", "birth_date", "created_date", "department_guid", "first_name", "gender", "hiring_date", "job_guid", "last_name", "modified_date", "phone_number" },
                values: new object[] { new Guid("0c05eaec-3052-40b2-badd-8e69153a8c50"), new DateTime(1985, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9988), new Guid("9e0e4c05-cde2-4900-88f9-2a2b8ee0dad6"), "Jane", 0, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("25abd2bc-c0fe-411a-ba24-f26cbae523c2"), "Smith", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9989), "+987654321" });

            migrationBuilder.InsertData(
                table: "tb_employees",
                columns: new[] { "guid", "birth_date", "created_date", "department_guid", "first_name", "gender", "hiring_date", "job_guid", "last_name", "modified_date", "phone_number" },
                values: new object[] { new Guid("5bc27f65-a3ec-41cf-a1a7-701b4b674653"), new DateTime(1982, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9996), new Guid("e8246140-6e0a-488e-b451-9321b6694736"), "Bob", 1, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3b9dd56-768a-45f7-99e1-8b42e9c8847f"), "Johnson", new DateTime(2023, 12, 15, 18, 14, 54, 257, DateTimeKind.Local).AddTicks(9996), "+1122334455" });

            migrationBuilder.InsertData(
                table: "tb_accounts",
                columns: new[] { "guid", "created_date", "email", "is_disabled", "is_otp_used", "modified_date", "otp", "otp_expire_time", "password" },
                values: new object[,]
                {
                    { new Guid("03e53d0a-09fe-42d3-80eb-3a80339f679d"), new DateTime(2023, 12, 15, 18, 14, 54, 258, DateTimeKind.Local).AddTicks(23), "john.doe@example.com", false, true, new DateTime(2023, 12, 15, 18, 14, 54, 258, DateTimeKind.Local).AddTicks(23), 123456, new DateTime(2023, 12, 15, 18, 14, 54, 258, DateTimeKind.Local).AddTicks(25), "$2a$12$SEZHToPjPLxysIUi8R4zteX.xr9V/lFc6cX9RUcfaaEfKDDEBQARe" },
                    { new Guid("0c05eaec-3052-40b2-badd-8e69153a8c50"), new DateTime(2023, 12, 15, 18, 14, 54, 548, DateTimeKind.Local).AddTicks(5339), "jane.smith@example.com", false, true, new DateTime(2023, 12, 15, 18, 14, 54, 548, DateTimeKind.Local).AddTicks(5339), 123456, new DateTime(2023, 12, 15, 18, 14, 54, 548, DateTimeKind.Local).AddTicks(5341), "$2a$12$ciBejD9DKFjNpP9MpuQ6heVD.YWyz9ZF1YnxD41b.rzUGRvQAH8s." },
                    { new Guid("5bc27f65-a3ec-41cf-a1a7-701b4b674653"), new DateTime(2023, 12, 15, 18, 14, 54, 842, DateTimeKind.Local).AddTicks(3524), "bob.johnson@example.com", false, true, new DateTime(2023, 12, 15, 18, 14, 54, 842, DateTimeKind.Local).AddTicks(3525), 123456, new DateTime(2023, 12, 15, 18, 14, 54, 842, DateTimeKind.Local).AddTicks(3526), "$2a$12$ZKEq.sCZCgRjksC8T0OArezIqFVd1fB9Zp7MoVu/2gaxgYfHvgXxm" }
                });

            migrationBuilder.InsertData(
                table: "tb_job_histories",
                columns: new[] { "guid", "created_date", "employee_guid", "end_date", "is_active", "job_guid", "modified_date", "start_date" },
                values: new object[,]
                {
                    { new Guid("1dcfe8e6-aab6-4755-a26e-bc0b242f0b8c"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5199), new Guid("03e53d0a-09fe-42d3-80eb-3a80339f679d"), null, false, new Guid("1105117d-ed96-4206-bd43-0e13b7342770"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5199), new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50c6b709-c27c-48c8-bcbb-40ed0aa65adc"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5209), new Guid("0c05eaec-3052-40b2-badd-8e69153a8c50"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new Guid("25abd2bc-c0fe-411a-ba24-f26cbae523c2"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5209), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d545deda-1761-4e0d-95f3-74d1b884e415"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5225), new Guid("5bc27f65-a3ec-41cf-a1a7-701b4b674653"), null, false, new Guid("a3b9dd56-768a-45f7-99e1-8b42e9c8847f"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5226), new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "tb_account_roles",
                columns: new[] { "guid", "account_guid", "created_date", "modified_date", "role_guid" },
                values: new object[] { new Guid("a6846206-8357-4cd6-ad22-dc3750efd848"), new Guid("03e53d0a-09fe-42d3-80eb-3a80339f679d"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(4862), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(4874), new Guid("aad98c8c-c71e-46f4-99c1-2d073ecb467f") });

            migrationBuilder.InsertData(
                table: "tb_account_roles",
                columns: new[] { "guid", "account_guid", "created_date", "modified_date", "role_guid" },
                values: new object[] { new Guid("a6f6d4cc-b9af-41a8-a7d4-483b4233015f"), new Guid("5bc27f65-a3ec-41cf-a1a7-701b4b674653"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(5142), new Guid("aca8df20-f7d1-464c-947a-b22bc96c2394") });

            migrationBuilder.InsertData(
                table: "tb_account_roles",
                columns: new[] { "guid", "account_guid", "created_date", "modified_date", "role_guid" },
                values: new object[] { new Guid("bd8833d1-5d65-43fb-8e9d-9c040acef10d"), new Guid("0c05eaec-3052-40b2-badd-8e69153a8c50"), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 12, 15, 18, 14, 55, 131, DateTimeKind.Local).AddTicks(4945), new Guid("8d1da011-8574-4be4-9f64-657254f764d6") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_account_roles",
                keyColumn: "guid",
                keyValue: new Guid("a6846206-8357-4cd6-ad22-dc3750efd848"));

            migrationBuilder.DeleteData(
                table: "tb_account_roles",
                keyColumn: "guid",
                keyValue: new Guid("a6f6d4cc-b9af-41a8-a7d4-483b4233015f"));

            migrationBuilder.DeleteData(
                table: "tb_account_roles",
                keyColumn: "guid",
                keyValue: new Guid("bd8833d1-5d65-43fb-8e9d-9c040acef10d"));

            migrationBuilder.DeleteData(
                table: "tb_job_histories",
                keyColumn: "guid",
                keyValue: new Guid("1dcfe8e6-aab6-4755-a26e-bc0b242f0b8c"));

            migrationBuilder.DeleteData(
                table: "tb_job_histories",
                keyColumn: "guid",
                keyValue: new Guid("50c6b709-c27c-48c8-bcbb-40ed0aa65adc"));

            migrationBuilder.DeleteData(
                table: "tb_job_histories",
                keyColumn: "guid",
                keyValue: new Guid("d545deda-1761-4e0d-95f3-74d1b884e415"));

            migrationBuilder.DeleteData(
                table: "tb_accounts",
                keyColumn: "guid",
                keyValue: new Guid("03e53d0a-09fe-42d3-80eb-3a80339f679d"));

            migrationBuilder.DeleteData(
                table: "tb_accounts",
                keyColumn: "guid",
                keyValue: new Guid("0c05eaec-3052-40b2-badd-8e69153a8c50"));

            migrationBuilder.DeleteData(
                table: "tb_accounts",
                keyColumn: "guid",
                keyValue: new Guid("5bc27f65-a3ec-41cf-a1a7-701b4b674653"));

            migrationBuilder.DeleteData(
                table: "tb_roles",
                keyColumn: "guid",
                keyValue: new Guid("8d1da011-8574-4be4-9f64-657254f764d6"));

            migrationBuilder.DeleteData(
                table: "tb_roles",
                keyColumn: "guid",
                keyValue: new Guid("aad98c8c-c71e-46f4-99c1-2d073ecb467f"));

            migrationBuilder.DeleteData(
                table: "tb_roles",
                keyColumn: "guid",
                keyValue: new Guid("aca8df20-f7d1-464c-947a-b22bc96c2394"));

            migrationBuilder.DeleteData(
                table: "tb_employees",
                keyColumn: "guid",
                keyValue: new Guid("03e53d0a-09fe-42d3-80eb-3a80339f679d"));

            migrationBuilder.DeleteData(
                table: "tb_employees",
                keyColumn: "guid",
                keyValue: new Guid("0c05eaec-3052-40b2-badd-8e69153a8c50"));

            migrationBuilder.DeleteData(
                table: "tb_employees",
                keyColumn: "guid",
                keyValue: new Guid("5bc27f65-a3ec-41cf-a1a7-701b4b674653"));

            migrationBuilder.DeleteData(
                table: "tb_departments",
                keyColumn: "guid",
                keyValue: new Guid("7644ad73-57b6-4640-9e8d-f929ba01e694"));

            migrationBuilder.DeleteData(
                table: "tb_departments",
                keyColumn: "guid",
                keyValue: new Guid("9e0e4c05-cde2-4900-88f9-2a2b8ee0dad6"));

            migrationBuilder.DeleteData(
                table: "tb_departments",
                keyColumn: "guid",
                keyValue: new Guid("e8246140-6e0a-488e-b451-9321b6694736"));

            migrationBuilder.DeleteData(
                table: "tb_jobs",
                keyColumn: "guid",
                keyValue: new Guid("1105117d-ed96-4206-bd43-0e13b7342770"));

            migrationBuilder.DeleteData(
                table: "tb_jobs",
                keyColumn: "guid",
                keyValue: new Guid("25abd2bc-c0fe-411a-ba24-f26cbae523c2"));

            migrationBuilder.DeleteData(
                table: "tb_jobs",
                keyColumn: "guid",
                keyValue: new Guid("a3b9dd56-768a-45f7-99e1-8b42e9c8847f"));
        }
    }
}
