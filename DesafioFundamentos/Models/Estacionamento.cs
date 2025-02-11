namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public object Parse { get; private set; }

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string carroregistro = Console.ReadLine();
            veiculos.Add(carroregistro);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = int.Parse(Console.ReadLine());

                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public bool ListarVeiculos()
        {
            int contador=1;
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string carro in veiculos)
                {
                    Console.WriteLine($"Carro {contador} - {carro}");
                    contador++;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
                return false;
            }
        }
    }
}
