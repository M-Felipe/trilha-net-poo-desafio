
using Celular.Models;

Nokia nokia = new("123456789", "Nokia 3310", "123456789012345", 16);
Iphone iphone = new("987654321", "iPhone 13", "543210987654321", 128);

Console.WriteLine("Teste Nokia:");
nokia.Ligar();
nokia.ReceverLigacao();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("Teste Iphone:");
iphone.Ligar();
iphone.ReceverLigacao();
iphone.InstalarAplicativo("Instagram");
