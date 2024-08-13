using System.Security.Cryptography.X509Certificates;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Adiciona veículo na variável 'veiculos'.
        /// </summary>
        public void AdicionarVeiculo()
        {

            Console.WriteLine("Digite a placa do veículo para estacionar:");

            //Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            veiculos.Add(Console.ReadLine());
        }

        /// <summary>
        /// Remove veículo da variável 'veiculos'.
        /// </summary>
        public void RemoverVeiculo()
        {
            string placa = "";
            
            Console.WriteLine("Digite a placa do veículo para remover:");
    
            //Pedir para o usuário digitar a placa e armazenar na variável placa
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                //Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                horas = Convert.ToInt16(Console.ReadLine());

                //Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                valorTotal = precoInicial + precoPorHora * horas;

                //Remover a placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }

        /// <summary>
        /// Lista veículos da variável 'veiculos'.
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                //Realizar um laço de repetição, exibindo os veículos estacionados
                foreach(var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
