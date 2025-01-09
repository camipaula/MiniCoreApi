namespace GastosApi.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int DepartamentoID { get; set; }
        public Departamento Departamento { get; set; }
        public List<Gasto> Gastos { get; set; }
    }
}
