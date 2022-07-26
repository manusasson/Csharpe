public class Usuario
{ 
    Private int id;
    Private string nombre;
    Private string apellido;
    Private string nombreUsuario;
    Private string contraseña;
    Private string mail;


}


public class Producto 

{
    Private int id;
    Private string descripcion;
    Private double costo;
    Private double precioDeVenta;
    Private string stock;
    Private int idUsuario;

}

public class ProductoVendido

{
    Private int id;
    Private int idProducto;
    Private int dtock;
    Private int idVenta;


}

public class Venta
{
    Private int id;
    Private string Comentarios;
}