namespace Preparcial
{
    public class Pedido
    {
        
        public int IdPedido { get; set; }
        public int IdInventario { get; set; }
        public int IdUsuario { get; set; }
        public int cantidad { get; set; }

        public Pedido() { }

        public Pedido(int idPedido,int idInventario, int idUsuario, int cantidad)
        {
            this.IdInventario = idInventario;
            this.IdPedido = idPedido;
            this.IdUsuario = idUsuario;
            this.cantidad = cantidad;
        }
    }
}