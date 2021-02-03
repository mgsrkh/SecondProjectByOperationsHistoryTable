using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondProjectByHistoryTable_Log_.Migrations
{
    public partial class Fix_History_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Vendor_VendorId",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_VendorId",
                table: "History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_History_VendorId",
                table: "History",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Vendor_VendorId",
                table: "History",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
