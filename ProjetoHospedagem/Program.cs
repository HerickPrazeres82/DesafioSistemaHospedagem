using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pedro = new Pessoa()
{
    Nome = "Pedro",
    Sobrenome = "Silva"
};

Pessoa loislene = new Pessoa()
{
    Nome = "Loislene",
    Sobrenome = "Santos"
};

Pessoa janja = new Pessoa()
{
    Nome = "Janja",
    Sobrenome = "Silva"
};

hospedes.Add(pedro);
hospedes.Add(loislene);
//hospedes.Add(janja);

Suite suite = new Suite("Premium", 2, 60M);

Reserva reserva = new(diasReservados: 15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospede(hospedes);

var totalPagar = string.Format("{0:C}", reserva.CalcularValorDiaria());

Console.WriteLine($"Total de hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Total a pagar: {totalPagar}");
