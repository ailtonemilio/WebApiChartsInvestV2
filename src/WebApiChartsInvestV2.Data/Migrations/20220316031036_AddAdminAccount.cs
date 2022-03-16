using System;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApiChartsInvestV2.Model.Entities;

namespace WebApiChartsInvestV2.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID = "bba360bb-5bc5-4165-813f-729687a3a0ec";
        const string ADMIN_ROLE_GUID = "46cb6dc7-2d62-4563-b4b8-c1d05168d117";
        const string SECURITY_STAMP = "2SAASFCM3NLCBHWZTEDQ73ME32WILYUL";
        const string CONCURRENCY_STAMP = "2b2f361a-f944-42c3-ad01-34e18e00482a";
        const string CONCURRENCY_STAMP_ROLE = "87b786c5-fc27-4057-b11a-f49152982968";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var passwordHash = hasher.HashPassword(null, "Ae190273$");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO AspNetUsers(Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount,FirstName,LastName,Image)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{ADMIN_USER_GUID}'");
            sb.AppendLine(",'administrator'");
            sb.AppendLine(",'ADMINISTRATOR'");
            sb.AppendLine(",'ailtonemilio@hotmail.com'");
            sb.AppendLine(",'AILTONEMILIO@HOTMAIL.COM'");
            sb.AppendLine(", 0");
            sb.AppendLine($",'{passwordHash}'");
            sb.AppendLine($",'{SECURITY_STAMP}'");
            sb.AppendLine($",'{CONCURRENCY_STAMP}'");
            sb.AppendLine(", ''");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", NULL");
            sb.AppendLine(", 1");
            sb.AppendLine(", 0");
            sb.AppendLine(",'Ailton'");
            sb.AppendLine(",'Silva'");
            sb.AppendLine(",'ailtonjr.jpg'");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES ('{ADMIN_ROLE_GUID}','Admin','ADMIN','{CONCURRENCY_STAMP_ROLE}')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");
        }
    }
}
