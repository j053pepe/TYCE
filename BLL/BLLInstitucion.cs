using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLInstitucion
    {
        public static object Instituciones()
        {
            return new List<dynamic>
            {
                new
                {
                    InsitucionId = 1,
                    ClaveInsitucion = "090726",
                    Nombre = "Centro Universitario Jose Vasconcelos",
                    Campus= new List<dynamic>{
                        new
                        {
                            CampusId=1,
                            Nombre="Unico"
                        }
                    }
                }
            };
        }
    }
}
