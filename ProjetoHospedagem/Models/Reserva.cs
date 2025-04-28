using System;
namespace ProjetoHospedagem.Models;

public class Reserva
{
    public Reserva(int diasReservados)
    {
        this.Hospedes = new List<Pessoa>();
        this.DiasReservados = diasReservados;
    }

    public List<Pessoa>? Hospedes { get; set; }
    public Suite? Suite { get; set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospede(List<Pessoa> hospedes)
    {
        if(hospedes.Count > Suite.Capacidade)
        {
            throw new Exception("Quantidade de hospedes é maior que a capacidade da suíte");
        }

        this.Hospedes.AddRange(hospedes);
    }

    public void CadastrarSuite(Suite suite)
    {
      this.Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        var totalHospedes = this.Hospedes.Count;
        return totalHospedes;
    }

    public decimal CalcularValorDiaria()
    {
        decimal desconto = 0M;
        var totalDiaria = this.DiasReservados * this.Suite.ValorDiaria;
        
        if(this.DiasReservados >= 10)
        {
            desconto = 10M;
            totalDiaria -= (totalDiaria * (desconto/100)); 
        }

        return totalDiaria;
    }
}
