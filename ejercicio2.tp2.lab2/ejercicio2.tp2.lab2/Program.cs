// See https://aka.ms/new-console-template for more information
using ejercicio2.tp2.lab2;

Coche auto  = new Coche()
{
 Marca= "volkswagen",
 Modelo="Polo",
 Patente="AB 123 JK",
 CantidadPuertas=5,
 Color="Amarillo"
};
Console.WriteLine($"El auto es de la marca {auto.Marca} su modelo es {auto.Marca}, tiene {auto.CantidadPuertas} puertas y es de color {auto.Color} ");
Console.WriteLine(auto.CargarBaul());
Console.WriteLine(auto.Arrancar());
Console.WriteLine(auto.Detenerse());
Console.WriteLine("\n");
ColectivoPasajeros bondi = new ColectivoPasajeros()
{
    Marca = "Mercedes Benz.",
    Modelo = "WELLY 59480 ",
    Patente = "AB 123 JK",
    CantidadPuertas = 3,
    Color = "Rosa",
};
Console.WriteLine($"El colectiovo es de la marca {bondi.Marca} su modelo es {bondi.Modelo}, tiene {bondi.CantidadPuertas} puertas y es de color {bondi.Color}");
Console.WriteLine(bondi.Arrancar());
Console.WriteLine(bondi.Detenerse());
Console.WriteLine(bondi.RecojerPasajeros());
