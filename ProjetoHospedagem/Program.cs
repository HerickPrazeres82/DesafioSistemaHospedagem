using System.Text;
using ProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa herick = new Pessoa()
{
    Nome = "Herick",
    Sobrenome = "Prazeres"
};

Pessoa talita = new Pessoa()
{
    Nome = "Talita",
    Sobrenome = "de Melo Rodrigues"
};

Pessoa janja = new Pessoa()
{
    Nome = "Janja",
    Sobrenome = "Silva"
};

hospedes.Add(herick);
hospedes.Add(talita);
//hospedes.Add(janja);

Suite suite = new Suite("Premium", 2, 60M);

Reserva reserva = new Reserva(diasReservados: 15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospede(hospedes);

var totalPagar = string.Format("{0:C}", reserva.CalcularValorDiaria());

Console.WriteLine($"Total de hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Total a pagar: {totalPagar}");
