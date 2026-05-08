public class Producto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("*******Datos del Producto*******");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}");
        Console.WriteLine($"Cantidad Disponible: {Stock}");
    }

    public void DisminuirStock(int cantidad)
    {
        if (Stock >= cantidad)
        {
            Stock -= cantidad;
        }
         else
        {
            Console.WriteLine($"No hay suficiente stock disponible para {Nombre}.");
        }

    }
}//termina la clase producto


