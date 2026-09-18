using DATOS;
using System;
using ENTIDADES;
namespace LOGICA
{
    public class ModificarEstadoNotaPedidoLogica
    {
        private ModificarEstadoNotaPedido modificar = new ModificarEstadoNotaPedido();
        private BuscarNotaPedido buscar = new BuscarNotaPedido();
        public void Modificar(int IdNotasPedido,string EstadoNuevo)
        {
            NotaPedido NotaActual = buscar.Buscar(IdNotasPedido);
            string[] estado = {"pendiente","preparado","entregado","facturado"};
            int posicionactual = Array.IndexOf(estado, NotaActual.Estado);
            int posicionnueva = Array.IndexOf(estado, EstadoNuevo);
            if(posicionactual +1 != posicionnueva)
            {
                throw new Exception("error se esta saltando pasos");
            }
            modificar.Modificar(IdNotasPedido,EstadoNuevo);
        }
    }
}
