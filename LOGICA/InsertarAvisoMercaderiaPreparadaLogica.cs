using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class InsertarAvisoMercaderiaPreparadaLogica
    {
        private InsertarAvisoMercaderiaPreparada insertar = new InsertarAvisoMercaderiaPreparada();
        public void Insertar(AvisoMercaderiaPreparada avisoMercaderiaPreparada)
        {
            insertar.Insertar(avisoMercaderiaPreparada);
        }
    }
}
