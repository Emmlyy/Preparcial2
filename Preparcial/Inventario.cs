namespace Preparcial
{
    public class Inventario
    {
        
        public string Nombre { get; set; }
        public string Descrip { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }
        public int idInventario { get; set; }

        public Inventario() { }

        public Inventario(int idInven,string nombre, string descrip , int stock,int precio)
        {
            this.idInventario = idInven;
            this.Nombre = nombre;
            this.Descrip = descrip;
            this.Stock = stock;
            this.Precio = precio;
        }
    }
}