public class Pedido
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }

    public List<ItemPedido> Items { get; set; }

    public decimal total => Items.Sum(item => item.Subtotal);

    public Pedido(int IdPedido)
    {
        
        Id = IdPedido;
        Items = new List<ItemPedido>();
    }
       public void AgregarItem(Producto Producto, int Cantidad)
    {
       

        if(Producto.Stock >= Cantidad)
        {
            Items.Add(new ItemPedido(Producto, Cantidad));
            Console.WriteLine($"El producto {Producto.Nombre} con cantidad {Cantidad} se ha agregado al pedido.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"No hay suficiente stock disponible para {Producto.Nombre}.");
            Console.WriteLine();
        }

    }
    public void MostrarDetalles()
    {
         Console.WriteLine("------------------------");
         Console.WriteLine($"Detalles del pedido #{Id}:");
         Console.WriteLine($"Fecha: {Fecha:dd/MM/yyyy hh:mm:ss tt}");

         foreach(ItemPedido item in Items)
         {
            Console.WriteLine($"Producto: {item.Producto.Nombre},Cantidad: {item.Cantidad}, Subtotal: {item.Subtotal:C}");
            
         }
           Console.WriteLine($"Total: {total:C}");
           Console.WriteLine("------------------------");
           Console.WriteLine();
    }

}
