public class Pedidos{
    static private int PedidosRealizados = 0;

    private int numeroDePedido;
    private string? descripcionPedido;
    private Cliente? cliente;
    private string? estado;

    public int NumeroDePedido { get => numeroDePedido; set => numeroDePedido = value; }
    public string? DescripcionPedido { get => descripcionPedido; set => descripcionPedido = value; }
    public Cliente? Cliente { get => cliente; set => cliente = value; }
    public string? Estado { get => estado; set => estado = value; }

    public Pedidos(string ID, string Nombre, string Direccion, string Telefono, string ReferenciaDeDireccion, string DescripcionPedido, string Estado){
        this.NumeroDePedido = ++PedidosRealizados;
        this.Cliente = new Cliente(ID, Nombre, Direccion, Telefono, ReferenciaDeDireccion);
        this.DescripcionPedido = DescripcionPedido;
    }
}