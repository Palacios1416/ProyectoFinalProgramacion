using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Entidades
{
    public class Empleado
    {
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public int NumeroINSS { get; set; }
        public string NumeroRUC { get; set; }
        public string NombreEmpleado { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public DateTime Antiguedad { get; set; } // Fecha de contratación
        public DateTime InicioContrato { get; set; } // Fecha de cierre del contrato
        public decimal SalarioBasico { get; set; }
        public string EstadoLaboral { get; set; } // Activo laboralmente (si / no)

        public Empleado() { }
    }
}