using DesafioProjetoHospedagem.Models;

Pessoa luis = new("Luis Henrique", "Sales da Rocha");
string nomeCompleto = luis.NomeCompleto();
Suite suite1 = new("Premium", 3, 30);


System.Console.WriteLine(suite1.ResumoSuite());
