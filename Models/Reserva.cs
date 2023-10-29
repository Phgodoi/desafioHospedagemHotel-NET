namespace DesafioHospedagemHotel.Models
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
            Suite = suite;
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
