public class Cliente : Persona{
    private string? referenciaDeDireccion;

    public string? ReferenciaDeDireccion { get => referenciaDeDireccion; set => referenciaDeDireccion = value; }

    public Cliente(string ID, string Nombre, string Direccion, string Telefono, string ReferenciaDeDireccion) : base(ID, Nombre, Direccion, Telefono){
        this.ReferenciaDeDireccion = ReferenciaDeDireccion;
    }
}