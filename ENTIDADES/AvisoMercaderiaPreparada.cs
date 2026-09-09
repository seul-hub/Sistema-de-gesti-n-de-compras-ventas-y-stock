using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class AvisoMercaderiaPreparada
    {
        public int IdAvisosMercaderiaPreparada { get; set; }
        public int IdNotaPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaEmision { get; set; }
        public AvisoMercaderiaPreparada() { }
        public AvisoMercaderiaPreparada(int IdAvisosMercaderiaPreparada, int IdNotaPedido, int IdUsuario, DateTime FechaEmision)
        {
            this.IdAvisosMercaderiaPreparada = IdAvisosMercaderiaPreparada;
            this.IdNotaPedido = IdNotaPedido;
            this.IdUsuario = IdUsuario;
            this.FechaEmision = FechaEmision;
        }
    }
}
