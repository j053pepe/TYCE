using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYCE.Controllers
{
    [RoutePrefix("Api/Titulo")]
    public class TituloController : ApiController
    {
        [Route("Nuevo")]
        [HttpPost]
        public IHttpActionResult Nuevo()
        {
            try
            {
                return Ok(BLL.SEP.BLLTitulo.CrearXML());
            }
            catch
            {
                return BadRequest("Fallo al momento de generar el XML");
            }
        }

        [Route("Enviar")]
        [HttpPost]
        public IHttpActionResult Enviar()
        {
            try
            {
                return Ok(BLL.SEP.BLLTitulo.EnviarSEP());
            }
            catch
            {
                return BadRequest("Fallo al momento de enviar el XML");
            }
        }

        [Route("Consultar")]
        [HttpPost]
        public IHttpActionResult Query()
        {
            try
            {
                return Ok(BLL.SEP.BLLTitulo.ConsultarSEP());
            }
            catch
            {
                return BadRequest("Fallo al momento de conultar el resultado");
            }
        }
    }
}
