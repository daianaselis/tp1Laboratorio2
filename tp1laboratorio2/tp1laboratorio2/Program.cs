// See https://aka.ms/new-console-template for more information
using tp1laboratorio2;

Automovil daimovil = new Automovil()
{
    CantidadPuertas = 4,
    Kilometraje = 0,
    marca = "Ford",
    modelo = "Fiesta",
    patente = "AA 123 AA",
};
Console.WriteLine($"El Auto es {daimovil.marca} de modelo {daimovil.modelo} ,con patente {daimovil.patente} tiene {daimovil.CantidadPuertas} puertas y {daimovil.Kilometraje} kilometros recorridos");
Console.WriteLine("aqui "+daimovil.ArrancarMotor());
Console.WriteLine(daimovil.Conducir());
Console.WriteLine(daimovil.PararMotor());
Console.WriteLine("\n");

Moto lamotitodeCarlitos = new Moto()
{
    EsMotocross = false,
    Kilometraje = 0,
    marca ="Yamaha",
    patente="AB 345 BA",
    modelo="110"
};

Console.WriteLine($"La moto es {lamotitodeCarlitos.marca} es modelo {lamotitodeCarlitos.modelo}, con patente {lamotitodeCarlitos.patente} ,tiene {lamotitodeCarlitos.Kilometraje} kilometros recorridos y no es de motocross {lamotitodeCarlitos.EsMotocross}");
Console.WriteLine("aqui " + lamotitodeCarlitos.ArrancarMotor());
Console.WriteLine(lamotitodeCarlitos.Conducir());
Console.WriteLine(lamotitodeCarlitos.PararMotor());
Console.WriteLine("\n");

Avion avioncito = new Avion()
{
    patente = "LV-CYT",
    marca = "Boeing",
    modelo = "77 ",
    CantidaddeAsientos=200
};
Console.WriteLine($"El avion es {avioncito.marca}, es modelo {avioncito.modelo}, con patente {avioncito.patente} ,tiene capacidad de {avioncito.CantidaddeAsientos} asientos  ");
Console.WriteLine(avioncito.ArrancarMotor());
Console.WriteLine(avioncito.Conducir());
Console.WriteLine(avioncito.PararMotor());