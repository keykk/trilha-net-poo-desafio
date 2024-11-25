using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smart Nokia");
Smartphone nokia = new Nokia("123456", "Nokia", "999999999999", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("==================================================");

Console.WriteLine("Smart da Maça");
Smartphone maca = new Iphone("654321", "Maça Mordida", "88888888888", 1);
maca.Ligar();
maca.InstalarAplicativo("Youtube");