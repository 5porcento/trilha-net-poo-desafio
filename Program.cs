using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smatphone Nokia:");
Smartphone nokia = new Nokia(numero:"1234",modelo:"modelo1",imei:"22344",64);
nokia.Ligar();
nokia.InstalarAplicativo("ZAP-ZAP");

System.Console.WriteLine("Smatphone Iphone:");
Smartphone iphone = new Iphone(numero:"45678",modelo:"12 pro max",imei:"1111111",256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");