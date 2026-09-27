using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
   public class ListarAvisoMercaderiaPreparadaLogica
    {
        private LIstarAvisoMercaderiaPreparada listar = new LIstarAvisoMercaderiaPreparada();
        public List<AvisoMercaderiaPreparada> Listar(DateTime fechadesde , DateTime fechahasta)
        {
            return listar.Listar(fechadesde,fechahasta);
        }
    }
}
