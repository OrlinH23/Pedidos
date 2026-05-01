
Console.WriteLine("Datos del producto 1:");

Producto producto = new Producto();
producto.Id=1;
producto.Nombre="Mouse";
producto.Precio= 250.00m;
producto.Stock= 50;

producto.MostrarInformacion();

//segundo producto
Console.WriteLine("Datos del producto 2:");

Producto producto2 = new Producto();
producto2.Id=2;
producto2.Nombre="Teclado";
producto2.Precio= 750.00m;
producto2.Stock= 30;

producto2.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(producto, 51);
pedido.AgregarItem(producto2, 10);
pedido.MostrarDetalles();