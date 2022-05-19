// See https://aka.ms/new-console-template for more information
using Patron_decorador_Gonzalo_figlioli;

Console.WriteLine("Hello, World!");





BurgerComponent burger = new BurgerSmash();
burger = new Pepinillos(burger);
burger = new Pan_papa(burger);
burger = new Queso(burger);

Console.WriteLine($"Producto:  {burger.Descripcion} tiene un costo de : ${burger.precio}");

burger = new _180burger();
burger = new Pan_papa(burger);

Console.WriteLine($"Producto:  {burger.Descripcion} tiene un costo de : ${burger.precio}");

burger = new NormalBurger();
burger = new Queso(burger);
burger = new Pepinillos(burger);

Console.WriteLine($"Producto:  {burger.Descripcion} tiene un costo de : ${burger.precio}");


Console.ReadKey();
    






