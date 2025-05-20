using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9912345", modelo: "Modelo 1 ", imei:"111111", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("/n");

Console.WriteLine("Smatphone Iphone");
Smartphone iphone = new Iphone(numero: "9987456", modelo: "Modelo 17", imei: "222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");