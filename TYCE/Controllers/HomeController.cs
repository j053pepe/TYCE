using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TYCE.Controllers
{
    [RoutePrefix("Api/Home")]
    public class HomeController : ApiController
    {
        [Route("Menu")]
        [HttpGet]
        public IHttpActionResult Menu()
        {
            var Menu = new List<dynamic>
            {
                new
                {
                    MenuId=1,
                    Descripcion="Titulo",
                    Icono="",
                    SubMenu = new List<dynamic>
                    {
                        new
                        {
                            SubMenuId=1,
                            Descripcion="Solicitud",
                            Direccion="Views/Titulo/Solicitud.html"
                        },
                        new
                        {
                             SubMenuId=2,
                            Descripcion="Firmar",
                            Direccion="Views/Titulo/Firmar.html"
                        },
                        new
                        {
                             SubMenuId=3,
                            Descripcion="Enviar a SEP",
                            Direccion="Views/Titulo/Enviar.html"
                        },
                        new
                        {
                             SubMenuId=4,
                            Descripcion="Consultar",
                            Direccion="Views/Titulo/Consultar.html"
                        }
                    }
                },
                new
                {
                    MenuId=2,
                    Descripcion="Certificado",
                    Icono="",
                    SubMenu = new List<dynamic>
                    {
                        new
                        {
                            SubMenuId=5,
                            Descripcion="Solicitud",
                            Direccion="Views/Titulo/Solicitud.html"
                        },
                        new
                        {
                             SubMenuId=6,
                            Descripcion="Firmar",
                            Direccion="Views/Titulo/Firmar.html"
                        },
                        new
                        {
                             SubMenuId=7,
                            Descripcion="Consultar",
                            Direccion="Views/Titulo/Consultar.html"
                        }
                    }
                }
            };

            return Ok(Menu);
        }
    }
}
