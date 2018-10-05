using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SEP
{
    public class BLLTitulo
    {
        public static string CrearXML()
        {

            DTO.AlumnoTitulo alumno = new DTO.AlumnoTitulo();
            DTO.Usuario userdb = new Usuario();


            alumno.UsuarioId = 1;
            alumno.Usuario = new Usuario
            {

            };

            alumno.AlumnoTituloId = 1;
            alumno.AlumnoId = "201102001";
            alumno.Alumno = new Alumno
            {
                AlumnoId = "201102001",
                Nombre = "JOSE MIGUEL",
                Paterno = "ALCALA",
                Materno = "GONZALES",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "AAGM900929HJCLNG02",
                    Email = "j053_pepe@hotmail.com"
                }
            };

            alumno.AlumnoOfertaEducativaId = 1;
            alumno.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
            {
                InstitucionId = "0",
                OfertaEducativaId = 1,
                FechaTermino = new DateTime(2018, 8, 30),
                FechaInicio = new DateTime(1900, 1, 1),
                RVOE = "303304",
                OfertaEducativa = new OfertaEducativa
                {
                    DescripcionSEP = "LICENCIATURA EN PEDAGOGÍA",
                    InstitucionOfertaEducativa = new List<InstitucionOfertaEducativa>
                    {
                        new InstitucionOfertaEducativa
                        {
                            ClaveOfertaEducativa="245301",
                            CampusId=1,
                            Campus= new Campus
                            {
                                Clave="090726",
                                Descripcion="Centro Universitario Jose Vasconcelos"
                            }
                        }
                    },
                   
                }
            };

            alumno.AutorizacionReconocimientoId = 1;
            alumno.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno.FechaExpedicion = DateTime.Now;
            alumno.FechaExamenProfesional = new DateTime(2018, 8, 29);
            alumno.ModalidadTitulacionId = 5;
            alumno.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno.ServicioSocial = true;
            alumno.FundamentoLegalId = 4;
            alumno.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno.EntidadFederativaIdExpedicion = 9;
            alumno.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno.AlumnoAntecedenteId = 1;
            alumno.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "PREPARATORIA EDUCACIÓN Y CULTURA SAN MIGUELENSE",
                TipoEstudioAntecedenteId = 4,
                TipoEstudioAntecedente = new TipoEstudioAntecedente
                {
                    TipoEstudioAntecedenteId = 4,
                    TipoEstudio = "BACHILLERATO"
                },
                EntidadFederativaId = 14,
                EntidadFederativa = new EntidadFederativa
                {
                    Clave = "14",
                    Descripcion = "JALISCO",
                    EntidadFederativaId = 14
                },
                FechaFin = new DateTime(2016, 2, 8)
            };

            alumno.UsuarioResponsable = new List<UsuarioResponsable>
            {
                new UsuarioResponsable
                {
                    UsuarioId=1,
                    Usuario= new Usuario
                    {
                        Nombre="BENITO GERARDO",
                        Paterno="GUILLEN",
                        Materno="NIEMEYER",
                        UsuarioId=1,
                        UsuarioDetalle= new UsuarioDetalle
                        {
                            CURP="GUNB530725HDFLMN02",
                            PassSat="brd53858753",
                            TituloCorto="DR.",
                        },
                        Cargo= new List<Cargo> {
                            new Cargo{
                                CargoId=1,
                                Descripcion="DIRECTOR"
                            }
                        }
                    }
                }
            };

            userdb = alumno.UsuarioResponsable.First().Usuario;

            BLL.Tools.SEP.CrearXMLTitulo(alumno, userdb);

            return Tools.SEP.CadenaSEP;
        }
    }
}
