using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    public partial class FirstDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_jobs",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    code = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    min_salary = table.Column<int>(type: "int", nullable: false),
                    max_salary = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_jobs", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "tb_roles",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_roles", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "tb_account_roles",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    account_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    role_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_account_roles", x => x.guid);
                    table.ForeignKey(
                        name: "FK_tb_account_roles_tb_roles_role_guid",
                        column: x => x.role_guid,
                        principalTable: "tb_roles",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_accounts",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_disabled = table.Column<bool>(type: "bit", nullable: false),
                    otp = table.Column<int>(type: "int", nullable: false),
                    is_otp_used = table.Column<bool>(type: "bit", nullable: false),
                    otp_expire_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_accounts", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "tb_departments",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    code = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    manager_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_departments", x => x.guid);
                });

            migrationBuilder.CreateTable(
                name: "tb_employees",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    birth_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hiring_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    department_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    job_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_employees", x => x.guid);
                    table.ForeignKey(
                        name: "FK_tb_employees_tb_departments_department_guid",
                        column: x => x.department_guid,
                        principalTable: "tb_departments",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_employees_tb_jobs_job_guid",
                        column: x => x.job_guid,
                        principalTable: "tb_jobs",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_job_histories",
                columns: table => new
                {
                    guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    employee_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    job_guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_job_histories", x => x.guid);
                    table.ForeignKey(
                        name: "FK_tb_job_histories_tb_employees_employee_guid",
                        column: x => x.employee_guid,
                        principalTable: "tb_employees",
                        principalColumn: "guid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_job_histories_tb_jobs_job_guid",
                        column: x => x.job_guid,
                        principalTable: "tb_jobs",
                        principalColumn: "guid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_account_roles_account_guid",
                table: "tb_account_roles",
                column: "account_guid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_account_roles_role_guid",
                table: "tb_account_roles",
                column: "role_guid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_accounts_email",
                table: "tb_accounts",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_departments_code",
                table: "tb_departments",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_departments_manager_guid",
                table: "tb_departments",
                column: "manager_guid",
                unique: true,
                filter: "[manager_guid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tb_departments_name",
                table: "tb_departments",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_employees_department_guid",
                table: "tb_employees",
                column: "department_guid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_employees_job_guid",
                table: "tb_employees",
                column: "job_guid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_employees_phone_number",
                table: "tb_employees",
                column: "phone_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_job_histories_employee_guid",
                table: "tb_job_histories",
                column: "employee_guid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_job_histories_job_guid",
                table: "tb_job_histories",
                column: "job_guid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_jobs_code",
                table: "tb_jobs",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_jobs_name",
                table: "tb_jobs",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_roles_name",
                table: "tb_roles",
                column: "name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_account_roles_tb_accounts_account_guid",
                table: "tb_account_roles",
                column: "account_guid",
                principalTable: "tb_accounts",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_accounts_tb_employees_guid",
                table: "tb_accounts",
                column: "guid",
                principalTable: "tb_employees",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_departments_tb_employees_manager_guid",
                table: "tb_departments",
                column: "manager_guid",
                principalTable: "tb_employees",
                principalColumn: "guid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_departments_tb_employees_manager_guid",
                table: "tb_departments");

            migrationBuilder.DropTable(
                name: "tb_account_roles");

            migrationBuilder.DropTable(
                name: "tb_job_histories");

            migrationBuilder.DropTable(
                name: "tb_accounts");

            migrationBuilder.DropTable(
                name: "tb_roles");

            migrationBuilder.DropTable(
                name: "tb_employees");

            migrationBuilder.DropTable(
                name: "tb_departments");

            migrationBuilder.DropTable(
                name: "tb_jobs");
        }
    }
}
