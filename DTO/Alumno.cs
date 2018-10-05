using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Alumno
    {
        public string AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public string MatriculaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int EstatusId { get; set; }

        public virtual AlumnoDetalle AlumnoDetalle { get; set; }
    }

    public class AlumnoDetalle
    {
        public string AlumnoId { get; set; }
        public int GeneroId { get; set; }
        public int EstadoCivilId { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string CURP { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public Nullable<int> EntidadNacimientoId { get; set; }
        public int MunicipioId { get; set; }
        public string CP { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoOficina { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool TieneExamenMedico { get; set; }
        public string Observaciones { get; set; }
    }
}
