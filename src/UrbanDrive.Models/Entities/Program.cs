using System;
using UrbanDrive.Entities;

namespace UrbanDrive
{
    internal class Program
    {
        static void Main()
        {
            Veiculo veiculo = new Veiculo(1, "ABC1D23", "Fiat Uno", 120.00m);
            Frota frota = new Frota();
            frota.AdicionarVeiculo(veiculo);

            while (true)
            {
                Console.WriteLine("\n=== UrbanDrive — Sprint 1 ===");
                Console.WriteLine("1 - Mostrar veículo atual");
                Console.WriteLine("2 - Criar veículo com uma placa digitada");
                Console.WriteLine("3 - Alterar a placa do veículo atual");
                Console.WriteLine("4 - Exibir veículos da frota");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine() ?? "0";

                if (opcao == "0")
                    break;

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            veiculo.ExibirInformacoes();
                        break;

                        case "2":
                            Console.Write("Digite a placa do novo veículo: ");
                            string placaNovoVeiculo = Console.ReadLine() ?? "";
                            veiculo = new Veiculo(2, placaNovoVeiculo, "Modelo teste", 80.00m);
                            Console.WriteLine("Veículo criado com sucesso.");
                            veiculo.ExibirInformacoes();
                        break;

                        case "3":
                            Console.Write("Digite a nova placa: ");
                            string novaPlaca = Console.ReadLine() ?? "";
                            veiculo.Placa = novaPlaca;
                            Console.WriteLine("Placa alterada com sucesso.");
                            veiculo.ExibirInformacoes();
                        break;

                        case "4":
                            frota.ExibirVeiculos();
                        break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Valor inválido: {ex.Message}");
                }
            }
        }
    }
}
