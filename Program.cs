
Console.WriteLine("Datos del producto 1:");

Producto producto = new Producto();
producto.Id=1;
producto.Nombre="Mouse";
producto.Precio= 250.00m;
producto.Stock= 80;

producto.MostrarInformacion();

//segundo producto
Console.WriteLine("Datos del producto 2:");

Producto producto2 = new Producto();
producto2.Id=2;
producto2.Nombre="Teclado";
producto2.Precio= 750.00m;
producto2.Stock= 30;

Electronico electronico=new Electronico();
electronico.Id=3;
electronico.Nombre="Iphone 17 Pro Max";
electronico.Precio= 15000.00m;
electronico.Stock= 20;
electronico.GarantiaMeses= 24;      
electronico.Voltaje= "110V";
electronico.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(producto, 51);
pedido.AgregarItem(producto2, 10);
pedido.AgregarItem(electronico, 1);
pedido.MostrarDetalles();

