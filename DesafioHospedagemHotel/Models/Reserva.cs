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
            Console.WriteLine("Digite o nome dos Hóspedes: ");

            while (true)
            {
                string nome = Console.ReadLine();

                Console.WriteLine("Digite outro nome para continuar ou 'sair' para encerrar! ");
                if (nome.ToLower() == "sair")
                    break;

                Pessoa novaPessoa = new Pessoa(nome);
                hospedes.Add(novaPessoa);
            }

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes; 
            }
            else
            {
                Console.WriteLine("A quantidade de hóspedes excede a capacidade da suíte selecionada. Por favor, selecione outra suíte ou faça uma nova reserva.");
                Environment.Exit(0);    
            }
        }

      

        public void CadastrarSuite(Suite suite)
        {

            Console.WriteLine("Selecione um quarto:");
            Console.WriteLine("1 - STANDARD capacidade 2 pessoas, Diárias de R$ 70,00");
            Console.WriteLine("2 - PREMIUM capacidade 3 pessoas, Diárias de R$ 90,00");
            Console.WriteLine("3 - DELUXE capacidade 4 pessoas, Diárias de R$ 110,00");

            switch (Console.ReadLine())
            {
                case "1":
                    suite.Capacidade = 2;
                    suite.ValorDiaria = 70;
                    Suite = suite;
                break;

                case "2":
                    suite.Capacidade = 3;
                    suite.ValorDiaria = 90;
                    Suite = suite;
                break;

                case "3":
                    suite.Capacidade = 4;
                    suite.ValorDiaria = 110;
                    Suite = suite;
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
