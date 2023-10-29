namespace desafioHospedagemHotel_NET.DesafioHospedagemHotel.Models
{
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
            //IMPLEMENTADO

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Quantidade de hospedes maior que a capacidade da suite selecionada {hospedes.Count()}");
            }
        }


        public void CadastrarSuite(Suite suite)
        {
                Console.WriteLine("╔════════════════════════════╗");
                Console.WriteLine("║  Bem-vindo ao Plaza Hotel  ║");
                Console.WriteLine("╚════════════════════════════╝");
    
                Console.WriteLine("Selecione um quarto:");
                Console.WriteLine("1 - Standard até 3 pessoas");
                Console.WriteLine("2 - Premium até 3 pessoas");
                Console.WriteLine("3 - Deluxe até 5 pessoas");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        Suite = suite;
                        break;

                    case "2":
                        Suite = suite;
                        break;

                    case "3":
                        Suite = suite;
                        break;

                    case "4":
                        
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }         
            
        }

        public int ObterQuantidadeHospedes()
        {
            //IMPLEMENTADO
            int totalDeHospedes = Hospedes.Count;

            return totalDeHospedes;

        }


        public decimal CalcularValorDiaria()
        {
            //IMPLEMENTADO

            decimal valor = DiasReservados * Suite.ValorDiaria;


            if (DiasReservados >= 10)
            {
                //IMPLEMENTADO

                decimal desconto = .90M;

                valor *= desconto;

            }
            return valor;
        }

    }
}
