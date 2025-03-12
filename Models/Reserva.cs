namespace DesafioProjetoHospedagem.Models
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
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Quantidade de Hóspedes maior que capacidade. Tente outra suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;
        

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                return Suite.ValorDiaria * DiasReservados * 0.9m;
            }
            else
            {
                return Suite.ValorDiaria * DiasReservados;
            }
        }
    }
}