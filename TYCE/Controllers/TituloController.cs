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
    }
}
