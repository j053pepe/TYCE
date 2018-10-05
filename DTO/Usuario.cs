using System.Collections.Generic;

namespace DTO
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Password { get; set; }
        public int UsuarioTipoId { get; set; }
        public int EstatusId { get; set; }

        public virtual UsuarioDetalle UsuarioDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> Cargo { get; set; }
    }

    public class Cargo
    {
        public int CargoId { get; set; }
        public string Descripcion { get; set; }
    }

    public class UsuarioDetalle
    {
        public int UsuarioId { get; set; }
        public string TituloCorto { get; set; }
        public int GeneroId { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string Email { get; set; }
        public string CURP { get; set; }
        public string PassSat { get; set; }
        public string Observaciones { get; set; }
    }
}