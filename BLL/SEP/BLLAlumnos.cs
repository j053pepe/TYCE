using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.SEP
{
    public class BLLAlumnos
    {
        public static List<SpecialObject> GetAlumnos()
        {
            DTO.AlumnoTitulo alumno = new DTO.AlumnoTitulo();
            DTO.Usuario userdb = new Usuario();
            AlumnoTitulo alumno1 = new AlumnoTitulo();
            Usuario userdb1 = new Usuario();
            AlumnoTitulo alumno2 = new AlumnoTitulo();
            Usuario userdb2 = new Usuario();
            AlumnoTitulo alumno3 = new AlumnoTitulo();
            Usuario userdb3 = new Usuario();
            AlumnoTitulo alumno4 = new AlumnoTitulo();
            Usuario userdb4 = new Usuario();
            AlumnoTitulo alumno5 = new AlumnoTitulo();
            Usuario userdb5 = new Usuario();
            AlumnoTitulo alumno6 = new AlumnoTitulo();
            Usuario userdb6 = new Usuario();
            AlumnoTitulo alumno7 = new AlumnoTitulo();
            Usuario userdb7 = new Usuario();
            AlumnoTitulo alumno8 = new AlumnoTitulo();
            Usuario userdb8 = new Usuario();
            List<SpecialObject> lstAlumnos = new List<SpecialObject>();

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

            alumno1.AutorizacionReconocimientoId = 1;
            alumno1.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno2.AutorizacionReconocimientoId = 1;
            alumno2.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno3.AutorizacionReconocimientoId = 1;
            alumno3.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno4.AutorizacionReconocimientoId = 1;
            alumno4.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno5.AutorizacionReconocimientoId = 1;
            alumno5.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno6.AutorizacionReconocimientoId = 1;
            alumno6.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno7.AutorizacionReconocimientoId = 1;
            alumno7.AutorizacionReconocimiento = new AutorizacionReconocimiento
            {
                AutorizacionReconocimientoId = 1,
                Descripcion = "RVOE FEDERAL"
            };

            alumno8.AutorizacionReconocimientoId = 1;
            alumno8.AutorizacionReconocimiento = new AutorizacionReconocimiento
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

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno,
                Usuario = userdb
            });

            ///
            ///
            ///

            alumno1.UsuarioId = 1;
            alumno1.Usuario = new Usuario
            {

            };
            alumno1.AlumnoOfertaEducativaId = 1;
            alumno1.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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

            alumno1.ModalidadTitulacionId = 5;
            alumno1.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno1.ServicioSocial = true;
            alumno1.FundamentoLegalId = 4;
            alumno1.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno1.EntidadFederativaIdExpedicion = 9;
            alumno1.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno1.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb1 = alumno1.UsuarioResponsable.First().Usuario;

            alumno1.AlumnoTituloId = 2;
            alumno1.AlumnoId = "201202002";
            alumno1.Alumno = new Alumno
            {
                AlumnoId = "201202002",
                Nombre = "VIRIDIANA",
                Paterno = "GONZALEZ",
                Materno = "HERNANDEZ",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "GOHV920206MJCNRR05",
                    Email = "j053_pepe@hotmail.com"
                }
            };

            alumno1.FechaExpedicion = DateTime.Now;
            alumno1.FechaExamenProfesional = new DateTime(2018, 8, 28);

            alumno1.AlumnoAntecedenteId = 1;
            alumno1.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "UNIVERSIDAD DE GUADALAJARA",
                TipoEstudioAntecedenteId = 2,
                TipoEstudioAntecedente = new TipoEstudioAntecedente
                {
                    TipoEstudioAntecedenteId = 2,
                    TipoEstudio = "LICENCIATURA"
                },
                EntidadFederativaId = 14,
                EntidadFederativa = new EntidadFederativa
                {
                    Clave = "14",
                    Descripcion = "JALISCO",
                    EntidadFederativaId = 14
                },
                FechaFin = new DateTime(2010, 7, 20)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno1,
                Usuario = userdb1
            });

            ///
            ///
            ///


            alumno2.UsuarioId = 1;
            alumno2.Usuario = new Usuario
            {

            };

            alumno2.AlumnoOfertaEducativaId = 1;
            alumno2.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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
            alumno2.ModalidadTitulacionId = 5;
            alumno2.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno2.ServicioSocial = true;
            alumno2.FundamentoLegalId = 4;
            alumno2.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno2.EntidadFederativaIdExpedicion = 9;
            alumno2.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno2.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb2 = alumno2.UsuarioResponsable.First().Usuario;
            alumno2.AlumnoTituloId = 3;
            alumno2.AlumnoId = "201202004";
            alumno2.Alumno = new Alumno
            {
                AlumnoId = "201202004",
                Nombre = "ANA ELENA",
                Paterno = "MUÑOZ",
                Materno = "RAMIREZ",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "MURA901222MJCXMN03",
                    Email = "j053_pepe@hotmail.com"
                }
            };


            alumno2.FechaExpedicion = DateTime.Now;
            alumno2.FechaExamenProfesional = new DateTime(2018, 8, 18);

            alumno2.AlumnoAntecedenteId = 1;
            alumno2.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "UNIVERSIDAD DE GUADALAJARA",
                TipoEstudioAntecedenteId = 2,
                TipoEstudioAntecedente = new TipoEstudioAntecedente
                {
                    TipoEstudioAntecedenteId = 2,
                    TipoEstudio = "LICENCIATURA"
                },
                EntidadFederativaId = 14,
                EntidadFederativa = new EntidadFederativa
                {
                    Clave = "14",
                    Descripcion = "JALISCO",
                    EntidadFederativaId = 14
                },
                FechaFin = new DateTime(2010, 7, 20)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno2,
                Usuario = userdb2
            });


            ///
            ///
            ///

            alumno3.UsuarioId = 1;
            alumno3.Usuario = new Usuario
            {

            };

            alumno3.AlumnoOfertaEducativaId = 1;
            alumno3.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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
            alumno3.ModalidadTitulacionId = 5;
            alumno3.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno3.ServicioSocial = true;
            alumno3.FundamentoLegalId = 4;
            alumno3.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno3.EntidadFederativaIdExpedicion = 9;
            alumno3.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno3.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb3 = alumno3.UsuarioResponsable.First().Usuario;
            alumno3.AlumnoTituloId = 4;
            alumno3.AlumnoId = "201002004";
            alumno3.Alumno = new Alumno
            {
                AlumnoId = "201002004",
                Nombre = "HILDA",
                Paterno = "VELEZ",
                Materno = "TOLEDO",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "VETH861023MDFLLL03",
                    Email = "j053_pepe@hotmail.com"
                }
            };


            alumno3.FechaExpedicion = DateTime.Now;
            alumno3.FechaExamenProfesional = new DateTime(2018, 8, 8);

            alumno3.AlumnoAntecedenteId = 1;
            alumno3.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "UNIVERSIDAD ATUTÓNOMA DE AGUASCALIENTES",
                TipoEstudioAntecedenteId = 2,
                TipoEstudioAntecedente = new TipoEstudioAntecedente
                {
                    TipoEstudioAntecedenteId = 2,
                    TipoEstudio = "LICENCIATURA"
                },
                EntidadFederativaId = 1,
                EntidadFederativa = new EntidadFederativa
                {
                    Clave = "01",
                    Descripcion = "AGUASCALIENTES",
                    EntidadFederativaId = 1
                },
                FechaFin = new DateTime(2015, 3, 15)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno3,
                Usuario = userdb3
            });


            ///
            ///
            ///

            alumno4.UsuarioId = 1;
            alumno4.Usuario = new Usuario
            {

            };

            alumno4.AlumnoOfertaEducativaId = 1;
            alumno4.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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
            alumno4.ModalidadTitulacionId = 5;
            alumno4.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno4.ServicioSocial = true;
            alumno4.FundamentoLegalId = 4;
            alumno4.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno4.EntidadFederativaIdExpedicion = 9;
            alumno4.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno4.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb4 = alumno4.UsuarioResponsable.First().Usuario;
            alumno4.AlumnoTituloId = 5;
            alumno4.AlumnoId = "200902001";
            alumno4.Alumno = new Alumno
            {
                AlumnoId = "200902001",
                Nombre = "ALEJANDRA",
                Paterno = "GONZALEZ",
                Materno = "OROZCO",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "GOOA900811MJCNRL03",
                    Email = "j053_pepe@hotmail.com"
                }
            };


            alumno4.FechaExpedicion = DateTime.Now;
            alumno4.FechaExamenProfesional = new DateTime(2018, 8, 5);

            alumno4.AlumnoAntecedenteId = 1;
            alumno4.AlumnoAntecedente1 = new AlumnoAntecedente1
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
                FechaFin = new DateTime(2008, 6, 27)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno4,
                Usuario = userdb4
            });

            ///
            ///
            ///
            alumno5.UsuarioId = 1;
            alumno5.Usuario = new Usuario
            {

            };

            alumno5.AlumnoOfertaEducativaId = 1;
            alumno5.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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
            alumno5.ModalidadTitulacionId = 5;
            alumno5.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno5.ServicioSocial = true;
            alumno5.FundamentoLegalId = 4;
            alumno5.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno5.EntidadFederativaIdExpedicion = 9;
            alumno5.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno5.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb5 = alumno5.UsuarioResponsable.First().Usuario;
            alumno5.AlumnoTituloId = 6;
            alumno5.AlumnoId = "201002005";
            alumno5.Alumno = new Alumno
            {
                AlumnoId = "201002005",
                Nombre = "VIRIDIANA NATALI",
                Paterno = "ZAVALA",
                Materno = "PLASCENCIA",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "ZAPV901004MJCVLR03",
                    Email = "j053_pepe@hotmail.com"
                }
            };


            alumno5.FechaExpedicion = DateTime.Now;
            alumno5.FechaExamenProfesional = new DateTime(2018, 8, 15);

            alumno5.AlumnoAntecedenteId = 1;
            alumno5.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "UNIVERSIDAD DE GUADALAJARA",
                TipoEstudioAntecedenteId = 2,
                TipoEstudioAntecedente = new TipoEstudioAntecedente
                {
                    TipoEstudioAntecedenteId = 2,
                    TipoEstudio = "LICENCIATURA"
                },
                EntidadFederativaId = 14,
                EntidadFederativa = new EntidadFederativa
                {
                    Clave = "14",
                    Descripcion = "JALISCO",
                    EntidadFederativaId = 14
                },
                FechaFin = new DateTime(2008, 7, 21)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno5,
                Usuario = userdb5
            });

            ///
            ///
            ///

            alumno6.UsuarioId = 1;
            alumno6.Usuario = new Usuario
            {

            };

            alumno6.AlumnoOfertaEducativaId = 1;
            alumno6.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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
            alumno6.ModalidadTitulacionId = 5;
            alumno6.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno6.ServicioSocial = true;
            alumno6.FundamentoLegalId = 4;
            alumno6.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno6.EntidadFederativaIdExpedicion = 9;
            alumno6.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno6.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb6 = alumno6.UsuarioResponsable.First().Usuario;
            alumno6.AlumnoTituloId = 7;
            alumno6.AlumnoId = "201002003";
            alumno6.Alumno = new Alumno
            {
                AlumnoId = "201002003",
                Nombre = "YOLANDA ESTEFANIA",
                Paterno = "VALLEJO",
                Materno = "GARCIA",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "VAGY910809MJCLRL04",
                    Email = "j053_pepe@hotmail.com"
                }
            };


            alumno6.FechaExpedicion = DateTime.Now;
            alumno6.FechaExamenProfesional = new DateTime(2018, 8, 25);

            alumno6.AlumnoAntecedenteId = 1;
            alumno6.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "UNIVERSIDAD DE GUADALAJARA",
                TipoEstudioAntecedenteId = 2,
                TipoEstudioAntecedente = new TipoEstudioAntecedente
                {
                    TipoEstudioAntecedenteId = 2,
                    TipoEstudio = "LICENCIATURA"
                },
                EntidadFederativaId = 14,
                EntidadFederativa = new EntidadFederativa
                {
                    Clave = "14",
                    Descripcion = "JALISCO",
                    EntidadFederativaId = 14
                },
                FechaFin = new DateTime(2016, 3, 3)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno6,
                Usuario = userdb6
            });

            ///
            ///
            ///

            alumno7.UsuarioId = 1;
            alumno7.Usuario = new Usuario
            {

            };

            alumno7.AlumnoOfertaEducativaId = 1;
            alumno7.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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
            alumno7.ModalidadTitulacionId = 5;
            alumno7.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno7.ServicioSocial = true;
            alumno7.FundamentoLegalId = 4;
            alumno7.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno7.EntidadFederativaIdExpedicion = 9;
            alumno7.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno7.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb7 = alumno7.UsuarioResponsable.First().Usuario;
            alumno7.AlumnoTituloId = 8;
            alumno7.AlumnoId = "201102003";
            alumno7.Alumno = new Alumno
            {
                AlumnoId = "201102003",
                Nombre = "ALEJANDRA",
                Paterno = "RUIZ",
                Materno = "VALDIVIA",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "RUVA900623MMCZLL09",
                    Email = "j053_pepe@hotmail.com"
                }
            };


            alumno7.FechaExpedicion = DateTime.Now;
            alumno7.FechaExamenProfesional = new DateTime(2018, 8, 28);

            alumno7.AlumnoAntecedenteId = 1;
            alumno7.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "UNIVERSIDAD DE GUADALAJARA",
                TipoEstudioAntecedenteId = 2,
                TipoEstudioAntecedente = new TipoEstudioAntecedente
                {
                    TipoEstudioAntecedenteId = 2,
                    TipoEstudio = "LICENCIATURA"
                },
                EntidadFederativaId = 14,
                EntidadFederativa = new EntidadFederativa
                {
                    Clave = "14",
                    Descripcion = "JALISCO",
                    EntidadFederativaId = 14
                },
                FechaFin = new DateTime(2008, 7, 21)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno7,
                Usuario = userdb7
            });

            ///
            ///
            ///

            alumno8.UsuarioId = 1;
            alumno8.Usuario = new Usuario
            {

            };
            alumno8.AlumnoOfertaEducativaId = 1;
            alumno8.AlumnoOfertaEducativa = new AlumnoOfertaEducativa
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

            alumno8.ModalidadTitulacionId = 5;
            alumno8.ModalidadTitulacion = new ModalidadTitulacion
            {
                ModalidadTitulacionId = 5,
                ModalidadTitulacion1 = "POR CENEVAL"
            };

            alumno8.ServicioSocial = true;
            alumno8.FundamentoLegalId = 4;
            alumno8.FundamentoLegal = new FundamentoLegal
            {
                FundamentoLegalId = 4,
                Descripcion = "ART. 10 REGLAMENTO PARA LA PRESTACIÓN DEL SERVICIO SOCIAL DE LOS ESTUDIANTES DE LAS INSTITUCIONES DE EDUCACIÓN SUPERIOR EN LA REPÚBLICA MEXICANA"
            };

            alumno8.EntidadFederativaIdExpedicion = 9;
            alumno8.EntidadFederativa = new EntidadFederativa
            {
                EntidadFederativaId = 9,
                Clave = "09",
                Descripcion = "CIUDAD DE MÉXICO"
            };

            alumno8.UsuarioResponsable = new List<UsuarioResponsable>
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

            userdb8 = alumno8.UsuarioResponsable.First().Usuario;
            alumno8.AlumnoTituloId = 9;
            alumno8.AlumnoId = "201302001";
            alumno8.Alumno = new Alumno
            {
                AlumnoId = "201302001",
                Nombre = "ANAYANCI",
                Paterno = "LOZA",
                Materno = "ROMO",
                AlumnoDetalle = new AlumnoDetalle
                {
                    CURP = "LORA901010MJCZMN03",
                    Email = "j053_pepe@hotmail.com"
                }
            };


            alumno8.FechaExpedicion = DateTime.Now;
            alumno8.FechaExamenProfesional = new DateTime(2018, 8, 22);

            alumno8.AlumnoAntecedenteId = 1;
            alumno8.AlumnoAntecedente1 = new AlumnoAntecedente1
            {
                AlumnoAntecedenteId = 1,
                Nombre = "PREPARATORIA EDUCACIÓN Y CLTURA SAN MIGUELENSE",
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
                FechaFin = new DateTime(2009, 7, 14)
            };

            lstAlumnos.Add(new SpecialObject
            {
                AlumnoTitulo = alumno8,
                Usuario = userdb8
            });

            return lstAlumnos;
        }

        public static List<ResultSEP> ListaFoliosSEP()
        {
            return
            new List<ResultSEP>
            {
                new ResultSEP
                {
                    NumeroLote= "40143",
                    Mensaje= "",
                    Folios=new List<string> {"1A201102001C1.xml" },
                    Alumnos =new List<AlumnoSEP> {
                        new AlumnoSEP{
                            AlumnoId= "201102001" ,
                            AlumnoTituloId=1,
                            OfertaEducativaId=1
                    }
                }
                },
                new ResultSEP
                {
                    NumeroLote= "40144",
                    Mensaje= "",
                    Folios= new List<string>{ "2A201202002C1.xml" },
                    Alumnos =new List<AlumnoSEP> {
                        new AlumnoSEP{
                            AlumnoId= "201202002",
                            AlumnoTituloId =2,
                            OfertaEducativaId=1
                    }
                    }
                },
                new ResultSEP
                {
                    NumeroLote= "40145",
                    Mensaje= "",
                    Folios=new List<string> { "3A201202004C1.xml" },
                    Alumnos =new List<AlumnoSEP> {
                        new AlumnoSEP{
                            AlumnoId= "201202004",
                            AlumnoTituloId=3,
                            OfertaEducativaId=1
                        }
                }
                },
                new ResultSEP
                {
                    NumeroLote= "40201",
                    Mensaje= "",
                    Folios=new List<string> { "3A201202004C1.xml" },
                    Alumnos =new List<AlumnoSEP> {
                        new AlumnoSEP{
                            AlumnoId= "201202004",
                            AlumnoTituloId=3,
                            OfertaEducativaId=1
                        }
                }
                },
                new ResultSEP
                {
                    NumeroLote= "40112",
                    Mensaje= "",
                    Folios=new List<string> {
                        "4A201002004C1.xml",
                        "5A200902001C1.xml",
                        "6A201002005C1.xml",
                        "7A201002003C1.xml",
                        "8A201102003C1.xml",
                        "9A201302001C1.xml" },
                     Alumnos =new List<AlumnoSEP> {
                        new AlumnoSEP{
                            AlumnoId= "201002004",
                            AlumnoTituloId=4,
                            OfertaEducativaId=1
                        },
                        new AlumnoSEP{
                            AlumnoId="200902001",
                            AlumnoTituloId=5,
                            OfertaEducativaId=1
                        },
                        new AlumnoSEP{
                            AlumnoId="201002005",
                            AlumnoTituloId=6,
                            OfertaEducativaId=1
                        } ,
                        new AlumnoSEP{
                            AlumnoId="201002003",
                            AlumnoTituloId=7,
                            OfertaEducativaId=1
                        } ,
                        new AlumnoSEP {
                            AlumnoId = "201102003",
                            AlumnoTituloId = 8,
                            OfertaEducativaId = 1
                        },
                        new AlumnoSEP{
                            AlumnoId="201302001",
                            AlumnoTituloId=9,
                            OfertaEducativaId=1
                        },
                    }
                     }
            };
        }
    }

    public class SpecialObject
    {
        public AlumnoTitulo AlumnoTitulo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
