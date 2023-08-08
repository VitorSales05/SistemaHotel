using System.Text;
using Desafio_Hotel.Models;

Console.OutputEncoding = Encoding.UTF8;



List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Vitor");
Pessoa p2 = new Pessoa("Tiago");
Pessoa p3 = new Pessoa("Antonio");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 50);


Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R${reserva.CalcularValorDiaria()}");
