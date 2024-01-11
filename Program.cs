using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("");
Console.WriteLine("Inicializando testes no Nokia");
Console.WriteLine("");

Nokia celular1  = new Nokia(numero : "119321938", modelo : "Nokia 2000", imei : "987654321", memoria : 8400);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Snake game");

Console.WriteLine("");
Console.WriteLine("Inicializando testes no Iphone");
Console.WriteLine("");

Iphone celular2 = new Iphone(numero : "119321938", modelo : "Nokia 2000", imei : "987654321", memoria : 8400);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Whatsapp");
Console.WriteLine("");