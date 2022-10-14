public class Persona{
    private string? id;
    private string? nombre;
    private string? direccion;
    private string? telefono;

    public string? Id { get => id; set => id = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Direccion { get => direccion; set => direccion = value; }
    public string? Telefono { get => telefono; set => telefono = value; }

    public Persona(string ID, string Nombre, string Direccion, string Telefono){
        this.Id = ID;
        this.Nombre = Nombre;
        this.Direccion = Direccion;
        this.Telefono = Telefono;
    }
}