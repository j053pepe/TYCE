using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYCE.Controllers
{
    [RoutePrefix("Api/Institucion")]
    public class InstitucionController : ApiController
    {
        [Route("Todas")]
        [HttpGet]
        public IHttpActionResult GetInstituciones()
        {
            try
            {
                return Ok(BLL.BLLInstitucion.Instituciones());
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
