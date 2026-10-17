using System;
using DATOS;
using ENTIDADES;

namespace LOGICA
{
    public class ModificarEstadoNotaPedidoLogica
    {
        private ModificarEstadoNotaPedido modificar = new ModificarEstadoNotaPedido();
        private BuscarNotaPedido buscar = new BuscarNotaPedido();

        public void Modificar(int IdNotasPedido, string EstadoNuevo)
        {
            NotaPedido notaActual = buscar.Buscar(IdNotasPedido);
            if (notaActual == null)
            {
                throw new Exception("No se encontró la nota de pedido.");
            }

            string[] estados = { "pendiente", "preparado", "entregado", "facturado" };
            int posicionActual = Array.IndexOf(estados, notaActual.Estado.Trim().ToLower());
            int posicionNueva = Array.IndexOf(estados, EstadoNuevo.Trim().ToLower());

            if (posicionActual == -1 || posicionNueva == -1)
            {
                throw new Exception("Estado no reconocido.");
            }

            if (posicionNueva != posicionActual + 1)
            {
                throw new Exception("El estado solo puede avanzar un paso: Pendiente, Preparado, Entregado, Facturado.");
            }

            modificar.Modificar(IdNotasPedido, EstadoNuevo);
        }
    }
}
