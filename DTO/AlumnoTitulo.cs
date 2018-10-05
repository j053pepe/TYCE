using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AlumnoTitulo
    {
        public int AlumnoTituloId { get; set; }
        public string AlumnoId { get; set; }
        public int AlumnoOfertaEducativaId { get; set; }
        public int AutorizacionReconocimientoId { get; set; }
        public System.DateTime FechaExpedicion { get; set; }
        public int ModalidadTitulacionId { get; set; }
        public System.DateTime FechaExamenProfesional { get; set; }
        public System.DateTime FechaExencionExamenProfecional { get; set; }
        public bool ServicioSocial { get; set; }
        public int FundamentoLegalId { get; set; }
        public int EntidadFederativaIdExpedicion { get; set; }
        public int AlumnoAntecedenteId { get; set; }
        public int Libro { get; set; }
        public int Foja { get; set; }
        public int UsuarioId { get; set; }
        public int MovimientoId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual EntidadFederativa EntidadFederativa { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual AlumnoAntecedente1 AlumnoAntecedente1 { get; set; }
        public virtual AlumnoOfertaEducativa AlumnoOfertaEducativa { get; set; }
        public virtual AutorizacionReconocimiento AutorizacionReconocimiento { get; set; }
        public virtual FundamentoLegal FundamentoLegal { get; set; }
        public virtual ModalidadTitulacion ModalidadTitulacion { get; set; }
        public virtual MovimientoSEP MovimientoSEP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoTituloAccion> AlumnoTituloAccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioResponsable> UsuarioResponsable { get; set; }
    }

    public class AlumnoTituloAccion
    {
        public int AlumnoTituloAccionId { get; set; }
        public int AccionSEPId { get; set; }
        public int AlumnoTituloId { get; set; }
    }

    public class MovimientoSEP
    {
        public int MovimientoId { get; set; }
        public string Descripcion { get; set; }
    }

    public class ModalidadTitulacion
    {
        public int ModalidadTitulacionId { get; set; }
        public string ModalidadTitulacion1 { get; set; }
        public string TipoModalidad { get; set; }
    }

    public class FundamentoLegal
    {
        public int FundamentoLegalId { get; set; }
        public string Descripcion { get; set; }
    }

    public class AutorizacionReconocimiento
    {
        public int AutorizacionReconocimientoId { get; set; }
        public string Descripcion { get; set; }
    }

    public class AlumnoOfertaEducativa
    {
        public int AlumnoOfertaEducativaId { get; set; }
        public string InstitucionId { get; set; }
        public int OfertaEducativaId { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaTermino { get; set; }
        public string RVOE { get; set; }

        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Institucion Institucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoTitulo> AlumnoTitulo { get; set; }
    }

    public class Institucion
    {
        public string InstitucionId { get; set; }
        public string Nombre { get; set; }
        public string TipoSostenimiento { get; set; }
        public string TipoEducativo { get; set; }
    }

    public class OfertaEducativa
    {
        public int OfertaEducativaId { get; set; }
        public int OfertaEducativaTipoId { get; set; }
        public string Descripcion { get; set; }
        public string Rvoe { get; set; }
        public Nullable<System.DateTime> FechaRvoe { get; set; }
        public int SucursalId { get; set; }
        public bool RequiereDeportivo { get; set; }
        public string ClaveContable { get; set; }
        public int EstatusId { get; set; }
        public string DescripcionSEP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstitucionOfertaEducativa> InstitucionOfertaEducativa { get; set; }
    }

    public class InstitucionOfertaEducativa
    {
        public int InstitucionOfertaEducativaId { get; set; }
        public string InstitucionId { get; set; }
        public int CampusId { get; set; }
        public int OfertaEducativaId { get; set; }
        public string ClaveOfertaEducativa { get; set; }

        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Campus Campus { get; set; }
        public virtual Institucion Institucion { get; set; }
    }

    public class Campus
    {
        public int CampusId { get; set; }
        public string Descripcion { get; set; }
        public string Clave { get; set; }
    }

    public class AlumnoAntecedente1
    {
        public int AlumnoAntecedenteId { get; set; }
        public string Nombre { get; set; }
        public int TipoEstudioAntecedenteId { get; set; }
        public int EntidadFederativaId { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }

        public virtual EntidadFederativa EntidadFederativa { get; set; }
        public virtual TipoEstudioAntecedente TipoEstudioAntecedente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoTitulo> AlumnoTitulo { get; set; }
    }

    public class TipoEstudioAntecedente
    {
        public int TipoEstudioAntecedenteId { get; set; }
        public string TipoEstudio { get; set; }
        public string Descripcion { get; set; }
    }

    public class EntidadFederativa
    {
        public int EntidadFederativaId { get; set; }
        public string Clave { get; set; }
        public bool SeMuestra { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
    }
}
