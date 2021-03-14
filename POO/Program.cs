using System;
using POO.Abstração;
using POO.Poli;

namespace POO
{
    public class Program
    { 
        static void Main(string [] args)
        {
            var poli = new Polimorfismo();
            poli.Execucao();
            
            var abstracao = new Abstracao();
            abstracao.Execucao();
        }

        static void AulaInicial(string[] args)
        {
            Produto produto1 = new Produto()
            {
                Descricao = "PROCESSADOR: I5 2400 PLACA MAE: H61 MEMORIA RAM : 8GB DDR3 HD: SSD 240GB GABINETE " +
                "E FONTE ATX (GABINETE DISPONIVEL EM ESTOQUE)",
                Id = 1,
                Nome = "Pc Gamer",
                Preco = 1600.20M,
                Quantidade = 1
            };

            Cliente cliente = new Cliente()
            {
                Nome = "Augusto",
                Ativo = true,
                Email = "teste@example.com",
                Endereco = "Rua Colina Azul",
                Id = 1,
                Telefone = "+550099999999"
            };
            Console.WriteLine(" ------- Dados do Cliente ------- ");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Ativo: {cliente.Ativo}");
            Console.WriteLine($"Id: {cliente.Id}");
            Console.WriteLine($"Email: {cliente.Email}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
            Console.WriteLine("---------------------------");

            Console.WriteLine(" ------- Dados do Produto ------- ");
            Console.WriteLine($"Nome: {produto1.Nome}");
            Console.WriteLine($"Preço: {produto1.Preco}");
            Console.WriteLine($"Id: {produto1.Id}");
            Console.WriteLine($"Descrição: {produto1.Descricao}");
            Console.WriteLine($"Quantidade: {produto1.Quantidade}");

            Exibe(cliente);

        }

        public static void Exibe(Cliente cliente)
        {
            if (cliente != null)
            {
                Console.WriteLine($"Os dados do cliente {cliente.Nome} estão salvos na nossa base.");
            }
            else
            {
                Console.WriteLine("Você fez algo de errado...");
            }
        }
    }
        
}
