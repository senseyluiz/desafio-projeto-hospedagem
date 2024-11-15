using DesafioProjetoHospedagem.Models;

Pessoa luis = new("Luis", "Figueiredo");
Pessoa lucas = new("Lucas", "Ribeiro");
Pessoa diogo = new("Digogo", "Oliveira");
Pessoa paulo = new("Paulo", "Constantino");
Pessoa rubens = new("Rubens", "Castanheira");

Suite suiteBasica = new("Basica", 4, 30);
Suite suitePremium = new("Premium", 3, 60);

Reserva reserva1 = new(5);
reserva1.CadastrarSuite(suiteBasica);
reserva1.CadastrarHospedes(luis);
reserva1.CadastrarHospedes(lucas);
reserva1.CadastrarHospedes(diogo);
reserva1.CadastrarHospedes(paulo);
// reserva1.CadastrarHospedes(rubens);

System.Console.WriteLine($"Hóspedes: {reserva1.ObterQuantidadeHospedes()}");
System.Console.WriteLine($"Valor a pagar: {reserva1.CalcularValorDiaria()}");

