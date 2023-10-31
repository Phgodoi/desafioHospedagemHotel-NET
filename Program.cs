using System.Text;
using desafioHospedagemHotel_NET.DesafioHospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("╔════════════════════════════╗");
Console.WriteLine("║  Bem-vindo ao Plaza Hotel  ║");
Console.WriteLine("╚════════════════════════════╝");


List<Pessoa> hospedes = new List<Pessoa>();


Suite suite = new Suite();

Console.WriteLine("Informe a quantidade de dias que pretende se hospedar: ");
int diasReservados = Convert.ToInt32(Console.ReadLine());

Reserva reserva = new Reserva(diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);



Console.WriteLine($"\n Total de hóspedes: {reserva.ObterQuantidadeHospedes()}, " + 
    $"Valor à ser pago por {reserva.DiasReservados} dias de hospedagem é: {reserva.CalcularValorDiaria():C}");