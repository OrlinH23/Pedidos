

Producto producto = new Producto();
producto.Id=1;
producto.Nombre="Mouse";
producto.Precio= 250.00m;
producto.Stock= 50;

Console.WriteLine("Datos del producto:");

Console.WriteLine($"Id: {producto.Id}");
Console.WriteLine($"Nombre: {producto.Nombre}");
Console.WriteLine($"Precio: {producto.Precio:C}");
Console.WriteLine($"Cantidad Disponible: {producto.Stock}");
Console.WriteLine();






