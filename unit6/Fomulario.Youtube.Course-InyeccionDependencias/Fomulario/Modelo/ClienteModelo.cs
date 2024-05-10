namespace Fomulario.Modelo
{
    public class ClienteModelo
    {
        public string Nombre {  get; set; }
        public int Id_cliente {  get; set; }

        public ClienteModelo() { }
        public ClienteModelo(string nombre , int id) {
            Nombre = nombre;
            Id_cliente = id;
        }

    }
}