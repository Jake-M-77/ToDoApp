using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo_API.Migrations
{
    /// <inheritdoc />
    public partial class added_notes_var_to_ToDo_class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "ToDoList",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "ToDoList");
        }
    }
}
