namespace GastosApi.Models
{
    public class Gasto
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public int EmpleadoID { get; set; }
        public Empleado Empleado { get; set; }
        public int DepartamentoID { get; set; }
        public Departamento Departamento { get; set; }
    }
}
