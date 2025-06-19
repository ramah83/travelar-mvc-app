using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lf_egypt.App.Migrations
{
    /// <inheritdoc />
    public partial class AddWantsAdminToCustomers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WantsAdmin",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WantsAdmin",
                table: "Customers");
        }
    }
}
