using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace BLL.SEP
{
    public class BLLTitulo
    {
        public static List<string> CrearXML()
        {

            List<SpecialObject> Alumnos = BLLAlumnos.GetAlumnos();
            List<string> Cadenas = new List<string>();

            Alumnos.ForEach(a =>
            {
                BLL.Tools.SEP.CrearXMLTitulo(a.AlumnoTitulo, a.Usuario);
                Cadenas.Add(Tools.SEP.CadenaSEP);
            });

            return Cadenas;
        }

        public static List<ResultSEP> EnviarSEP()
        {
            List<SpecialObject> Alumnos = BLLAlumnos.GetAlumnos();
            List<ResultSEP> results = new List<ResultSEP>();
            List<string> Folios = new List<string>();

            //Alumnos.Where(a => a.AlumnoTitulo.AlumnoTituloId == 1).ToList().ForEach(a =>
            //   {
            //       var result = Tools.SEP.SendArchivos(new List<string> { a.AlumnoTitulo.AlumnoTituloId + "A" + a.AlumnoTitulo.AlumnoId + "C" + a.AlumnoTitulo.AlumnoOfertaEducativaId + ".xml" });
            //       if ((bool)result.GetType().GetProperty("Status").GetValue(result, null))
            //       {
            //           var resuljson = JObject.FromObject(result);
            //           results.Add(new ResultSEP
            //           {
            //               NumeroLote = resuljson["numeroLote"]?.ToString() ?? "",
            //               Mensaje = resuljson["mensaje"].ToString(),
            //               Folios = new List<string> { a.AlumnoTitulo.AlumnoTituloId + "A" + a.AlumnoTitulo.AlumnoId + "C" + a.AlumnoTitulo.AlumnoOfertaEducativaId + ".xml" }
            //           });
            //       }
            //   });

            //Alumnos.Where(a => a.AlumnoTitulo.AlumnoTituloId == 2).ToList().ForEach(a =>
            //{
            //    var result = Tools.SEP.SendArchivos(new List<string> { a.AlumnoTitulo.AlumnoTituloId + "A" + a.AlumnoTitulo.AlumnoId + "C" + a.AlumnoTitulo.AlumnoOfertaEducativaId + ".xml" });
            //    if ((bool)result.GetType().GetProperty("Status").GetValue(result, null))
            //    {
            //        var resuljson = JObject.FromObject(result);
            //        results.Add(new ResultSEP
            //        {
            //            NumeroLote = resuljson["numeroLote"]?.ToString() ?? "",
            //            Mensaje = resuljson["mensaje"].ToString(),
            //            Folios = new List<string> { a.AlumnoTitulo.AlumnoTituloId + "A" + a.AlumnoTitulo.AlumnoId + "C" + a.AlumnoTitulo.AlumnoOfertaEducativaId + ".xml" }
            //        });
            //    }
            //});

            Alumnos.Where(a => a.AlumnoTitulo.AlumnoTituloId == 3).ToList().ForEach(a =>
            {
                var result = Tools.SEP.SendArchivos(new List<string> { a.AlumnoTitulo.AlumnoTituloId + "A" + a.AlumnoTitulo.AlumnoId + "C" + a.AlumnoTitulo.AlumnoOfertaEducativaId + ".xml" });
                if ((bool)result.GetType().GetProperty("Status").GetValue(result, null))
                {
                    var resuljson = JObject.FromObject(result);
                    results.Add(new ResultSEP
                    {
                        NumeroLote = resuljson["numeroLote"]?.ToString() ?? "",
                        Mensaje = resuljson["mensaje"].ToString(),
                        Folios = new List<string> { a.AlumnoTitulo.AlumnoTituloId + "A" + a.AlumnoTitulo.AlumnoId + "C" + a.AlumnoTitulo.AlumnoOfertaEducativaId + ".xml" }
                    });
                }
            });

            //Alumnos.Where(a => a.AlumnoTitulo.AlumnoTituloId > 3).ToList().ForEach(a =>
            //{
            //    Folios.Add(a.AlumnoTitulo.AlumnoTituloId + "A" + a.AlumnoTitulo.AlumnoId + "C" + a.AlumnoTitulo.AlumnoOfertaEducativaId + ".xml");
            //});

            //var resultM = Tools.SEP.SendArchivos(Folios);
            //if ((bool)resultM.GetType().GetProperty("Status").GetValue(resultM, null))
            //{
            //    var resuljson = JObject.FromObject(resultM);
            //    results.Add(new ResultSEP
            //    {
            //        NumeroLote = resuljson["numeroLote"]?.ToString() ?? "",
            //        Mensaje = resuljson["mensaje"].ToString(),
            //        Folios = Folios
            //    });
            //}

            return results;
        }

        public static object ConsultarSEP()
        {
            var lstAlumnos = BLLAlumnos.ListaFoliosSEP().Where(a => a.NumeroLote == "40145" || a.NumeroLote == "40201").ToList();
            List<dynamic> lstLoteAlumno = new List<dynamic>();

            lstAlumnos.ForEach(alumno =>
            {
                lstLoteAlumno.Add(new
                {
                    alumno.NumeroLote,
                    alumno.Alumnos
                });
            });

            List<dynamic> lstResult = Tools.SEP.RevisarLotes(lstLoteAlumno);

            return lstResult;
        }
    }

    public class ResultSEP
    {
        public string NumeroLote { get; set; }
        public string Mensaje { get; set; }
        public List<string> Folios { get; set; }
        public List<AlumnoSEP> Alumnos { get; set; }
    }

    public class AlumnoSEP
    {
        public int AlumnoTituloId { get; set; }
        public string AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
    }
}
