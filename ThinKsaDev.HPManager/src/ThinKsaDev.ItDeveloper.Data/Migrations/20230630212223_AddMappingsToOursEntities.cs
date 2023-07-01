using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThinKsaDev.ItDeveloper.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMappingsToOursEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_PatientState_PatientStateId",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PatientState",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Patient",
                newName: "Nome");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "PatientState",
                type: "Varchar(30)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "Patient",
                type: "varchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Patient",
                type: "varchar(90)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patient",
                type: "varchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Patient",
                type: "varchar(11)",
                fixedLength: true,
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Patient",
                type: "varchar(80)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_PatientState_PatientStateId",
                table: "Patient",
                column: "PatientStateId",
                principalTable: "PatientState",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_PatientState_PatientStateId",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "PatientState",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Patient",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PatientState",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "Rg",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldFixedLength: true,
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_PatientState_PatientStateId",
                table: "Patient",
                column: "PatientStateId",
                principalTable: "PatientState",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
