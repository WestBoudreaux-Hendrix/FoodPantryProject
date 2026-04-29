using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FUMCFoodPantry.Migrations
{
    /// <inheritdoc />
    public partial class UserDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    FixedAddress = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    Zip = table.Column<int>(type: "INTEGER", nullable: false),
                    Phone = table.Column<int>(type: "INTEGER", nullable: false),
                    Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmploymentStatus = table.Column<string>(type: "TEXT", nullable: false),
                    HosuingStatus = table.Column<string>(type: "TEXT", nullable: false),
                    PrimaryContact = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: false),
                    Household = table.Column<string>(type: "TEXT", nullable: false),
                    Disability = table.Column<string>(type: "TEXT", nullable: false),
                    Military = table.Column<string>(type: "TEXT", nullable: false),
                    Vetran = table.Column<string>(type: "TEXT", nullable: false),
                    Snap = table.Column<string>(type: "TEXT", nullable: false),
                    Family1Name = table.Column<string>(type: "TEXT", nullable: false),
                    Family1Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Family1Ethnicity = table.Column<string>(type: "TEXT", nullable: false),
                    Family1Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Family1Relationship = table.Column<string>(type: "TEXT", nullable: false),
                    Family1Income = table.Column<int>(type: "INTEGER", nullable: false),
                    Family2Name = table.Column<string>(type: "TEXT", nullable: false),
                    Family2Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Family2Ethnicity = table.Column<string>(type: "TEXT", nullable: false),
                    Family2Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Family2Relationship = table.Column<string>(type: "TEXT", nullable: false),
                    Family2Income = table.Column<int>(type: "INTEGER", nullable: false),
                    Family3Name = table.Column<string>(type: "TEXT", nullable: false),
                    Family3Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Family3Ethnicity = table.Column<string>(type: "TEXT", nullable: false),
                    Family3Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Family3Relationship = table.Column<string>(type: "TEXT", nullable: false),
                    Family3Income = table.Column<int>(type: "INTEGER", nullable: false),
                    Family4Name = table.Column<string>(type: "TEXT", nullable: false),
                    Family4Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Family4Ethnicity = table.Column<string>(type: "TEXT", nullable: false),
                    Family4Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Family4Relationship = table.Column<string>(type: "TEXT", nullable: false),
                    Family4Income = table.Column<int>(type: "INTEGER", nullable: false),
                    Family5Name = table.Column<string>(type: "TEXT", nullable: false),
                    Family5Birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Family5Ethnicity = table.Column<string>(type: "TEXT", nullable: false),
                    Family5Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Family5Relationship = table.Column<string>(type: "TEXT", nullable: false),
                    Family5Income = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApplications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserApplications");
        }
    }
}
