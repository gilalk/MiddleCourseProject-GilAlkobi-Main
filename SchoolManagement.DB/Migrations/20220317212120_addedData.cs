using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement.DB.Migrations
{
    public partial class addedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "y1234", "yehudan" });

            migrationBuilder.InsertData(
                table: "CrewMembers",
                columns: new[] { "Id", "AccountId", "Adress", "Age", "City", "DateOfBirth", "Email", "FirstName", "Gender", "LastName", "PhoneNumber", "Role", "Subject" },
                values: new object[] { 1, 1, "Rakefet 23", null, "Modi'in", null, "yehudanmanage@gmail.com", "Yehuda", "male", "Dan", null, "manager", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CrewMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
