namespace Desafio_Hotel.Models;

public class Reserva
{

    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }


    public Reserva() { }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }


    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        int capacidadeSuite = Suite.Capacidade;
        int quantidadeHospedes = hospedes.Count; 

        if(capacidadeSuite >= quantidadeHospedes)
        {
            Hospedes = hospedes;
        }
        else
        {
            Console.WriteLine("Hotel com lotação máxima.");
        }
    }


    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }


    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }


    public decimal CalcularValorDiaria()
    {
        decimal valorDiariaSuite = Suite.ValorDiaria;
        int diasReservados = DiasReservados;

        decimal valorDiaria = valorDiariaSuite * diasReservados;


        if (diasReservados >= 10)
        {
            valorDiaria = valorDiaria - (valorDiaria / 10);
        }

        return valorDiaria;
    }

}
