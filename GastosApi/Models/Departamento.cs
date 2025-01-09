namespace GastosApi.Models
{
    public class Departamento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
