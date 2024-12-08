using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class AddingCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_payments_customerId",
                table: "payments",
                column: "customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_customers_customerId",
                table: "payments",
                column: "customerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_customers_customerId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_customerId",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "payments");
        }
    }
}
