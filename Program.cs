﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone nokia: ");
Smartphone nokia = new Nokia(numero:"50030266", modelo:"pro", imei:"1000101101", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"12349874", modelo:"proMax", imei:"0110110110", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");