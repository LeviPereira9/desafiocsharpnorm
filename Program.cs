using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Nokia nokia = new("4002-8922", "Xiaomi", "CPNJ");
nokia.InstalarAplicativo("Zap");
nokia.InstalarAplicativo("Ventilador");

Console.WriteLine(nokia.Numero);
Console.WriteLine(nokia.Modelo);
Console.WriteLine(nokia.IMEI);

Console.Write("Aplicativos Instalados: ");
Console.WriteLine(string.Join(", ", nokia.aplicativos) + ".");

Console.WriteLine("---------------");

Console.WriteLine("iPhone: ");
Iphone iphone = new("1234123123", "Xiaomi MI", "CPF");
iphone.InstalarAplicativo("Google");
iphone.InstalarAplicativo("PlayStore");

Console.WriteLine(iphone.Numero);
Console.WriteLine(iphone.Modelo);
Console.WriteLine(iphone.IMEI);

Console.Write("Aplicativos Instalados: ");
Console.Write(string.Join(", ", iphone.aplicativos) + ".");
