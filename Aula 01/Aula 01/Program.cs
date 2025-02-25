using System;

Console.WriteLine("Hello, World!\n");
Console.Write("Victoria");
Console.Write("Trigueiro ");

string nomeCompleto = "Victoria Trigueiro";
string primeiroNome = "Victoria";
string ultimoNome = "Trigueiro";
string nomeMeio = "de Barros";
Console.WriteLine("Meu nome é " + primeiroNome + nomeMeio + ultimoNome);
int idade = 20;
Console.WriteLine($"Meu nome é   {primeiroNome}  {nomeMeio} {ultimoNome} e minha idade é {idade}");
Console.WriteLine("Escreva o seu Nome  ");
string nome = Console.ReadLine();
Console.WriteLine($"Ola {nome}, Boa noite !");