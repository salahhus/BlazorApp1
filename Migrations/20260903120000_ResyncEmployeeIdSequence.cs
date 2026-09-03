using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(BlazorApp1.Data.AppDbContext))]
    [Migration("20260903120000_ResyncEmployeeIdSequence")]
    public class ResyncEmployeeIdSequence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                SELECT setval(
                    pg_get_serial_sequence('""Employees""', 'Id'),
                    COALESCE((SELECT MAX(""Id"") FROM ""Employees""), 0) + 1,
                    false);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // No-op: sequence resync migration is intentionally not reversed.
        }
    }
}
