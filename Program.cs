public class Usuario
{ 
    public int id;
    public string nombre;
    public string apellido;
    public string nombreUsuario;
    public string contraseña;
    public string mail;


}


public class Producto 

{
    public int id;
    public string descripcion;
    public double costo;
    public double precioDeVenta;
    public string stock;
    public int idUsuario;

}

public class ProductoVendido

{
    public int id;
    public int idProducto;
    public int dtock;
    public int idVenta;


}

public class Venta
{
    public int id;
    public string Comentarios;
}