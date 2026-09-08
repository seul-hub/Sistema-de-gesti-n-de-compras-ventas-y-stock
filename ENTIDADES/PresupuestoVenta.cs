namespace ENTIDADES
{
    public class PresupuestoVenta
    {
        public int IdPresupuestoVenta { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }

        public PresupuestoVenta() { }

        public PresupuestoVenta(int IdPresupuestoVenta,DateTime FechaEmision,string Estado,int IdCliente,int IdUsuario )
        {
            this.IdPresupuestoVenta = IdPresupuestoVenta;
            this.FechaEmision = FechaEmision;
            this.Estado = Estado;
            this.IdCliente = IdCliente;
            this.IdUsuario = IdUsuario;
        }
    }
}
