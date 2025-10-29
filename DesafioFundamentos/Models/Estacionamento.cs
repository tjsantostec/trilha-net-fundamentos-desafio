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

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            string placa = " ";
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);

        }

        public void RemoverVeiculo()
        {        
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
           string placa = " ";
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();
            //formata a placa digitada no padrão ABC-1234
            FormatarPlaca(placa);

            // Verifica se o veículo existe comparando com o valor já formatado
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // *IMPLEMENTE AQUI*
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());
               
               
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                

                decimal valorTotal = 0;
                valorTotal = horas * precoPorHora + precoInicial;
                Console.WriteLine($"O veículo {FormatarPlaca(placa)} foi removido e o preço total foi de: R$ {valorTotal}");
                // TODO: Remover a placa digitada da lista de veículos
                 veiculos.Remove(placa);
                 
                // *IMPLEMENTE AQUI*         
                 
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string listaveiculos in veiculos)
                {

                    // TODO: Realizar um laço de repetição, exibindo os veículos estacionados formatando os itens da lista para o padrão ABC-1234
                    // *IMPLEMENTE AQUI*
                    Console.WriteLine($"{FormatarPlaca(listaveiculos)}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        //formata o valor de entrada da placa mesmo se digitado em minúsculo e retorna maiúsculo 
         private static string FormatarPlaca(string placa)
        {
            // Remove quaisquer hífens que possam já existir e o .ToUpper converte
            // caracteres em MAIÚSCULOS
      
        placa = placa.Replace("-", "").ToUpper();

            if (placa.Length == 7)
            {
                // Placa padrão  (ABC-1234)
                return $"{placa.Substring(0, 3)}-{placa.Substring(3)}" ;
            }
   
        // Retorna a placa original se não for um formato reconhecido
      return placa ;
    }
    }
}
