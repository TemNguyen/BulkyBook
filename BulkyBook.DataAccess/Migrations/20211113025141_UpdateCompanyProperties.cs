using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyBook.DataAccess.Migrations
{
    public partial class UpdateCompanyProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("EXEC sp_RENAME 'dbo.Companies.CityAddress', 'StreetAddress', 'COLUMN'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
