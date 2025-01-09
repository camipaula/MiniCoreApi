using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GastosApi.Migrations
{
    /// <inheritdoc />
    public partial class MigrationDos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentoID",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Departamentos_DepartamentoID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Empleados_EmpleadoID",
                table: "Gastos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "Empleado");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_DepartamentoID",
                table: "Empleado",
                newName: "IX_Empleado_DepartamentoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Departamento_DepartamentoID",
                table: "Empleado",
                column: "DepartamentoID",
                principalTable: "Departamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Departamento_DepartamentoID",
                table: "Gastos",
                column: "DepartamentoID",
                principalTable: "Departamento",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Empleado_EmpleadoID",
                table: "Gastos",
                column: "EmpleadoID",
                principalTable: "Empleado",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Departamento_DepartamentoID",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Departamento_DepartamentoID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Empleado_EmpleadoID",
                table: "Gastos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "Empleados");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_DepartamentoID",
                table: "Empleados",
                newName: "IX_Empleados_DepartamentoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentoID",
                table: "Empleados",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Departamentos_DepartamentoID",
                table: "Gastos",
                column: "DepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Empleados_EmpleadoID",
                table: "Gastos",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
