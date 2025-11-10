using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Teste Nokia");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456789", 16);
nokia.Ligar();

nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Cobrinha");
Console.WriteLine();

Console.WriteLine("Teste Iphone");
Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");