using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo: "Nokia 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "37286", modelo: "Iphone 15", imei: "22222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");